﻿namespace tfm
{
    partial class TFMMainForm
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
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.TFMMainMenu = new System.Windows.Forms.MenuStrip();
            this.PlanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPlanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SavePlanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePlanAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.A2AManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AircraftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WebsiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportIssueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TFMTabControl = new System.Windows.Forms.TabControl();
            this.AvionicsTabPage = new System.Windows.Forms.TabPage();
            this.AvionicsLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.AltitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.APAltitudeCheckBox = new System.Windows.Forms.CheckBox();
            this.AltitudeTextBox = new System.Windows.Forms.TextBox();
            this.AltitudeLabel = new System.Windows.Forms.Label();
            this.HeadingGroupBox = new System.Windows.Forms.GroupBox();
            this.APHeadingCheckBox = new System.Windows.Forms.CheckBox();
            this.HeadingTextBox = new System.Windows.Forms.TextBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.FlightPlanTabPage = new System.Windows.Forms.TabPage();
            this.ProceduresTabPage = new System.Windows.Forms.TabPage();
            this.FindTabPage = new System.Windows.Forms.TabPage();
            this.AirSpeedGroupBox = new System.Windows.Forms.GroupBox();
            this.AirSpeedLabel = new System.Windows.Forms.Label();
            this.AirSpeedTextBox = new System.Windows.Forms.TextBox();
            this.AirSpeedCheckBox = new System.Windows.Forms.CheckBox();
            this.MachGroupBox = new System.Windows.Forms.GroupBox();
            this.TFMMainMenu.SuspendLayout();
            this.TFMTabControl.SuspendLayout();
            this.AvionicsTabPage.SuspendLayout();
            this.AvionicsLayoutTable.SuspendLayout();
            this.AltitudeGroupBox.SuspendLayout();
            this.HeadingGroupBox.SuspendLayout();
            this.AirSpeedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 1000;
            this.timerConnection.Tick += new System.EventHandler(this.timerConnection_Tick);
            // 
            // TFMMainMenu
            // 
            this.TFMMainMenu.AccessibleDescription = "Talking flight moniter main menu";
            this.TFMMainMenu.AccessibleName = "TFM Main menu";
            this.TFMMainMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFMMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlanMenu,
            this.ToolsMenu,
            this.HelpMenu});
            this.TFMMainMenu.Location = new System.Drawing.Point(0, 0);
            this.TFMMainMenu.Name = "TFMMainMenu";
            this.TFMMainMenu.Size = new System.Drawing.Size(717, 33);
            this.TFMMainMenu.TabIndex = 0;
            this.TFMMainMenu.Text = "Main menu";
            // 
            // PlanMenu
            // 
            this.PlanMenu.AccessibleDescription = "";
            this.PlanMenu.AccessibleName = "Plan";
            this.PlanMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPlanMenuItem,
            this.toolStripSeparator1,
            this.SavePlanMenuItem,
            this.SavePlanAsMenuItem,
            this.toolStripSeparator2,
            this.QuitMenuItem});
            this.PlanMenu.Name = "PlanMenu";
            this.PlanMenu.ShortcutKeyDisplayString = "ALT+P";
            this.PlanMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.PlanMenu.Size = new System.Drawing.Size(61, 29);
            this.PlanMenu.Text = "&Plan";
            this.PlanMenu.ToolTipText = "Load and save flight plans.";
            // 
            // OpenPlanMenuItem
            // 
            this.OpenPlanMenuItem.AccessibleDescription = "";
            this.OpenPlanMenuItem.AccessibleName = "Open...";
            this.OpenPlanMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPlanMenuItem.Name = "OpenPlanMenuItem";
            this.OpenPlanMenuItem.ShortcutKeyDisplayString = "CONTROL+O";
            this.OpenPlanMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenPlanMenuItem.Size = new System.Drawing.Size(296, 26);
            this.OpenPlanMenuItem.Text = "&Open...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(293, 6);
            // 
            // SavePlanMenuItem
            // 
            this.SavePlanMenuItem.AccessibleDescription = "";
            this.SavePlanMenuItem.AccessibleName = "Save...";
            this.SavePlanMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlanMenuItem.Name = "SavePlanMenuItem";
            this.SavePlanMenuItem.ShortcutKeyDisplayString = "CONTROL+S";
            this.SavePlanMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SavePlanMenuItem.Size = new System.Drawing.Size(296, 26);
            this.SavePlanMenuItem.Text = "&Save...";
            // 
            // SavePlanAsMenuItem
            // 
            this.SavePlanAsMenuItem.AccessibleDescription = "";
            this.SavePlanAsMenuItem.AccessibleName = "Save as...";
            this.SavePlanAsMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlanAsMenuItem.Name = "SavePlanAsMenuItem";
            this.SavePlanAsMenuItem.ShortcutKeyDisplayString = "CONTROL+SHIFT+S";
            this.SavePlanAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SavePlanAsMenuItem.Size = new System.Drawing.Size(296, 26);
            this.SavePlanAsMenuItem.Text = "&Save as...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // QuitMenuItem
            // 
            this.QuitMenuItem.AccessibleDescription = "";
            this.QuitMenuItem.AccessibleName = "Quit";
            this.QuitMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitMenuItem.Name = "QuitMenuItem";
            this.QuitMenuItem.ShortcutKeyDisplayString = "ALT+F4";
            this.QuitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.QuitMenuItem.Size = new System.Drawing.Size(296, 26);
            this.QuitMenuItem.Text = "&Quit";
            this.QuitMenuItem.Click += new System.EventHandler(this.QuitMenuItem_Click);
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.AccessibleDescription = "";
            this.ToolsMenu.AccessibleName = "Tools";
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.A2AManagerMenuItem,
            this.AircraftMenuItem,
            this.SettingsMenuItem});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.ShortcutKeyDisplayString = "ALT+T";
            this.ToolsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.ToolsMenu.Size = new System.Drawing.Size(67, 29);
            this.ToolsMenu.Text = "&Tools";
            // 
            // A2AManagerMenuItem
            // 
            this.A2AManagerMenuItem.AccessibleDescription = "";
            this.A2AManagerMenuItem.AccessibleName = "A2A aircraft manager";
            this.A2AManagerMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2AManagerMenuItem.Name = "A2AManagerMenuItem";
            this.A2AManagerMenuItem.ShortcutKeyDisplayString = "CONTROL+M";
            this.A2AManagerMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.A2AManagerMenuItem.Size = new System.Drawing.Size(337, 26);
            this.A2AManagerMenuItem.Text = "A2A aircraft &manager";
            // 
            // AircraftMenuItem
            // 
            this.AircraftMenuItem.AccessibleDescription = "";
            this.AircraftMenuItem.AccessibleName = "Aircraft profiles...";
            this.AircraftMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AircraftMenuItem.Name = "AircraftMenuItem";
            this.AircraftMenuItem.ShortcutKeyDisplayString = "CONTROL+I";
            this.AircraftMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.AircraftMenuItem.Size = new System.Drawing.Size(337, 26);
            this.AircraftMenuItem.Text = "A&ircraft...";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.AccessibleDescription = "";
            this.SettingsMenuItem.AccessibleName = "Settings...";
            this.SettingsMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.ShortcutKeyDisplayString = "CONTROL+,";
            this.SettingsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
            this.SettingsMenuItem.Size = new System.Drawing.Size(337, 26);
            this.SettingsMenuItem.Text = "&Settings...";
            // 
            // HelpMenu
            // 
            this.HelpMenu.AccessibleDescription = "";
            this.HelpMenu.AccessibleName = "Help";
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebsiteMenuItem,
            this.ReportIssueMenuItem,
            this.AboutMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.ShortcutKeyDisplayString = "ALT+H";
            this.HelpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.HelpMenu.Size = new System.Drawing.Size(63, 29);
            this.HelpMenu.Text = "Help";
            // 
            // WebsiteMenuItem
            // 
            this.WebsiteMenuItem.AccessibleDescription = "";
            this.WebsiteMenuItem.AccessibleName = "Visit website";
            this.WebsiteMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebsiteMenuItem.Name = "WebsiteMenuItem";
            this.WebsiteMenuItem.ShortcutKeyDisplayString = "CONTROL+W";
            this.WebsiteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.WebsiteMenuItem.Size = new System.Drawing.Size(337, 26);
            this.WebsiteMenuItem.Text = "Visit &website";
            // 
            // ReportIssueMenuItem
            // 
            this.ReportIssueMenuItem.AccessibleDescription = "";
            this.ReportIssueMenuItem.AccessibleName = "Report an issue";
            this.ReportIssueMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportIssueMenuItem.Name = "ReportIssueMenuItem";
            this.ReportIssueMenuItem.ShortcutKeyDisplayString = "CONTROL+SHIFT+I";
            this.ReportIssueMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.ReportIssueMenuItem.Size = new System.Drawing.Size(337, 26);
            this.ReportIssueMenuItem.Text = "Report an &issue";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.AccessibleDescription = "";
            this.AboutMenuItem.AccessibleName = "About...";
            this.AboutMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(337, 26);
            this.AboutMenuItem.Text = "&About...";
            // 
            // TFMTabControl
            // 
            this.TFMTabControl.AccessibleName = "Primary tabs";
            this.TFMTabControl.Controls.Add(this.AvionicsTabPage);
            this.TFMTabControl.Controls.Add(this.FlightPlanTabPage);
            this.TFMTabControl.Controls.Add(this.ProceduresTabPage);
            this.TFMTabControl.Controls.Add(this.FindTabPage);
            this.TFMTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TFMTabControl.Location = new System.Drawing.Point(0, 33);
            this.TFMTabControl.Name = "TFMTabControl";
            this.TFMTabControl.SelectedIndex = 0;
            this.TFMTabControl.Size = new System.Drawing.Size(717, 479);
            this.TFMTabControl.TabIndex = 1;
            // 
            // AvionicsTabPage
            // 
            this.AvionicsTabPage.AccessibleName = "Avionics";
            this.AvionicsTabPage.Controls.Add(this.AvionicsLayoutTable);
            this.AvionicsTabPage.Location = new System.Drawing.Point(4, 30);
            this.AvionicsTabPage.Name = "AvionicsTabPage";
            this.AvionicsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AvionicsTabPage.Size = new System.Drawing.Size(709, 445);
            this.AvionicsTabPage.TabIndex = 0;
            this.AvionicsTabPage.Text = "Avionics";
            this.AvionicsTabPage.UseVisualStyleBackColor = true;
            // 
            // AvionicsLayoutTable
            // 
            this.AvionicsLayoutTable.AutoSize = true;
            this.AvionicsLayoutTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AvionicsLayoutTable.ColumnCount = 2;
            this.AvionicsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AvionicsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AvionicsLayoutTable.Controls.Add(this.AltitudeGroupBox, 0, 1);
            this.AvionicsLayoutTable.Controls.Add(this.HeadingGroupBox, 0, 0);
            this.AvionicsLayoutTable.Controls.Add(this.AirSpeedGroupBox, 0, 2);
            this.AvionicsLayoutTable.Controls.Add(this.MachGroupBox, 0, 3);
            this.AvionicsLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvionicsLayoutTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.AvionicsLayoutTable.Location = new System.Drawing.Point(3, 3);
            this.AvionicsLayoutTable.Name = "AvionicsLayoutTable";
            this.AvionicsLayoutTable.RowCount = 6;
            this.AvionicsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AvionicsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AvionicsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AvionicsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AvionicsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AvionicsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AvionicsLayoutTable.Size = new System.Drawing.Size(703, 439);
            this.AvionicsLayoutTable.TabIndex = 3;
            // 
            // AltitudeGroupBox
            // 
            this.AltitudeGroupBox.AccessibleName = "Altitude group";
            this.AltitudeGroupBox.AutoSize = true;
            this.AltitudeGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AltitudeGroupBox.Controls.Add(this.APAltitudeCheckBox);
            this.AltitudeGroupBox.Controls.Add(this.AltitudeTextBox);
            this.AltitudeGroupBox.Controls.Add(this.AltitudeLabel);
            this.AltitudeGroupBox.Location = new System.Drawing.Point(3, 76);
            this.AltitudeGroupBox.Name = "AltitudeGroupBox";
            this.AltitudeGroupBox.Size = new System.Drawing.Size(321, 67);
            this.AltitudeGroupBox.TabIndex = 3;
            this.AltitudeGroupBox.TabStop = false;
            this.AltitudeGroupBox.Text = "Altitude";
            // 
            // APAltitudeCheckBox
            // 
            this.APAltitudeCheckBox.AccessibleName = "Give altitude to autopilot";
            this.APAltitudeCheckBox.AutoSize = true;
            this.APAltitudeCheckBox.Location = new System.Drawing.Point(187, 25);
            this.APAltitudeCheckBox.Name = "APAltitudeCheckBox";
            this.APAltitudeCheckBox.Size = new System.Drawing.Size(128, 25);
            this.APAltitudeCheckBox.TabIndex = 2;
            this.APAltitudeCheckBox.Text = "A&ltitude (AP)";
            this.APAltitudeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AltitudeTextBox
            // 
            this.AltitudeTextBox.AccessibleName = "Enter altitude";
            this.AltitudeTextBox.Location = new System.Drawing.Point(81, 25);
            this.AltitudeTextBox.Name = "AltitudeTextBox";
            this.AltitudeTextBox.Size = new System.Drawing.Size(100, 29);
            this.AltitudeTextBox.TabIndex = 1;
            this.AltitudeTextBox.WordWrap = false;
            // 
            // AltitudeLabel
            // 
            this.AltitudeLabel.AccessibleName = "Altitude:";
            this.AltitudeLabel.AutoSize = true;
            this.AltitudeLabel.Location = new System.Drawing.Point(3, 25);
            this.AltitudeLabel.Name = "AltitudeLabel";
            this.AltitudeLabel.Size = new System.Drawing.Size(72, 21);
            this.AltitudeLabel.TabIndex = 0;
            this.AltitudeLabel.Text = "&Altitude:";
            // 
            // HeadingGroupBox
            // 
            this.HeadingGroupBox.AccessibleName = "Heading group";
            this.HeadingGroupBox.AutoSize = true;
            this.HeadingGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeadingGroupBox.Controls.Add(this.APHeadingCheckBox);
            this.HeadingGroupBox.Controls.Add(this.HeadingTextBox);
            this.HeadingGroupBox.Controls.Add(this.HeadingLabel);
            this.HeadingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.HeadingGroupBox.Name = "HeadingGroupBox";
            this.HeadingGroupBox.Size = new System.Drawing.Size(327, 67);
            this.HeadingGroupBox.TabIndex = 2;
            this.HeadingGroupBox.TabStop = false;
            this.HeadingGroupBox.Text = "Heading";
            // 
            // APHeadingCheckBox
            // 
            this.APHeadingCheckBox.AccessibleName = "Give heading to autopilot";
            this.APHeadingCheckBox.AutoSize = true;
            this.APHeadingCheckBox.Location = new System.Drawing.Point(190, 25);
            this.APHeadingCheckBox.Name = "APHeadingCheckBox";
            this.APHeadingCheckBox.Size = new System.Drawing.Size(131, 25);
            this.APHeadingCheckBox.TabIndex = 2;
            this.APHeadingCheckBox.Text = "H&eading (AP)";
            this.APHeadingCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeadingTextBox
            // 
            this.HeadingTextBox.AccessibleName = "Enter heading";
            this.HeadingTextBox.Location = new System.Drawing.Point(84, 25);
            this.HeadingTextBox.Name = "HeadingTextBox";
            this.HeadingTextBox.Size = new System.Drawing.Size(100, 29);
            this.HeadingTextBox.TabIndex = 1;
            this.HeadingTextBox.WordWrap = false;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AccessibleName = "Heading:";
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Location = new System.Drawing.Point(3, 25);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(75, 21);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Hea&ding:";
            // 
            // FlightPlanTabPage
            // 
            this.FlightPlanTabPage.AccessibleName = "Flight plan";
            this.FlightPlanTabPage.Location = new System.Drawing.Point(4, 30);
            this.FlightPlanTabPage.Name = "FlightPlanTabPage";
            this.FlightPlanTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FlightPlanTabPage.Size = new System.Drawing.Size(709, 445);
            this.FlightPlanTabPage.TabIndex = 1;
            this.FlightPlanTabPage.Text = "Flight plan";
            this.FlightPlanTabPage.UseVisualStyleBackColor = true;
            // 
            // ProceduresTabPage
            // 
            this.ProceduresTabPage.AccessibleName = "Procedures";
            this.ProceduresTabPage.Location = new System.Drawing.Point(4, 30);
            this.ProceduresTabPage.Name = "ProceduresTabPage";
            this.ProceduresTabPage.Size = new System.Drawing.Size(709, 445);
            this.ProceduresTabPage.TabIndex = 2;
            this.ProceduresTabPage.Text = "Procedures";
            this.ProceduresTabPage.UseVisualStyleBackColor = true;
            // 
            // FindTabPage
            // 
            this.FindTabPage.AccessibleName = "Find";
            this.FindTabPage.Location = new System.Drawing.Point(4, 30);
            this.FindTabPage.Name = "FindTabPage";
            this.FindTabPage.Size = new System.Drawing.Size(709, 445);
            this.FindTabPage.TabIndex = 3;
            this.FindTabPage.Text = "Find";
            this.FindTabPage.UseVisualStyleBackColor = true;
            // 
            // AirSpeedGroupBox
            // 
            this.AirSpeedGroupBox.AccessibleName = "Air speed";
            this.AirSpeedGroupBox.AutoSize = true;
            this.AirSpeedGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AirSpeedGroupBox.Controls.Add(this.AirSpeedCheckBox);
            this.AirSpeedGroupBox.Controls.Add(this.AirSpeedTextBox);
            this.AirSpeedGroupBox.Controls.Add(this.AirSpeedLabel);
            this.AirSpeedGroupBox.Location = new System.Drawing.Point(3, 149);
            this.AirSpeedGroupBox.Name = "AirSpeedGroupBox";
            this.AirSpeedGroupBox.Size = new System.Drawing.Size(344, 67);
            this.AirSpeedGroupBox.TabIndex = 4;
            this.AirSpeedGroupBox.TabStop = false;
            this.AirSpeedGroupBox.Text = "Air speed";
            // 
            // AirSpeedLabel
            // 
            this.AirSpeedLabel.AccessibleName = "Air speed";
            this.AirSpeedLabel.AutoSize = true;
            this.AirSpeedLabel.Location = new System.Drawing.Point(3, 25);
            this.AirSpeedLabel.Name = "AirSpeedLabel";
            this.AirSpeedLabel.Size = new System.Drawing.Size(82, 21);
            this.AirSpeedLabel.TabIndex = 0;
            this.AirSpeedLabel.Text = "Air &speed";
            // 
            // AirSpeedTextBox
            // 
            this.AirSpeedTextBox.AccessibleName = "Enter air speed";
            this.AirSpeedTextBox.Location = new System.Drawing.Point(90, 25);
            this.AirSpeedTextBox.Name = "AirSpeedTextBox";
            this.AirSpeedTextBox.Size = new System.Drawing.Size(100, 29);
            this.AirSpeedTextBox.TabIndex = 1;
            this.AirSpeedTextBox.WordWrap = false;
            // 
            // AirSpeedCheckBox
            // 
            this.AirSpeedCheckBox.AccessibleName = "Give air speed to autopilot";
            this.AirSpeedCheckBox.AutoSize = true;
            this.AirSpeedCheckBox.Location = new System.Drawing.Point(196, 25);
            this.AirSpeedCheckBox.Name = "AirSpeedCheckBox";
            this.AirSpeedCheckBox.Size = new System.Drawing.Size(142, 25);
            this.AirSpeedCheckBox.TabIndex = 2;
            this.AirSpeedCheckBox.Text = "Air s&peed (AP)";
            this.AirSpeedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MachGroupBox
            // 
            this.MachGroupBox.AccessibleName = "Mach group";
            this.MachGroupBox.AutoSize = true;
            this.MachGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MachGroupBox.Location = new System.Drawing.Point(3, 222);
            this.MachGroupBox.Name = "MachGroupBox";
            this.MachGroupBox.Size = new System.Drawing.Size(6, 5);
            this.MachGroupBox.TabIndex = 5;
            this.MachGroupBox.TabStop = false;
            this.MachGroupBox.Text = "Mach";
            // 
            // TFMMainForm
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "Talking flight moniter";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(717, 512);
            this.Controls.Add(this.TFMTabControl);
            this.Controls.Add(this.TFMMainMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.TFMMainMenu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TFMMainForm";
            this.Text = "Talking flight moniter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.TFMMainMenu.ResumeLayout(false);
            this.TFMMainMenu.PerformLayout();
            this.TFMTabControl.ResumeLayout(false);
            this.AvionicsTabPage.ResumeLayout(false);
            this.AvionicsTabPage.PerformLayout();
            this.AvionicsLayoutTable.ResumeLayout(false);
            this.AvionicsLayoutTable.PerformLayout();
            this.AltitudeGroupBox.ResumeLayout(false);
            this.AltitudeGroupBox.PerformLayout();
            this.HeadingGroupBox.ResumeLayout(false);
            this.HeadingGroupBox.PerformLayout();
            this.AirSpeedGroupBox.ResumeLayout(false);
            this.AirSpeedGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.MenuStrip TFMMainMenu;
        private System.Windows.Forms.ToolStripMenuItem PlanMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenPlanMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SavePlanMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavePlanAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem QuitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem A2AManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AircraftMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem WebsiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportIssueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.TabControl TFMTabControl;
        private System.Windows.Forms.TabPage AvionicsTabPage;
        private System.Windows.Forms.TabPage FlightPlanTabPage;
        private System.Windows.Forms.TabPage ProceduresTabPage;
        private System.Windows.Forms.TabPage FindTabPage;
        private System.Windows.Forms.TableLayoutPanel AvionicsLayoutTable;
        private System.Windows.Forms.GroupBox AltitudeGroupBox;
        private System.Windows.Forms.CheckBox APAltitudeCheckBox;
        private System.Windows.Forms.TextBox AltitudeTextBox;
        private System.Windows.Forms.Label AltitudeLabel;
        private System.Windows.Forms.GroupBox HeadingGroupBox;
        private System.Windows.Forms.CheckBox APHeadingCheckBox;
        private System.Windows.Forms.TextBox HeadingTextBox;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.GroupBox AirSpeedGroupBox;
        private System.Windows.Forms.CheckBox AirSpeedCheckBox;
        private System.Windows.Forms.TextBox AirSpeedTextBox;
        private System.Windows.Forms.Label AirSpeedLabel;
        private System.Windows.Forms.GroupBox MachGroupBox;
    }
}

