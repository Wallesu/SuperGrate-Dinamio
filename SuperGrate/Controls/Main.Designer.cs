﻿using SuperGrate.Classes;
using SuperGrate.Controls.Components;

namespace SuperGrate
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.logTable = new System.Windows.Forms.TableLayoutPanel();
            this.spltContainer = new System.Windows.Forms.SplitContainer();
            this.tblMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sourCompTabl = new System.Windows.Forms.TableLayoutPanel();
            this.lblSourceComputer = new System.Windows.Forms.Label();
            this.lblDestinationComputer = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.tbleListUsersButtons = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLogoBorder = new System.Windows.Forms.Panel();
            this.imgLoadLogo = new System.Windows.Forms.PictureBox();
            this.destCompTabl = new System.Windows.Forms.TableLayoutPanel();
            this.listUsers = new System.Windows.Forms.ListView();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.miFile = new System.Windows.Forms.MenuItem();
            this.miNewInstance = new System.Windows.Forms.MenuItem();
            this.miSpacer0 = new System.Windows.Forms.MenuItem();
            this.miSettings = new System.Windows.Forms.MenuItem();
            this.miSpace9 = new System.Windows.Forms.MenuItem();
            this.miSaveLog = new System.Windows.Forms.MenuItem();
            this.miSpacer3 = new System.Windows.Forms.MenuItem();
            this.miExitButton = new System.Windows.Forms.MenuItem();
            this.miView = new System.Windows.Forms.MenuItem();
            this.miAddRemoveCol = new System.Windows.Forms.MenuItem();
            this.miSeperator65 = new System.Windows.Forms.MenuItem();
            this.miViewLarge = new System.Windows.Forms.MenuItem();
            this.miViewSmall = new System.Windows.Forms.MenuItem();
            this.miViewList = new System.Windows.Forms.MenuItem();
            this.miViewDetail = new System.Windows.Forms.MenuItem();
            this.miViewTile = new System.Windows.Forms.MenuItem();
            this.miHelp = new System.Windows.Forms.MenuItem();
            this.miDocumentation = new System.Windows.Forms.MenuItem();
            this.miIssues = new System.Windows.Forms.MenuItem();
            this.miSpacer1 = new System.Windows.Forms.MenuItem();
            this.miUpdateCheck = new System.Windows.Forms.MenuItem();
            this.miSeperator55 = new System.Windows.Forms.MenuItem();
            this.miAboutSG = new System.Windows.Forms.MenuItem();
            this.dialogSaveLog = new System.Windows.Forms.SaveFileDialog();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.miConUser = new System.Windows.Forms.ContextMenu();
            this.miConStart = new System.Windows.Forms.MenuItem();
            this.miConRename = new System.Windows.Forms.MenuItem();
            this.miConDelete = new System.Windows.Forms.MenuItem();
            this.miConSeperator = new System.Windows.Forms.MenuItem();
            this.miConProperties = new System.Windows.Forms.MenuItem();
            this.tbSourceComputer = new SuperGrate.Controls.Components.SGTextBox();
            this.btnAFillSrc = new SuperGrate.Controls.Components.SGButton();
            this.btnStartStop = new SuperGrate.Controls.Components.SGButton();
            this.btnListSource = new SuperGrate.Controls.Components.SGButton();
            this.btnListStore = new SuperGrate.Controls.Components.SGButton();
            this.btnDelete = new SuperGrate.Controls.Components.SGButton();
            this.btnAFillDest = new SuperGrate.Controls.Components.SGButton();
            this.tbDestinationComputer = new SuperGrate.Controls.Components.SGTextBox();
            this.pbMain = new SuperGrate.Controls.Components.SGProgressBar();
            this.logTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltContainer)).BeginInit();
            this.spltContainer.Panel1.SuspendLayout();
            this.spltContainer.Panel2.SuspendLayout();
            this.spltContainer.SuspendLayout();
            this.tblMainLayout.SuspendLayout();
            this.sourCompTabl.SuspendLayout();
            this.tbleListUsersButtons.SuspendLayout();
            this.pnlLogoBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadLogo)).BeginInit();
            this.destCompTabl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.ForeColor = System.Drawing.Color.White;
            this.LogBox.Location = new System.Drawing.Point(3, 4);
            this.LogBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(385, 224);
            this.LogBox.TabIndex = 0;
            this.LogBox.TabStop = false;
            this.LogBox.Text = "";
            this.LogBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LogBox_LinkClicked);
            this.LogBox.DoubleClick += new System.EventHandler(this.LogBox_DoubleClick);
            // 
            // logTable
            // 
            this.logTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.logTable.ColumnCount = 1;
            this.logTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logTable.Controls.Add(this.LogBox, 0, 0);
            this.logTable.Controls.Add(this.pbMain, 0, 1);
            this.logTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTable.Location = new System.Drawing.Point(0, 0);
            this.logTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logTable.Name = "logTable";
            this.logTable.RowCount = 2;
            this.logTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.logTable.Size = new System.Drawing.Size(391, 268);
            this.logTable.TabIndex = 100;
            // 
            // spltContainer
            // 
            this.spltContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.spltContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltContainer.Location = new System.Drawing.Point(5, 5);
            this.spltContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spltContainer.Name = "spltContainer";
            // 
            // spltContainer.Panel1
            // 
            this.spltContainer.Panel1.Controls.Add(this.tblMainLayout);
            this.spltContainer.Panel1MinSize = 400;
            // 
            // spltContainer.Panel2
            // 
            this.spltContainer.Panel2.Controls.Add(this.logTable);
            this.spltContainer.Panel2MinSize = 300;
            this.spltContainer.Size = new System.Drawing.Size(974, 268);
            this.spltContainer.SplitterDistance = 579;
            this.spltContainer.TabIndex = 0;
            this.spltContainer.TabStop = false;
            // 
            // tblMainLayout
            // 
            this.tblMainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tblMainLayout.ColumnCount = 2;
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.Controls.Add(this.sourCompTabl, 1, 0);
            this.tblMainLayout.Controls.Add(this.lblSourceComputer, 0, 0);
            this.tblMainLayout.Controls.Add(this.lblDestinationComputer, 0, 1);
            this.tblMainLayout.Controls.Add(this.lblUserList, 0, 3);
            this.tblMainLayout.Controls.Add(this.btnStartStop, 0, 5);
            this.tblMainLayout.Controls.Add(this.tbleListUsersButtons, 1, 2);
            this.tblMainLayout.Controls.Add(this.pnlLogoBorder, 0, 4);
            this.tblMainLayout.Controls.Add(this.destCompTabl, 1, 1);
            this.tblMainLayout.Controls.Add(this.listUsers, 1, 3);
            this.tblMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tblMainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMainLayout.Name = "tblMainLayout";
            this.tblMainLayout.RowCount = 2;
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblMainLayout.Size = new System.Drawing.Size(579, 268);
            this.tblMainLayout.TabIndex = 100;
            // 
            // sourCompTabl
            // 
            this.sourCompTabl.ColumnCount = 2;
            this.sourCompTabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sourCompTabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.sourCompTabl.Controls.Add(this.tbSourceComputer, 0, 0);
            this.sourCompTabl.Controls.Add(this.btnAFillSrc, 1, 0);
            this.sourCompTabl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourCompTabl.Location = new System.Drawing.Point(148, 0);
            this.sourCompTabl.Margin = new System.Windows.Forms.Padding(0);
            this.sourCompTabl.Name = "sourCompTabl";
            this.sourCompTabl.RowCount = 1;
            this.sourCompTabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sourCompTabl.Size = new System.Drawing.Size(431, 36);
            this.sourCompTabl.TabIndex = 101;
            // 
            // lblSourceComputer
            // 
            this.lblSourceComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSourceComputer.Location = new System.Drawing.Point(3, 0);
            this.lblSourceComputer.Name = "lblSourceComputer";
            this.lblSourceComputer.Size = new System.Drawing.Size(142, 36);
            this.lblSourceComputer.TabIndex = 100;
            this.lblSourceComputer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDestinationComputer
            // 
            this.lblDestinationComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDestinationComputer.Location = new System.Drawing.Point(3, 36);
            this.lblDestinationComputer.Name = "lblDestinationComputer";
            this.lblDestinationComputer.Size = new System.Drawing.Size(142, 36);
            this.lblDestinationComputer.TabIndex = 100;
            this.lblDestinationComputer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserList
            // 
            this.lblUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserList.Location = new System.Drawing.Point(3, 108);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(142, 14);
            this.lblUserList.TabIndex = 100;
            this.lblUserList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbleListUsersButtons
            // 
            this.tbleListUsersButtons.ColumnCount = 3;
            this.tbleListUsersButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbleListUsersButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbleListUsersButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbleListUsersButtons.Controls.Add(this.btnListSource, 0, 0);
            this.tbleListUsersButtons.Controls.Add(this.btnListStore, 1, 0);
            this.tbleListUsersButtons.Controls.Add(this.btnDelete, 2, 0);
            this.tbleListUsersButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbleListUsersButtons.Location = new System.Drawing.Point(149, 72);
            this.tbleListUsersButtons.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.tbleListUsersButtons.Name = "tbleListUsersButtons";
            this.tbleListUsersButtons.RowCount = 1;
            this.tbleListUsersButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbleListUsersButtons.Size = new System.Drawing.Size(430, 36);
            this.tbleListUsersButtons.TabIndex = 100;
            // 
            // pnlLogoBorder
            // 
            this.pnlLogoBorder.Controls.Add(this.imgLoadLogo);
            this.pnlLogoBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogoBorder.Location = new System.Drawing.Point(4, 122);
            this.pnlLogoBorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.pnlLogoBorder.Name = "pnlLogoBorder";
            this.pnlLogoBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlLogoBorder.Size = new System.Drawing.Size(140, 106);
            this.pnlLogoBorder.TabIndex = 100;
            // 
            // imgLoadLogo
            // 
            this.imgLoadLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLoadLogo.Enabled = false;
            this.imgLoadLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLoadLogo.Image")));
            this.imgLoadLogo.Location = new System.Drawing.Point(1, 1);
            this.imgLoadLogo.Margin = new System.Windows.Forms.Padding(0);
            this.imgLoadLogo.Name = "imgLoadLogo";
            this.imgLoadLogo.Size = new System.Drawing.Size(138, 104);
            this.imgLoadLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLoadLogo.TabIndex = 100;
            this.imgLoadLogo.TabStop = false;
            // 
            // destCompTabl
            // 
            this.destCompTabl.ColumnCount = 2;
            this.destCompTabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.destCompTabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.destCompTabl.Controls.Add(this.btnAFillDest, 0, 0);
            this.destCompTabl.Controls.Add(this.tbDestinationComputer, 0, 0);
            this.destCompTabl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destCompTabl.Location = new System.Drawing.Point(148, 36);
            this.destCompTabl.Margin = new System.Windows.Forms.Padding(0);
            this.destCompTabl.Name = "destCompTabl";
            this.destCompTabl.RowCount = 1;
            this.destCompTabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.destCompTabl.Size = new System.Drawing.Size(431, 36);
            this.destCompTabl.TabIndex = 102;
            // 
            // listUsers
            // 
            this.listUsers.AutoArrange = false;
            this.listUsers.BackgroundImageTiled = true;
            this.listUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUsers.FullRowSelect = true;
            this.listUsers.HideSelection = false;
            this.listUsers.Location = new System.Drawing.Point(151, 111);
            this.listUsers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.listUsers.Name = "listUsers";
            this.tblMainLayout.SetRowSpan(this.listUsers, 2);
            this.listUsers.ShowGroups = false;
            this.listUsers.Size = new System.Drawing.Size(425, 117);
            this.listUsers.TabIndex = 8;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            this.listUsers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListUsers_ColumnClick);
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.UpdateFormRestrictions);
            this.listUsers.DoubleClick += new System.EventHandler(this.OpenUserProperties_Event);
            this.listUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LbxUsers_KeyDown);
            this.listUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListUsers_MouseClick);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miFile,
            this.miView,
            this.miHelp});
            // 
            // miFile
            // 
            this.miFile.Index = 0;
            this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miNewInstance,
            this.miSpacer0,
            this.miSettings,
            this.miSpace9,
            this.miSaveLog,
            this.miSpacer3,
            this.miExitButton});
            this.miFile.Text = "";
            this.miFile.Popup += new System.EventHandler(this.Menu_Popup);
            // 
            // miNewInstance
            // 
            this.miNewInstance.Index = 0;
            this.miNewInstance.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.miNewInstance.Text = "";
            this.miNewInstance.Click += new System.EventHandler(this.MiNewInstance_Click);
            // 
            // miSpacer0
            // 
            this.miSpacer0.Index = 1;
            this.miSpacer0.Text = "-";
            // 
            // miSettings
            // 
            this.miSettings.Index = 2;
            this.miSettings.Shortcut = System.Windows.Forms.Shortcut.F12;
            this.miSettings.Text = "";
            this.miSettings.Click += new System.EventHandler(this.MiSettings_Click);
            // 
            // miSpace9
            // 
            this.miSpace9.Index = 3;
            this.miSpace9.Text = "-";
            // 
            // miSaveLog
            // 
            this.miSaveLog.Index = 4;
            this.miSaveLog.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.miSaveLog.Text = "";
            this.miSaveLog.Click += new System.EventHandler(this.MiSaveLog_Click);
            // 
            // miSpacer3
            // 
            this.miSpacer3.Index = 5;
            this.miSpacer3.Text = "-";
            // 
            // miExitButton
            // 
            this.miExitButton.Index = 6;
            this.miExitButton.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.miExitButton.Text = "";
            this.miExitButton.Click += new System.EventHandler(this.MiExitButton_Click);
            // 
            // miView
            // 
            this.miView.Index = 1;
            this.miView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miAddRemoveCol,
            this.miSeperator65,
            this.miViewLarge,
            this.miViewSmall,
            this.miViewList,
            this.miViewDetail,
            this.miViewTile});
            this.miView.Text = "";
            this.miView.Popup += new System.EventHandler(this.MiView_Popup);
            // 
            // miAddRemoveCol
            // 
            this.miAddRemoveCol.Enabled = false;
            this.miAddRemoveCol.Index = 0;
            this.miAddRemoveCol.Text = "";
            this.miAddRemoveCol.Click += new System.EventHandler(this.MiAddRemoveCol_Click);
            // 
            // miSeperator65
            // 
            this.miSeperator65.Index = 1;
            this.miSeperator65.Text = "-";
            // 
            // miViewLarge
            // 
            this.miViewLarge.Index = 2;
            this.miViewLarge.RadioCheck = true;
            this.miViewLarge.Text = "";
            this.miViewLarge.Click += new System.EventHandler(this.MiViewMode_Click);
            // 
            // miViewSmall
            // 
            this.miViewSmall.Index = 3;
            this.miViewSmall.RadioCheck = true;
            this.miViewSmall.Text = "";
            this.miViewSmall.Click += new System.EventHandler(this.MiViewMode_Click);
            // 
            // miViewList
            // 
            this.miViewList.Index = 4;
            this.miViewList.RadioCheck = true;
            this.miViewList.Text = "";
            this.miViewList.Click += new System.EventHandler(this.MiViewMode_Click);
            // 
            // miViewDetail
            // 
            this.miViewDetail.Index = 5;
            this.miViewDetail.RadioCheck = true;
            this.miViewDetail.Text = "";
            this.miViewDetail.Click += new System.EventHandler(this.MiViewMode_Click);
            // 
            // miViewTile
            // 
            this.miViewTile.Index = 6;
            this.miViewTile.RadioCheck = true;
            this.miViewTile.Text = "";
            this.miViewTile.Click += new System.EventHandler(this.MiViewMode_Click);
            // 
            // miHelp
            // 
            this.miHelp.Index = 2;
            this.miHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miDocumentation,
            this.miIssues,
            this.miSpacer1,
            this.miUpdateCheck,
            this.miSeperator55,
            this.miAboutSG});
            this.miHelp.Text = "";
            this.miHelp.Popup += new System.EventHandler(this.Menu_Popup);
            // 
            // miDocumentation
            // 
            this.miDocumentation.Index = 0;
            this.miDocumentation.Text = "";
            this.miDocumentation.Click += new System.EventHandler(this.MiDocumentation_Click);
            // 
            // miIssues
            // 
            this.miIssues.Index = 1;
            this.miIssues.Text = "";
            this.miIssues.Click += new System.EventHandler(this.MiIssues_Click);
            // 
            // miSpacer1
            // 
            this.miSpacer1.Index = 2;
            this.miSpacer1.Text = "-";
            // 
            // miUpdateCheck
            // 
            this.miUpdateCheck.Index = 3;
            this.miUpdateCheck.Text = "";
            this.miUpdateCheck.Click += new System.EventHandler(this.MiUpdateCheck_Click);
            // 
            // miSeperator55
            // 
            this.miSeperator55.Index = 4;
            this.miSeperator55.Text = "-";
            // 
            // miAboutSG
            // 
            this.miAboutSG.Index = 5;
            this.miAboutSG.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.miAboutSG.Text = "";
            this.miAboutSG.Click += new System.EventHandler(this.MiAboutSG_Click);
            // 
            // dialogSaveLog
            // 
            this.dialogSaveLog.Filter = "Text File|*.txt|Log File|*.log";
            this.dialogSaveLog.FilterIndex = 2;
            // 
            // miConUser
            // 
            this.miConUser.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miConStart,
            this.miConRename,
            this.miConDelete,
            this.miConSeperator,
            this.miConProperties});
            this.miConUser.Popup += new System.EventHandler(this.Menu_Popup);
            // 
            // miConStart
            // 
            this.miConStart.Index = 0;
            this.miConStart.Text = "";
            this.miConStart.Click += new System.EventHandler(this.BtStartStop_Click);
            // 
            // miConRename
            // 
            this.miConRename.Index = 1;
            this.miConRename.Text = "";
            this.miConRename.Click += new System.EventHandler(this.MiConRename_Click);
            // 
            // miConDelete
            // 
            this.miConDelete.Index = 2;
            this.miConDelete.Text = "";
            this.miConDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // miConSeperator
            // 
            this.miConSeperator.Index = 3;
            this.miConSeperator.Text = "-";
            // 
            // miConProperties
            // 
            this.miConProperties.Index = 4;
            this.miConProperties.Text = "";
            this.miConProperties.Click += new System.EventHandler(this.OpenUserProperties_Event);
            // 
            // tbSourceComputer
            // 
            this.tbSourceComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tbSourceComputer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSourceComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSourceComputer.Icon = "";
            this.tbSourceComputer.Location = new System.Drawing.Point(3, 4);
            this.tbSourceComputer.Margin = new System.Windows.Forms.Padding(3, 4, 6, 4);
            this.tbSourceComputer.Multiline = true;
            this.tbSourceComputer.Name = "tbSourceComputer";
            this.tbSourceComputer.Size = new System.Drawing.Size(390, 28);
            this.tbSourceComputer.TabIndex = 1;
            this.tbSourceComputer.TextChanged += new System.EventHandler(this.TbSourceComputer_TextChanged);
            this.tbSourceComputer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSourceDestComputer_KeyDown);
            // 
            // btnAFillSrc
            // 
            this.btnAFillSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAFillSrc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAFillSrc.Icon = "";
            this.btnAFillSrc.Location = new System.Drawing.Point(399, 4);
            this.btnAFillSrc.Margin = new System.Windows.Forms.Padding(0, 4, 2, 4);
            this.btnAFillSrc.Name = "btnAFillSrc";
            this.btnAFillSrc.Size = new System.Drawing.Size(30, 28);
            this.btnAFillSrc.TabIndex = 2;
            this.btnAFillSrc.Text = null;
            this.btnAFillSrc.UseVisualStyleBackColor = true;
            this.btnAFillSrc.Click += new System.EventHandler(this.BtnAFillSrc_Click);
            // 
            // btnStartStop
            // 
            this.tblMainLayout.SetColumnSpan(this.btnStartStop, 2);
            this.btnStartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartStop.Enabled = false;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStartStop.Icon = "";
            this.btnStartStop.Location = new System.Drawing.Point(3, 235);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(574, 30);
            this.btnStartStop.TabIndex = 9;
            this.btnStartStop.Text = null;
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.BtStartStop_Click);
            // 
            // btnListSource
            // 
            this.btnListSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListSource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListSource.Icon = "";
            this.btnListSource.Location = new System.Drawing.Point(2, 3);
            this.btnListSource.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.btnListSource.Name = "btnListSource";
            this.btnListSource.Size = new System.Drawing.Size(138, 30);
            this.btnListSource.TabIndex = 5;
            this.btnListSource.Text = null;
            this.btnListSource.Click += new System.EventHandler(this.BtnListSource_Click);
            // 
            // btnListStore
            // 
            this.btnListStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListStore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListStore.Icon = "";
            this.btnListStore.Location = new System.Drawing.Point(146, 3);
            this.btnListStore.Name = "btnListStore";
            this.btnListStore.Size = new System.Drawing.Size(137, 30);
            this.btnListStore.TabIndex = 6;
            this.btnListStore.Text = null;
            this.btnListStore.Click += new System.EventHandler(this.BtnListStore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Icon = "";
            this.btnDelete.Location = new System.Drawing.Point(289, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = null;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAFillDest
            // 
            this.btnAFillDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAFillDest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAFillDest.Icon = "";
            this.btnAFillDest.Location = new System.Drawing.Point(399, 4);
            this.btnAFillDest.Margin = new System.Windows.Forms.Padding(0, 4, 2, 4);
            this.btnAFillDest.Name = "btnAFillDest";
            this.btnAFillDest.Size = new System.Drawing.Size(30, 28);
            this.btnAFillDest.TabIndex = 4;
            this.btnAFillDest.Text = null;
            this.btnAFillDest.UseVisualStyleBackColor = true;
            this.btnAFillDest.Click += new System.EventHandler(this.BtnAFillDest_Click);
            // 
            // tbDestinationComputer
            // 
            this.tbDestinationComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tbDestinationComputer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestinationComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDestinationComputer.Icon = "";
            this.tbDestinationComputer.Location = new System.Drawing.Point(3, 4);
            this.tbDestinationComputer.Margin = new System.Windows.Forms.Padding(3, 4, 6, 4);
            this.tbDestinationComputer.Multiline = true;
            this.tbDestinationComputer.Name = "tbDestinationComputer";
            this.tbDestinationComputer.Size = new System.Drawing.Size(390, 28);
            this.tbDestinationComputer.TabIndex = 3;
            this.tbDestinationComputer.TextChanged += new System.EventHandler(this.TbDestinationComputer_TextChanged);
            this.tbDestinationComputer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSourceDestComputer_KeyDown);
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.ForeColor = System.Drawing.Color.Black;
            this.pbMain.Location = new System.Drawing.Point(3, 236);
            this.pbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbMain.MarqueeAnimationSpeed = 30;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(385, 28);
            this.pbMain.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbMain.TabIndex = 100;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(984, 299);
            this.Controls.Add(this.spltContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.logTable.ResumeLayout(false);
            this.spltContainer.Panel1.ResumeLayout(false);
            this.spltContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltContainer)).EndInit();
            this.spltContainer.ResumeLayout(false);
            this.tblMainLayout.ResumeLayout(false);
            this.sourCompTabl.ResumeLayout(false);
            this.sourCompTabl.PerformLayout();
            this.tbleListUsersButtons.ResumeLayout(false);
            this.pnlLogoBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadLogo)).EndInit();
            this.destCompTabl.ResumeLayout(false);
            this.destCompTabl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogBox;
        private SuperGrate.Controls.Components.SGProgressBar pbMain;
        private System.Windows.Forms.TableLayoutPanel logTable;
        private System.Windows.Forms.SplitContainer spltContainer;
        private System.Windows.Forms.TableLayoutPanel tblMainLayout;
        private System.Windows.Forms.Label lblSourceComputer;
        private System.Windows.Forms.Label lblDestinationComputer;
        private System.Windows.Forms.Label lblUserList;
        private SuperGrate.Controls.Components.SGButton btnStartStop;
        private SGButton btnListSource;
        private SuperGrate.Controls.Components.SGButton btnListStore;
        private SuperGrate.Controls.Components.SGButton btnDelete;
        private System.Windows.Forms.Panel pnlLogoBorder;
        private System.Windows.Forms.TableLayoutPanel tbleListUsersButtons;
        private System.Windows.Forms.TableLayoutPanel sourCompTabl;
        private SuperGrate.Controls.Components.SGTextBox tbSourceComputer;
        private SuperGrate.Controls.Components.SGButton btnAFillSrc;
        private System.Windows.Forms.TableLayoutPanel destCompTabl;
        private SuperGrate.Controls.Components.SGButton btnAFillDest;
        private SuperGrate.Controls.Components.SGTextBox tbDestinationComputer;
        private System.Windows.Forms.PictureBox imgLoadLogo;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem miFile;
        private System.Windows.Forms.MenuItem miExitButton;
        private System.Windows.Forms.MenuItem miSaveLog;
        private System.Windows.Forms.MenuItem miSpacer0;
        private System.Windows.Forms.MenuItem miHelp;
        private System.Windows.Forms.MenuItem miDocumentation;
        private System.Windows.Forms.MenuItem miIssues;
        private System.Windows.Forms.MenuItem miAboutSG;
        private System.Windows.Forms.SaveFileDialog dialogSaveLog;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.MenuItem miSpacer1;
        private System.Windows.Forms.MenuItem miNewInstance;
        private System.Windows.Forms.MenuItem miSpacer3;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.MenuItem miView;
        private System.Windows.Forms.MenuItem miAddRemoveCol;
        private System.Windows.Forms.MenuItem miSettings;
        private System.Windows.Forms.MenuItem miSpace9;
        private System.Windows.Forms.MenuItem miSeperator65;
        private System.Windows.Forms.MenuItem miViewLarge;
        private System.Windows.Forms.MenuItem miViewSmall;
        private System.Windows.Forms.MenuItem miViewList;
        private System.Windows.Forms.MenuItem miViewDetail;
        private System.Windows.Forms.MenuItem miViewTile;
        private System.Windows.Forms.ContextMenu miConUser;
        private System.Windows.Forms.MenuItem miConStart;
        private System.Windows.Forms.MenuItem miConDelete;
        private System.Windows.Forms.MenuItem miConSeperator;
        private System.Windows.Forms.MenuItem miConProperties;
        private System.Windows.Forms.MenuItem miSeperator55;
        private System.Windows.Forms.MenuItem miUpdateCheck;
        private System.Windows.Forms.MenuItem miConRename;
    }
}

