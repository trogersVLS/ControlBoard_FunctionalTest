﻿namespace ControlBoardTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.FailCountIndicator = new System.Windows.Forms.Button();
            this.PassCountIndicator = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusIndicator = new System.Windows.Forms.Button();
            this.Output_Window = new System.Windows.Forms.RichTextBox();
            this.Panel_Actions = new System.Windows.Forms.Panel();
            this.Button_Telnet = new System.Windows.Forms.Button();
            this.Button_PowerUp = new System.Windows.Forms.Button();
            this.Dropdown_Test_List = new System.Windows.Forms.ComboBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Logo_VLS = new System.Windows.Forms.PictureBox();
            this.Panel_Settings = new System.Windows.Forms.FlowLayoutPanel();
            this.Field_SerialNumber = new System.Windows.Forms.TextBox();
            this.Check_FCT = new System.Windows.Forms.CheckBox();
            this.Check_SingleTest = new System.Windows.Forms.CheckBox();
            this.MenuBar = new System.Windows.Forms.MainMenu(this.components);
            this.Menu_File = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.File_ChangePassword = new System.Windows.Forms.MenuItem();
            this.File_ChangeUser = new System.Windows.Forms.MenuItem();
            this.File_AddUser = new System.Windows.Forms.MenuItem();
            this.File_Exit = new System.Windows.Forms.MenuItem();
            this.Menu_Settings = new System.Windows.Forms.MenuItem();
            this.Settings_LoggingLabel = new System.Windows.Forms.MenuItem();
            this.Menu_About = new System.Windows.Forms.MenuItem();
            this.About_VersionLabel = new System.Windows.Forms.MenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.Status_RevLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_RevTag = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_LocLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_LocTag = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_ToolLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_ToolTag = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_UserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_UserTag = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.Panel_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_VLS)).BeginInit();
            this.Panel_Settings.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.StatusPanel);
            this.MainPanel.Controls.Add(this.Output_Window);
            this.MainPanel.Controls.Add(this.Panel_Actions);
            this.MainPanel.Controls.Add(this.ProgressBar);
            this.MainPanel.Controls.Add(this.Logo_VLS);
            this.MainPanel.Controls.Add(this.Panel_Settings);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1291, 1362);
            this.MainPanel.TabIndex = 31;
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.StatusPanel.Controls.Add(this.FailCountIndicator);
            this.StatusPanel.Controls.Add(this.PassCountIndicator);
            this.StatusPanel.Controls.Add(this.StatusLabel);
            this.StatusPanel.Controls.Add(this.StatusIndicator);
            this.StatusPanel.Location = new System.Drawing.Point(32, 622);
            this.StatusPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(1227, 86);
            this.StatusPanel.TabIndex = 31;
            // 
            // FailCountIndicator
            // 
            this.FailCountIndicator.BackColor = System.Drawing.Color.Red;
            this.FailCountIndicator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailCountIndicator.Location = new System.Drawing.Point(1072, 0);
            this.FailCountIndicator.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.FailCountIndicator.Name = "FailCountIndicator";
            this.FailCountIndicator.Size = new System.Drawing.Size(147, 86);
            this.FailCountIndicator.TabIndex = 3;
            this.FailCountIndicator.Text = "0";
            this.FailCountIndicator.UseVisualStyleBackColor = false;
            this.FailCountIndicator.Click += new System.EventHandler(this.FailCountIndicator_Click);
            // 
            // PassCountIndicator
            // 
            this.PassCountIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PassCountIndicator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassCountIndicator.Location = new System.Drawing.Point(915, 0);
            this.PassCountIndicator.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PassCountIndicator.Name = "PassCountIndicator";
            this.PassCountIndicator.Size = new System.Drawing.Size(147, 86);
            this.PassCountIndicator.TabIndex = 2;
            this.PassCountIndicator.Text = "0";
            this.PassCountIndicator.UseVisualStyleBackColor = false;
            this.PassCountIndicator.Click += new System.EventHandler(this.PassCountIndicator_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(104, 19);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(108, 47);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "IDLE";
            // 
            // StatusIndicator
            // 
            this.StatusIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusIndicator.BackColor = System.Drawing.Color.Gray;
            this.StatusIndicator.Enabled = false;
            this.StatusIndicator.Location = new System.Drawing.Point(8, 7);
            this.StatusIndicator.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StatusIndicator.Name = "StatusIndicator";
            this.StatusIndicator.Size = new System.Drawing.Size(80, 72);
            this.StatusIndicator.TabIndex = 0;
            this.StatusIndicator.UseVisualStyleBackColor = false;
            // 
            // Output_Window
            // 
            this.Output_Window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_Window.Location = new System.Drawing.Point(32, 801);
            this.Output_Window.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Output_Window.Name = "Output_Window";
            this.Output_Window.ReadOnly = true;
            this.Output_Window.Size = new System.Drawing.Size(1220, 548);
            this.Output_Window.TabIndex = 9;
            this.Output_Window.Text = "";
            this.Output_Window.TextChanged += new System.EventHandler(this.Output_Window_TextChanged);
            // 
            // Panel_Actions
            // 
            this.Panel_Actions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Actions.Controls.Add(this.Button_Telnet);
            this.Panel_Actions.Controls.Add(this.Button_PowerUp);
            this.Panel_Actions.Controls.Add(this.Dropdown_Test_List);
            this.Panel_Actions.Controls.Add(this.Button_Run);
            this.Panel_Actions.Location = new System.Drawing.Point(464, 300);
            this.Panel_Actions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Actions.Name = "Panel_Actions";
            this.Panel_Actions.Size = new System.Drawing.Size(795, 312);
            this.Panel_Actions.TabIndex = 30;
            // 
            // Button_Telnet
            // 
            this.Button_Telnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_Telnet.Enabled = false;
            this.Button_Telnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Telnet.Location = new System.Drawing.Point(8, 210);
            this.Button_Telnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Telnet.Name = "Button_Telnet";
            this.Button_Telnet.Size = new System.Drawing.Size(283, 88);
            this.Button_Telnet.TabIndex = 32;
            this.Button_Telnet.Text = "Telnet";
            this.Button_Telnet.UseVisualStyleBackColor = false;
            this.Button_Telnet.Click += new System.EventHandler(this.Button_Telnet_Click);
            // 
            // Button_PowerUp
            // 
            this.Button_PowerUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_PowerUp.Enabled = false;
            this.Button_PowerUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_PowerUp.Location = new System.Drawing.Point(8, 98);
            this.Button_PowerUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_PowerUp.Name = "Button_PowerUp";
            this.Button_PowerUp.Size = new System.Drawing.Size(283, 88);
            this.Button_PowerUp.TabIndex = 31;
            this.Button_PowerUp.Text = "Power";
            this.Button_PowerUp.UseVisualStyleBackColor = false;
            this.Button_PowerUp.Click += new System.EventHandler(this.Button_PowerUp_Click);
            // 
            // Dropdown_Test_List
            // 
            this.Dropdown_Test_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dropdown_Test_List.Enabled = false;
            this.Dropdown_Test_List.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Test_List.FormattingEnabled = true;
            this.Dropdown_Test_List.Location = new System.Drawing.Point(8, 7);
            this.Dropdown_Test_List.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Dropdown_Test_List.Name = "Dropdown_Test_List";
            this.Dropdown_Test_List.Size = new System.Drawing.Size(772, 44);
            this.Dropdown_Test_List.TabIndex = 15;
            this.Dropdown_Test_List.SelectedIndexChanged += new System.EventHandler(this.Dropdown_Test_List_SelectedIndexChanged);
            // 
            // Button_Run
            // 
            this.Button_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(214)))));
            this.Button_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Run.Location = new System.Drawing.Point(483, 98);
            this.Button_Run.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(304, 200);
            this.Button_Run.TabIndex = 1;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = false;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(32, 723);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1227, 64);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 12;
            // 
            // Logo_VLS
            // 
            this.Logo_VLS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo_VLS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo_VLS.Image = ((System.Drawing.Image)(resources.GetObject("Logo_VLS.Image")));
            this.Logo_VLS.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo_VLS.InitialImage")));
            this.Logo_VLS.Location = new System.Drawing.Point(32, 21);
            this.Logo_VLS.Margin = new System.Windows.Forms.Padding(0);
            this.Logo_VLS.Name = "Logo_VLS";
            this.Logo_VLS.Size = new System.Drawing.Size(1227, 224);
            this.Logo_VLS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_VLS.TabIndex = 26;
            this.Logo_VLS.TabStop = false;
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.Controls.Add(this.Field_SerialNumber);
            this.Panel_Settings.Controls.Add(this.Check_FCT);
            this.Panel_Settings.Controls.Add(this.Check_SingleTest);
            this.Panel_Settings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Panel_Settings.Location = new System.Drawing.Point(32, 300);
            this.Panel_Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(411, 312);
            this.Panel_Settings.TabIndex = 29;
            // 
            // Field_SerialNumber
            // 
            this.Field_SerialNumber.BackColor = System.Drawing.SystemColors.Window;
            this.Field_SerialNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Field_SerialNumber.Location = new System.Drawing.Point(8, 7);
            this.Field_SerialNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Field_SerialNumber.Name = "Field_SerialNumber";
            this.Field_SerialNumber.Size = new System.Drawing.Size(369, 38);
            this.Field_SerialNumber.TabIndex = 0;
            this.Field_SerialNumber.TextChanged += new System.EventHandler(this.Field_SerialNumber_TextChanged);
            this.Field_SerialNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Field_SerialNumber_KeyUp);
            // 
            // Check_FCT
            // 
            this.Check_FCT.AutoSize = true;
            this.Check_FCT.Location = new System.Drawing.Point(8, 59);
            this.Check_FCT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Check_FCT.Name = "Check_FCT";
            this.Check_FCT.Size = new System.Drawing.Size(248, 36);
            this.Check_FCT.TabIndex = 7;
            this.Check_FCT.Text = "Functional Test";
            this.Check_FCT.UseVisualStyleBackColor = true;
            this.Check_FCT.CheckedChanged += new System.EventHandler(this.Check_Functional_CheckedChanged);
            // 
            // Check_SingleTest
            // 
            this.Check_SingleTest.AutoSize = true;
            this.Check_SingleTest.Location = new System.Drawing.Point(8, 109);
            this.Check_SingleTest.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Check_SingleTest.Name = "Check_SingleTest";
            this.Check_SingleTest.Size = new System.Drawing.Size(196, 36);
            this.Check_SingleTest.TabIndex = 13;
            this.Check_SingleTest.Text = "Single Test";
            this.Check_SingleTest.UseVisualStyleBackColor = true;
            this.Check_SingleTest.CheckedChanged += new System.EventHandler(this.Check_SingleTest_CheckedChanged);
            // 
            // MenuBar
            // 
            this.MenuBar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_File,
            this.Menu_Settings,
            this.Menu_About});
            // 
            // Menu_File
            // 
            this.Menu_File.Index = 0;
            this.Menu_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.File_ChangePassword,
            this.File_ChangeUser,
            this.File_AddUser,
            this.File_Exit});
            this.Menu_File.Text = "File";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Save Output";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Clear Output";
            // 
            // File_ChangePassword
            // 
            this.File_ChangePassword.Index = 2;
            this.File_ChangePassword.Text = "Change Password";
            this.File_ChangePassword.Click += new System.EventHandler(this.File_ChangePassword_Click);
            // 
            // File_ChangeUser
            // 
            this.File_ChangeUser.Index = 3;
            this.File_ChangeUser.Text = "Change User";
            this.File_ChangeUser.Click += new System.EventHandler(this.File_ChangeUser_Click);
            // 
            // File_AddUser
            // 
            this.File_AddUser.Index = 4;
            this.File_AddUser.Text = "Add User";
            this.File_AddUser.Click += new System.EventHandler(this.File_AddUser_Click);
            // 
            // File_Exit
            // 
            this.File_Exit.Index = 5;
            this.File_Exit.Text = "Exit";
            // 
            // Menu_Settings
            // 
            this.Menu_Settings.Index = 1;
            this.Menu_Settings.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Settings_LoggingLabel});
            this.Menu_Settings.Text = "Settings";
            // 
            // Settings_LoggingLabel
            // 
            this.Settings_LoggingLabel.Checked = true;
            this.Settings_LoggingLabel.Index = 0;
            this.Settings_LoggingLabel.RadioCheck = true;
            this.Settings_LoggingLabel.Text = "Log to database";
            this.Settings_LoggingLabel.Click += new System.EventHandler(this.Logging_Click);
            // 
            // Menu_About
            // 
            this.Menu_About.Index = 2;
            this.Menu_About.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.About_VersionLabel});
            this.Menu_About.Text = "About";
            // 
            // About_VersionLabel
            // 
            this.About_VersionLabel.Index = 0;
            this.About_VersionLabel.Text = "Version";
            this.About_VersionLabel.Click += new System.EventHandler(this.About_Version_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_RevLabel,
            this.Status_RevTag,
            this.Status_LocLabel,
            this.Status_LocTag,
            this.Status_ToolLabel,
            this.Status_ToolTag,
            this.Status_UserLabel,
            this.Status_UserTag});
            this.StatusBar.Location = new System.Drawing.Point(0, 1362);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.StatusBar.Size = new System.Drawing.Size(1291, 54);
            this.StatusBar.TabIndex = 27;
            this.StatusBar.Text = "StatusStrip";
            // 
            // Status_RevLabel
            // 
            this.Status_RevLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Status_RevLabel.Name = "Status_RevLabel";
            this.Status_RevLabel.Size = new System.Drawing.Size(144, 41);
            this.Status_RevLabel.Text = "Revision:";
            // 
            // Status_RevTag
            // 
            this.Status_RevTag.Name = "Status_RevTag";
            this.Status_RevTag.Size = new System.Drawing.Size(162, 41);
            this.Status_RevTag.Text = "<revision>";
            // 
            // Status_LocLabel
            // 
            this.Status_LocLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Status_LocLabel.Name = "Status_LocLabel";
            this.Status_LocLabel.Size = new System.Drawing.Size(146, 41);
            this.Status_LocLabel.Text = "Location:";
            // 
            // Status_LocTag
            // 
            this.Status_LocTag.Name = "Status_LocTag";
            this.Status_LocTag.Size = new System.Drawing.Size(166, 41);
            this.Status_LocTag.Text = "<location>";
            // 
            // Status_ToolLabel
            // 
            this.Status_ToolLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Status_ToolLabel.Name = "Status_ToolLabel";
            this.Status_ToolLabel.Size = new System.Drawing.Size(126, 41);
            this.Status_ToolLabel.Text = "Tool ID:";
            // 
            // Status_ToolTag
            // 
            this.Status_ToolTag.Name = "Status_ToolTag";
            this.Status_ToolTag.Size = new System.Drawing.Size(113, 41);
            this.Status_ToolTag.Text = "<tool>";
            // 
            // Status_UserLabel
            // 
            this.Status_UserLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Status_UserLabel.Name = "Status_UserLabel";
            this.Status_UserLabel.Size = new System.Drawing.Size(90, 41);
            this.Status_UserLabel.Text = "User:";
            // 
            // Status_UserTag
            // 
            this.Status_UserTag.Name = "Status_UserTag";
            this.Status_UserTag.Size = new System.Drawing.Size(116, 41);
            this.Status_UserTag.Text = "<user>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1291, 1416);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.StatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Menu = this.MenuBar;
            this.MinimumSize = new System.Drawing.Size(1280, 970);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Board Functional Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainPanel.ResumeLayout(false);
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.Panel_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_VLS)).EndInit();
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Settings.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.TextBox Field_SerialNumber;
        private System.Windows.Forms.RichTextBox Output_Window;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ComboBox Dropdown_Test_List;
        private System.Windows.Forms.PictureBox Logo_VLS;
        private System.Windows.Forms.MainMenu MenuBar;
        private System.Windows.Forms.MenuItem Menu_Settings;
        private System.Windows.Forms.MenuItem Menu_About;
        private System.Windows.Forms.MenuItem File_Exit;
        private System.Windows.Forms.MenuItem About_VersionLabel;
        private System.Windows.Forms.MenuItem Menu_File;
        private System.Windows.Forms.StatusStrip StatusBar;
        
        private System.Windows.Forms.MenuItem Settings_LoggingLabel;
        private System.Windows.Forms.CheckBox Check_SingleTest;
        private System.Windows.Forms.CheckBox Check_FCT;
        private System.Windows.Forms.FlowLayoutPanel Panel_Settings;
        private System.Windows.Forms.MenuItem File_ChangeUser;

        private System.Windows.Forms.ToolStripStatusLabel Status_LocLabel;
        private System.Windows.Forms.ToolStripStatusLabel Status_LocTag;
        private System.Windows.Forms.ToolStripStatusLabel Status_RevLabel;
        private System.Windows.Forms.ToolStripStatusLabel Status_RevTag;
        private System.Windows.Forms.ToolStripStatusLabel Status_UserLabel;
        private System.Windows.Forms.ToolStripStatusLabel Status_UserTag;
        private System.Windows.Forms.ToolStripStatusLabel Status_ToolLabel;
        private System.Windows.Forms.ToolStripStatusLabel Status_ToolTag;
        private System.Windows.Forms.Panel Panel_Actions;
        private System.Windows.Forms.Button Button_Telnet;
        private System.Windows.Forms.Button Button_PowerUp;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.MenuItem File_AddUser;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem File_ChangePassword;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Button StatusIndicator;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button FailCountIndicator;
        private System.Windows.Forms.Button PassCountIndicator;
    }
}

