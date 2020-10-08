﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Security.Principal;
using System.Management;
using SuperGrate.UserList;
using SuperGrate.IO;
using System.Windows.Forms;

namespace SuperGrate
{
    class Misc
    {
        /// <summary>
        /// A list of Local, Non-Domain SIDs on a host set by: GetLocalUsersSIDsFromHost().
        /// </summary>
        //public static Dictionary<string, string> LocalSIDToUser = new Dictionary<string, string>();
        /// <summary>
        /// If true, will cancel any task pertaining to Remote Profile Deletions.
        /// </summary>
        private static bool ShouldCancelRemoteProfileDelete = false;
        /// <summary>
        /// Checks if the host provided is the current machine running Super Grate.
        /// </summary>
        /// <param name="Host">Hostname to check against.</param>
        /// <returns>True if is this machine, false if otherwise.</returns>
        public static bool IsHostThisMachine(string Host)
        {
            if (Host == "127.0.0.1" || Host == "::1" || Host.ToLower() == "localhost") return true;
            if (Host.ToLower() == Environment.MachineName.ToLower())
            {
                return true;
            }
            if (Host.Split('.').Length > 0 && Host.Split('.')[0].ToLower() == Environment.MachineName.ToLower())
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Returns the best path to C:\ based on the host provided. (If the host provided is the current host then the best path is "C:\" otherwise it is "\\HOST\C$\".)
        /// </summary>
        /// <param name="Host">Host to check against.</param>
        /// <returns>Either "C:\" or "\\HOST\C$\".</returns>
        public static string GetBestPathToC(string Host)
        {
            if (IsHostThisMachine(Host))
            {
                return @"C:\";
            }
            else
            {
                return @"\\" + Host + @"\C$\";
            }
        }
        /// <summary>
        /// Fills the LocalSIDToUser property for other methods in this class with a list of SIDs (Security Identifiers / Local User Profiles (Non-Domain)) from a host.
        /// </summary>
        /// <param name="Host">Host to get SIDs from.</param>
        /*public static async void GetLocalUsersSIDsFromHost(string Host)
        {
            LocalSIDToUser.Clear();
            try
            {
                foreach (ManagementObject manObj in await WMI.Query("SELECT SID, Caption FROM Win32_UserAccount WHERE LocalAccount=TRUE", Host))
                {
                    LocalSIDToUser.Add((string)manObj["SID"], (string)manObj["Caption"]);
                }
            }
            catch (Exception e)
            {
                Logger.Exception(e, "Failed to get a list of Local Users' SIDs from host: " + Host + ".");
            }
        }*/
        /// <summary>
        /// Attempts to resolve an identity (Store ID / Security ID) to a DOMAIN\USERNAME string. If failed, returns the given identity string.
        /// </summary>
        /// <param name="Identity">A Store ID or SID (Security Identifier) to resolve.</param>
        /// <returns>DOMAIN\USERNAME.</returns>
        public static async Task<string> GetUserByIdentity(string Identity, string Host = null)
        {
            if (Host != null) {
                try
                {
                    ManagementObject mo = await WMI.GetInstance(Host, "Win32_SID.SID=\"" + Identity + "\"");
                    string NTDomain = mo.GetPropertyValue("ReferencedDomainName").ToString();
                    string NTAccountName = mo.GetPropertyValue("AccountName").ToString();
                    string NTAccount = NTDomain + "\\" + NTAccountName;
                    if (NTDomain == "" || NTAccountName == "") throw new Exception();
                    return NTAccount;
                }
                catch (Exception)
                {
                    Logger.Verbose("Could not resolve SID via WMI, trying the store...");
                }
            }
            string fNTAccount = Path.Combine(Config.Settings["MigrationStorePath"], Identity, "ntaccount");
            if (File.Exists(fNTAccount))
            {
                string NTAccount = File.ReadAllText(fNTAccount);
                if (NTAccount != "")
                {
                    return NTAccount;
                }
            }
            Logger.Warning("Could not resolve SID: " + Identity + ".");
            return Identity;
        }
        /// <summary>
        /// Retrieves a single users properties from a Host.
        /// </summary>
        /// <param name="TemplateRow">A template row to fill in with information from the host.</param>
        /// <param name="Host">A host computer to get the information from.</param>
        /// <param name="SID">An SID (Security Identifier) of the user profile on the host.</param>
        /// <returns>Filled in UserRow.</returns>
        public static Task<UserRow> GetUserFromHost(UserRow TemplateRow, string Host, string SID)
        {
            return Task.Run(async () =>
            {
                UserRow row = new UserRow(TemplateRow);
                RegistryKey remoteReg = null;
                if (IsHostThisMachine(Host))
                {
                    remoteReg = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
                }
                else
                {
                    remoteReg = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, Host);
                }
                string user = await GetUserByIdentity(SID, Host);
                Logger.Verbose("Found: " + user);
                bool setting;
                if (bool.TryParse(Config.Settings["HideBuiltInAccounts"], out setting) && setting && (user.Contains("NT AUTHORITY") || user.Contains("NT SERVICE")))
                {
                    Logger.Verbose("Skipped: " + SID + ": " + user + ".");
                    return null;
                }
                if (bool.TryParse(Config.Settings["HideUnknownSIDs"], out setting) && setting && SID == user)
                {
                    Logger.Verbose("Skipped unknown SID: " + SID + ".");
                    return null;
                }
                row[ULColumnType.Tag] = SID;
                if (row.ContainsKey(ULColumnType.NTAccount))
                {
                    row[ULColumnType.NTAccount] = user;
                }
                if (row.ContainsKey(ULColumnType.LastModified) || row.ContainsKey(ULColumnType.Size) || row.ContainsKey(ULColumnType.FirstCreated))
                {
                    RegistryKey profileReg = remoteReg.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList\" + SID, false);
                    string profilePathReg = (string)profileReg.GetValue("ProfileImagePath");
                    if (profilePathReg == null)
                    {
                        Logger.Verbose("Skipped SID with no profile directory: " + SID + ".");
                        return null;
                    }
                    string profilePath = profilePathReg.Replace(@"C:\", GetBestPathToC(Host));
                    if (row.ContainsKey(ULColumnType.Size))
                    {
                        Logger.Information("Calculating profile size for: " + user + "...");
                        double size = await FileOperations.GetFolderSize(profilePath);
                        row[ULColumnType.Size] = size.ToString();
                    }
                    if (row.ContainsKey(ULColumnType.FirstCreated))
                    {
                        row[ULColumnType.FirstCreated] = Directory.GetCreationTime(profilePath).ToFileTime().ToString();
                    }
                    if (row.ContainsKey(ULColumnType.LastModified))
                    {
                        row[ULColumnType.LastModified] = File.GetLastWriteTime(Path.Combine(profilePath, "NTUSER.DAT")).ToFileTime().ToString();
                    }
                }
                remoteReg.Close();
                return row;
            });
        }
        public static Task<string> GetHostNameFromHost(string Host)
        {
            return Task.Run(async () =>
            {
                try
                {
                    string name = "";
                    foreach (ManagementObject mo in await WMI.Query("SELECT Name FROM Win32_ComputerSystem", Host))
                    {
                        name = mo["Name"].ToString();
                    }
                    return name;
                }
                catch (Exception e)
                {
                    Logger.Exception(e, "Failed to get computer name from: " + Host);
                    return null;
                }
            });
        }
        /// <summary>
        /// Retrieves users' properties from host based on the ULControl.CurrentHeaderRow property.
        /// </summary>
        /// <param name="Host">Host to get information from.</param>
        /// <returns>UserRows.</returns>
        public static Task<UserRows> GetUsersFromHost(string Host)
        {
            return Task.Run(async () =>
            {
                try
                {
                    UserRows rows = new UserRows();
                    Logger.Information("Getting list of users on: " + Host + "...");
                    int count = 0;
                    ManagementObjectCollection manObjCol = await WMI.Query("SELECT SID FROM Win32_UserProfile", Host);
                    foreach (ManagementObject mo in manObjCol)
                    {
                        if (Main.Canceled) break;
                        UserRow row = await GetUserFromHost(ULControl.CurrentHeaderRow, Host, mo["SID"].ToString());
                        Logger.UpdateProgress((int)(((float)++count / manObjCol.Count) * 100));
                        if (row != null) rows.Add(row);
                    }
                    if (Main.Canceled)
                    {
                        Logger.Warning("Listing users was canceled.");
                        return null;
                    }
                    Logger.Success("Users listed successfully.");
                    return rows;
                }
                catch (System.Security.SecurityException e)
                {
                    Logger.Exception(e, "Failed to get a list of users. Please make sure the user \"" + Environment.UserDomainName + "\\" + Environment.UserName + "\" is an administrator on the host: " + Host);
                    return null;
                }
                catch (Exception e)
                {
                    Logger.Exception(e, "Failed to get a list of users. Please make sure that the specified host is valid and online, also make sure the \"Remote Registry\" service is enabled and running on the specified host: " + Host);
                    return null;
                }
            });
        }
        /// <summary>
        /// Gets SID string from an Object in the Store.
        /// </summary>
        /// <param name="ID">ID of the Store Object.</param>
        /// <returns>String of SID.</returns>
        static public Task<string> GetSIDFromStore(string ID)
        {
            return Task.Run(() => {
                try
                {
                    string SIDPath = Path.Combine(Config.Settings["MigrationStorePath"], ID, "sid");
                    if (File.Exists(SIDPath))
                    {
                        return File.ReadAllText(SIDPath);
                    }
                    else
                    {
                        Logger.Error("Failed to get SID from store ID: " + ID);
                        return null;
                    }
                }
                catch (Exception e)
                {
                    Logger.Exception(e, "Failed to get SID from store ID: " + ID);
                    return null;
                }
            });
        }
        /// <summary>
        /// Gets a single user from the Backup Store and returns the information in a UserRow object.
        /// </summary>
        /// <param name="TemplateRow">A template UserRow to fill the values of.</param>
        /// <param name="ID">Backup Store ID to retrieve.</param>
        /// <returns>UserRow object.</returns>
        static public Task<UserRow> GetUserFromStore(UserRow TemplateRow, string ID)
        {
            Dictionary<ULColumnType, string> Files = new Dictionary<ULColumnType, string>
            {
                { ULColumnType.NTAccount, "ntaccount" },
                { ULColumnType.SourceComputer, "source" },
                { ULColumnType.DestinationComputer, "destination" },
                { ULColumnType.ImportedBy, "importedby" },
                { ULColumnType.ImportedOn, "importedon" },
                { ULColumnType.ExportedBy, "exportedby" },
                { ULColumnType.ExportedOn, "exportedon" }
            };
            return Task.Run(() =>
            {
                try
                {
                    string StoreItemPath = Path.Combine(Config.Settings["MigrationStorePath"], ID);
                    UserRow row = new UserRow(TemplateRow);
                    DirectoryInfo info = new DirectoryInfo(StoreItemPath);
                    row[ULColumnType.Tag] = info.Name;
                    string DataFilePath = Path.Combine(StoreItemPath, "data");
                    if (row.ContainsKey(ULColumnType.Size))
                    {
                        row[ULColumnType.Size] = new FileInfo(DataFilePath).Length.ToString();
                    }
                    foreach (KeyValuePair<ULColumnType, string> file in Files)
                    {
                        string filePath = Path.Combine(StoreItemPath, file.Value);
                        if (row.ContainsKey(file.Key) && File.Exists(filePath))
                        {
                            row[file.Key] = File.ReadAllText(filePath);
                        }
                    }
                    return row;
                }
                catch (Exception e)
                {
                    Logger.Exception(e, "Failed to get user from store, ID: " + ID);
                    return null;
                }
            });
        }
        /// <summary>
        /// Retrieves users from the Backup Store in a UserRows object. (UserRows are based off of the ULControl.CurrentHeaderRow property.)
        /// </summary>
        /// <returns>A UserRow object.</returns>
        static public Task<UserRows> GetUsersFromStore()
        {
            return Task.Run(async () =>
            {
                try
                {
                    string StorePath = Config.Settings["MigrationStorePath"];
                    Logger.Information("Listing users from store: " + StorePath + "...");
                    UserRows rows = new UserRows();
                    int count = 0;
                    DirectoryInfo[] directories = new DirectoryInfo(StorePath).GetDirectories();
                    foreach (DirectoryInfo directory in directories)
                    {
                        UserRow row = await GetUserFromStore(ULControl.CurrentHeaderRow, directory.Name);
                        if (row == null)
                        {
                            Logger.Warning("Skipping ID: " + directory.Name);
                            continue;
                        }
                        rows.Add(row);
                        Logger.UpdateProgress((int)(((float)++count / directories.Length) * 100));
                        Logger.Verbose("Found: " + row[ULColumnType.NTAccount]);
                    }
                    Logger.Success("Users listed successfully.");
                    return rows;
                }
                catch (Exception e)
                {
                    Logger.Exception(e, "Failed to list users from store.");
                    return null;
                }
            });
        }
        /// <summary>
        /// Deletes store items based on their ID.
        /// </summary>
        /// <param name="IDs">List of IDs (Profile Backups) to delete from the store.</param>
        /// <returns>Awaitable Task.</returns>
        public static Task DeleteFromStore(string[] IDs)
        {
            return Task.Run(async () =>
            {
                foreach (string ID in IDs)
                {
                    string name = await GetUserByIdentity(ID);
                    Logger.Information("Deleting '" + name + "' from the Store...");
                    try
                    {
                        Directory.Delete(Path.Combine(Config.Settings["MigrationStorePath"], ID), true);
                        Logger.Success("'" + name + "' successfully deleted from the Store.");
                    }
                    catch (Exception e)
                    {
                        Logger.Exception(e, "Failed to delete '" + name + "' from the store.");
                    }
                }
            });
        }
        /// <summary>
        /// Deletes a list of SIDs (Security Identifiers (User Profiles)) from a host.
        /// </summary>
        /// <param name="Host">Host to delete profiles from.</param>
        /// <param name="SIDs">List of SIDs that identify the profiles that need to be deleted.</param>
        /// <returns>Awaitable Task.</returns>
        public static Task DeleteFromSource(string Host, string[] SIDs)
        {
            ShouldCancelRemoteProfileDelete = false;
            return Task.Run(async () =>
            {
                try
                {
                    Logger.Information("Sending Profile Delete Daemon...");
                    string exePath = Path.Combine(GetBestPathToC(Host), @"ProgramData\SuperGratePD.exe");
                    FileStream SuperGratePD = File.OpenWrite(exePath);
                    SuperGratePD.Write(
                        Properties.Resources.SuperGrateProfileDelete,
                        0,
                        Properties.Resources.SuperGrateProfileDelete.Length
                    );
                    SuperGratePD.Close();
                    int count = 0;
                    foreach (string SID in SIDs)
                    {
                        if (ShouldCancelRemoteProfileDelete) break;
                        string name = await GetUserByIdentity(SID);
                        Logger.Information("Deleting '" + name + "' from " + Host + "...");
                        await Remote.StartProcess(
                            Host,
                            @"C:\ProgramData\SuperGratePD.exe " + SID,
                            @"C:\ProgramData\"
                        );
                        Logger.UpdateProgress((int)((++count - 0.5) / SIDs.Length * 100));
                        await Remote.WaitForProcessExit(Host, "SuperGratePD");
                    }
                    Logger.Information("Removing Daemon...");
                    File.Delete(exePath);
                    Logger.Success("Done.");
                }
                catch (Exception e)
                {
                    Logger.Exception(e, "Failed to delete user(s) from target: " + Host + ".");
                }
            });
        }
        /// <summary>
        /// Cancels the agent on the remote computer running the profile delete command.
        /// </summary>
        /// <param name="Host">Hostname to cancel profile delete agent on.</param>
        public static async void CancelRemoteProfileDelete(string Host)
        {
            ShouldCancelRemoteProfileDelete = true;
            Logger.Information("Sending KILL command to remote target...");
            if (await Remote.KillProcess(Host, "SuperGratePD.exe"))
            {
                Logger.Success("KILL command sent.");
            }
            else
            {
                Logger.Error("Failed to send KILL command.");
            }
        }
        /// <summary>
        /// Gets the CPU architecture from a remote host.
        /// </summary>
        /// <param name="Host">Host to get the architecture information from.</param>
        /// <returns>CPU architecture.</returns>
        public static Task<OSArchitecture> GetRemoteArch(string Host)
        {
            Logger.Information("Reading OS Architecture...");
            return Task.Run(async () => {
                try
                {
                    foreach (ManagementObject manObj in await WMI.Query("SELECT OSArchitecture FROM Win32_OperatingSystem", Host))
                    {
                        string rawArch = (string)manObj["OSArchitecture"];
                        OSArchitecture arch = OSArchitecture.X86;
                        if (rawArch.Contains("64")) arch = OSArchitecture.X64;
                        Logger.Information("OS Architecture is: " + arch + ".");
                        return arch;
                    }
                }
                catch (Exception e)
                {
                    Logger.Exception(e, "Failed to read the OS Architecture from host: " + Host + ".");
                }
                return OSArchitecture.Unknown;
            });
        }
        /// <summary>
        /// Enables or disables top level menu items in a MainMenu object.
        /// </summary>
        /// <param name="Menu">The MainMenu object.</param>
        /// <param name="Enabled">Enable or disable the menu items?</param>
        /// <param name="Menus">An array of top level menu items' "text" properties to affect.</param>
        public static void MainMenuSetState(MainMenu Menu, bool Enabled, string[] Menus = null)
        {
            List<string> lMenus = new List<string>();
            if (Menus != null) lMenus.AddRange(Menus);
            foreach (MenuItem mi in Menu.MenuItems)
            {
                if (Menus != null && !lMenus.Contains(mi.Text)) continue;
                mi.Enabled = Enabled;
            }
        }
        public enum OSArchitecture
        {
            Unknown = 0,
            X86 = 1,
            X64 = 2
        }
    }
}