﻿namespace adbGUI.Forms
{
      partial class MainForm
      {
            /// <summary>
            /// Erforderliche Designervariable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Verwendete Ressourcen bereinigen.
            /// </summary>
            /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Vom Windows Form-Designer generierter Code

            /// <summary>
            /// Erforderliche Methode für die Designerunterstützung.
            /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
            /// </summary>
            private void InitializeComponent()
            {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Files");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sideload");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("All User");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Max User");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("IMEI");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Accounts");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Backup Restore");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Phone", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Screenshot");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Screenrecord");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Resolution");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Density");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Get Prop");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Set Prop");
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Prop", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Processes");
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Memory");
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Battery Service State");
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Collected Battery Stats");
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Reset Battery Stats");
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Alarm Manager State");
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Uptime");
			System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("CPU Info");
			System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Diskstats");
			System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Permissions");
			System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Filesystem");
			System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Remount System");
			System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
			System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Network Traffic");
			System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Netstat");
			System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("WiFi Info");
			System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Hosts");
			System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Network Info");
			System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Spoof MAC");
			System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
			System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("All packages");
			System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Libraries");
			System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Features");
			System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Install and Uninstall");
			System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Packages", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
			System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Logcat Live");
			System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Logcat Dump");
			System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Dump to file");
			System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Clear all buffers");
			System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Logcat Advanced");
			System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Verbose");
			System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Debug");
			System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Info");
			System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Warning");
			System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Error");
			System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Fatal");
			System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Silent");
			System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54});
			System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Logcat", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode55});
			System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Dumpsys");
			System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Kernel Messages");
			System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Logging", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode57,
            treeNode58});
			System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Devices");
			System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Continue Boot");
			System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Reboot Normal");
			System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Reboot Bootloader");
			System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Erase");
			System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Erase Recovery");
			System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Flash");
			System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Help");
			System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Version");
			System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Fastboot", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67,
            treeNode68});
			System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Help");
			System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Version");
			System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71});
			System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Credits");
			System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("About", new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode73});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btn_executeCommand = new System.Windows.Forms.Button();
			this.trv_commandTreeView = new System.Windows.Forms.TreeView();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.cbx_customCommand = new System.Windows.Forms.ComboBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.rtb_console = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_consoleStop = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsc_ConnectedDevices = new System.Windows.Forms.ToolStripComboBox();
			this.tsd_Power = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsm_PowerRebootNormal = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerRebootRecovery = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerRebootBootloader = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerRebootFastboot = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerSideloadMode = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerShutdown = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_PowerSleep = new System.Windows.Forms.ToolStripMenuItem();
			this.tsd_WirelessAdb = new System.Windows.Forms.ToolStripDropDownButton();
			this.tst_IpAdress = new System.Windows.Forms.ToolStripTextBox();
			this.tsm_WirelessConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_WirelessDisconnect = new System.Windows.Forms.ToolStripMenuItem();
			this.tsb_KillServer = new System.Windows.Forms.ToolStripButton();
			this.tsb_OpenShell = new System.Windows.Forms.ToolStripButton();
			this.tsb_AdbRoot = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.tsb_AdbUnroot = new System.Windows.Forms.ToolStripButton();
			this.tsb_AlwayClearConsole = new System.Windows.Forms.ToolStripButton();
			this.btn_ConsoleClear = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_executeCommand
			// 
			this.btn_executeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_executeCommand.Location = new System.Drawing.Point(849, 561);
			this.btn_executeCommand.Name = "btn_executeCommand";
			this.btn_executeCommand.Size = new System.Drawing.Size(54, 23);
			this.btn_executeCommand.TabIndex = 1;
			this.btn_executeCommand.Text = "Execute";
			this.btn_executeCommand.UseVisualStyleBackColor = true;
			this.btn_executeCommand.Click += new System.EventHandler(this.Btn_executeCommand_Click);
			// 
			// trv_commandTreeView
			// 
			this.trv_commandTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.trv_commandTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trv_commandTreeView.Location = new System.Drawing.Point(2, 2);
			this.trv_commandTreeView.Margin = new System.Windows.Forms.Padding(2);
			this.trv_commandTreeView.Name = "trv_commandTreeView";
			treeNode1.Name = "Knoten0";
			treeNode1.Tag = "#FileOps";
			treeNode1.Text = "Files";
			treeNode2.Name = "Knoten2";
			treeNode2.Tag = "#Sideload";
			treeNode2.Text = "Sideload";
			treeNode3.Name = "Knoten15";
			treeNode3.Tag = "adb shell pm list users";
			treeNode3.Text = "All User";
			treeNode4.Name = "Knoten17";
			treeNode4.Tag = "adb shell pm get-max-users";
			treeNode4.Text = "Max User";
			treeNode5.Name = "Knoten19";
			treeNode5.Tag = "adb exec-out \"service call iphonesubinfo 4 | cut -c 52-66 | tr -d \'.[:space:]\'\"";
			treeNode5.Text = "IMEI";
			treeNode6.Name = "Knoten27";
			treeNode6.Tag = "adb shell dumpsys account";
			treeNode6.Text = "Accounts";
			treeNode7.Name = "Knoten3";
			treeNode7.Tag = "#BackupRestore";
			treeNode7.Text = "Backup Restore";
			treeNode8.Name = "Knoten3";
			treeNode8.Tag = "0";
			treeNode8.Text = "Phone";
			treeNode9.Name = "Knoten31";
			treeNode9.Tag = "%screenshot";
			treeNode9.Text = "Screenshot";
			treeNode9.ToolTipText = "Take a screenshot";
			treeNode10.Name = "Knoten0";
			treeNode10.Tag = "#ScreenRecord";
			treeNode10.Text = "Screenrecord";
			treeNode10.ToolTipText = "Record screen up to 3 minutes";
			treeNode11.Name = "Knoten1";
			treeNode11.Tag = "#ResolutionChange";
			treeNode11.Text = "Resolution";
			treeNode11.ToolTipText = "Change Resolution";
			treeNode12.Name = "Knoten2";
			treeNode12.Tag = "#Density";
			treeNode12.Text = "Density";
			treeNode13.Name = "Knoten0";
			treeNode13.Tag = "0";
			treeNode13.Text = "Display";
			treeNode14.Name = "Knoten4";
			treeNode14.Tag = "adb shell getprop";
			treeNode14.Text = "Get Prop";
			treeNode15.Name = "Knoten1";
			treeNode15.Tag = "#SetProp";
			treeNode15.Text = "Set Prop";
			treeNode16.Name = "Knoten0";
			treeNode16.Tag = "0";
			treeNode16.Text = "Prop";
			treeNode17.Name = "Knoten8";
			treeNode17.Tag = "adb shell ps";
			treeNode17.Text = "Processes";
			treeNode18.Name = "Knoten9";
			treeNode18.Tag = "adb shell dumpsys meminfo";
			treeNode18.Text = "Memory";
			treeNode19.Name = "Knoten1";
			treeNode19.Tag = "adb shell dumpsys battery";
			treeNode19.Text = "Battery Service State";
			treeNode20.Name = "Knoten2";
			treeNode20.Tag = "adb shell dumpsys batterystats";
			treeNode20.Text = "Collected Battery Stats";
			treeNode21.Name = "Knoten3";
			treeNode21.Tag = "adb shell dumpsys batterystats --reset";
			treeNode21.Text = "Reset Battery Stats";
			treeNode22.Name = "Knoten22";
			treeNode22.Tag = "";
			treeNode22.Text = "Battery";
			treeNode23.Name = "Knoten12";
			treeNode23.Tag = "adb shell dumpsys alarm";
			treeNode23.Text = "Alarm Manager State";
			treeNode24.Name = "Knoten16";
			treeNode24.Tag = "adb shell uptime";
			treeNode24.Text = "Uptime";
			treeNode25.Name = "Knoten24";
			treeNode25.Tag = "adb shell dumpsys cpuinfo";
			treeNode25.Text = "CPU Info";
			treeNode26.Name = "Knoten26";
			treeNode26.Tag = "adb shell dumpsys diskstats";
			treeNode26.Text = "Diskstats";
			treeNode27.Name = "Knoten28";
			treeNode27.Tag = "adb shell pm list permissions";
			treeNode27.Text = "Permissions";
			treeNode28.Name = "Knoten0";
			treeNode28.Tag = "adb shell df -h";
			treeNode28.Text = "Filesystem";
			treeNode29.Name = "Knoten0";
			treeNode29.Tag = "adb remount";
			treeNode29.Text = "Remount System";
			treeNode30.Name = "Knoten0";
			treeNode30.Tag = "0";
			treeNode30.Text = "System";
			treeNode31.Name = "Knoten7";
			treeNode31.Tag = "adb shell iftop";
			treeNode31.Text = "Network Traffic";
			treeNode32.Name = "Knoten25";
			treeNode32.Tag = "adb shell netstat";
			treeNode32.Text = "Netstat";
			treeNode33.Name = "Knoten23";
			treeNode33.Tag = "adb shell dumpsys wifi";
			treeNode33.Text = "WiFi Info";
			treeNode34.Name = "Knoten29";
			treeNode34.Tag = "adb shell cat /etc/hosts";
			treeNode34.Text = "Hosts";
			treeNode35.Name = "Knoten0";
			treeNode35.Tag = "adb shell ifconfig";
			treeNode35.Text = "Network Info";
			treeNode36.Name = "Knoten3";
			treeNode36.Tag = "#SpoofMac";
			treeNode36.Text = "Spoof MAC";
			treeNode37.Name = "Knoten1";
			treeNode37.Tag = "0";
			treeNode37.Text = "Network";
			treeNode38.Name = "Knoten11";
			treeNode38.Tag = "adb shell pm list packages -f";
			treeNode38.Text = "All packages";
			treeNode39.Name = "Knoten13";
			treeNode39.Tag = "adb shell pm list libraries";
			treeNode39.Text = "Libraries";
			treeNode40.Name = "Knoten10";
			treeNode40.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
			treeNode40.Text = "Features";
			treeNode41.Name = "Knoten1";
			treeNode41.Tag = "#InstallUninstall";
			treeNode41.Text = "Install and Uninstall";
			treeNode42.Name = "Knoten2";
			treeNode42.Tag = "0";
			treeNode42.Text = "Packages";
			treeNode43.Name = "Knoten1";
			treeNode43.Tag = "adb logcat";
			treeNode43.Text = "Logcat Live";
			treeNode44.Name = "Knoten6";
			treeNode44.Tag = "adb logcat -d";
			treeNode44.Text = "Logcat Dump";
			treeNode45.Name = "Knoten0";
			treeNode45.Tag = "adb logcat -d > logcat.txt";
			treeNode45.Text = "Dump to file";
			treeNode46.Name = "Knoten0";
			treeNode46.Tag = "adb logcat -b all -c";
			treeNode46.Text = "Clear all buffers";
			treeNode47.Name = "Knoten0";
			treeNode47.Tag = "#LogcatAdvanced";
			treeNode47.Text = "Logcat Advanced";
			treeNode48.Name = "Knoten4";
			treeNode48.Tag = "adb logcat *:V";
			treeNode48.Text = "Verbose";
			treeNode49.Name = "Knoten5";
			treeNode49.Tag = "adb logcat *:D";
			treeNode49.Text = "Debug";
			treeNode50.Name = "Knoten6";
			treeNode50.Tag = "adb logcat *:I";
			treeNode50.Text = "Info";
			treeNode51.Name = "Knoten7";
			treeNode51.Tag = "adb logcat *:W";
			treeNode51.Text = "Warning";
			treeNode52.Name = "Knoten8";
			treeNode52.Tag = "adb logcat *:E";
			treeNode52.Text = "Error";
			treeNode53.Name = "Knoten9";
			treeNode53.Tag = "adb logcat *:F";
			treeNode53.Text = "Fatal";
			treeNode54.Name = "Knoten11";
			treeNode54.Tag = "adb logcat *:S";
			treeNode54.Text = "Silent";
			treeNode55.Name = "Knoten3";
			treeNode55.Tag = "0";
			treeNode55.Text = "Filter";
			treeNode56.Name = "Knoten0";
			treeNode56.Tag = "0";
			treeNode56.Text = "Logcat";
			treeNode57.Name = "Knoten5";
			treeNode57.Tag = "adb shell dumpsys";
			treeNode57.Text = "Dumpsys";
			treeNode58.Name = "Knoten21";
			treeNode58.Tag = "adb shell dmesg";
			treeNode58.Text = "Kernel Messages";
			treeNode59.Name = "Knoten20";
			treeNode59.Tag = "0";
			treeNode59.Text = "Logging";
			treeNode60.Name = "Knoten2";
			treeNode60.Tag = "fastboot devices";
			treeNode60.Text = "Devices";
			treeNode61.Name = "Knoten8";
			treeNode61.Tag = "fastboot continue";
			treeNode61.Text = "Continue Boot";
			treeNode62.Name = "Knoten4";
			treeNode62.Tag = "fastboot reboot";
			treeNode62.Text = "Reboot Normal";
			treeNode63.Name = "Knoten3";
			treeNode63.Tag = "fastboot reboot bootloader";
			treeNode63.Text = "Reboot Bootloader";
			treeNode64.Name = "Knoten5";
			treeNode64.Tag = "#Erase";
			treeNode64.Text = "Erase";
			treeNode65.Name = "Knoten6";
			treeNode65.Tag = "fastboot erase recovery";
			treeNode65.Text = "Erase Recovery";
			treeNode66.Name = "Knoten7";
			treeNode66.Tag = "#Flash";
			treeNode66.Text = "Flash";
			treeNode67.Name = "Knoten1";
			treeNode67.Tag = "fastboot help";
			treeNode67.Text = "Help";
			treeNode68.Name = "Knoten3";
			treeNode68.Tag = "fastboot --version";
			treeNode68.Text = "Version";
			treeNode69.Name = "Knoten0";
			treeNode69.Tag = "0";
			treeNode69.Text = "Fastboot";
			treeNode70.Name = "Knoten1";
			treeNode70.Tag = "adb help";
			treeNode70.Text = "Help";
			treeNode71.Name = "Knoten2";
			treeNode71.Tag = "adb version";
			treeNode71.Text = "Version";
			treeNode72.Name = "Knoten0";
			treeNode72.Tag = "0";
			treeNode72.Text = "Adb";
			treeNode73.Name = "Knoten1";
			treeNode73.Tag = "#Credits";
			treeNode73.Text = "Credits";
			treeNode74.Name = "Knoten0";
			treeNode74.Tag = "0";
			treeNode74.Text = "About";
			this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode13,
            treeNode30,
            treeNode37,
            treeNode42,
            treeNode59,
            treeNode69,
            treeNode74});
			this.trv_commandTreeView.Size = new System.Drawing.Size(194, 540);
			this.trv_commandTreeView.TabIndex = 0;
			this.trv_commandTreeView.DoubleClick += new System.EventHandler(this.Trv_commandTreeView_DoubleClick);
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 500;
			this.toolTip.ReshowDelay = 100;
			this.toolTip.UseFading = false;
			// 
			// cbx_customCommand
			// 
			this.cbx_customCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbx_customCommand.AutoCompleteCustomSource.AddRange(new string[] {
            "devices"});
			this.cbx_customCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cbx_customCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbx_customCommand.FormattingEnabled = true;
			this.cbx_customCommand.Location = new System.Drawing.Point(215, 562);
			this.cbx_customCommand.Name = "cbx_customCommand";
			this.cbx_customCommand.Size = new System.Drawing.Size(628, 21);
			this.cbx_customCommand.TabIndex = 12;
			this.cbx_customCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_customCommand_KeyDown);
			// 
			// rtb_console
			// 
			this.rtb_console.BackColor = System.Drawing.Color.White;
			this.rtb_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_console.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_console.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtb_console.HideSelection = false;
			this.rtb_console.Location = new System.Drawing.Point(1, 2);
			this.rtb_console.Margin = new System.Windows.Forms.Padding(2);
			this.rtb_console.Name = "rtb_console";
			this.rtb_console.ReadOnly = true;
			this.rtb_console.Size = new System.Drawing.Size(803, 515);
			this.rtb_console.TabIndex = 11;
			this.rtb_console.Text = "";
			this.rtb_console.Resize += new System.EventHandler(this.Rtb_console_Resize);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.rtb_console);
			this.panel1.Location = new System.Drawing.Point(215, 39);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.panel1.Size = new System.Drawing.Size(807, 521);
			this.panel1.TabIndex = 12;
			// 
			// btn_consoleStop
			// 
			this.btn_consoleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_consoleStop.Location = new System.Drawing.Point(909, 561);
			this.btn_consoleStop.Name = "btn_consoleStop";
			this.btn_consoleStop.Size = new System.Drawing.Size(54, 23);
			this.btn_consoleStop.TabIndex = 1;
			this.btn_consoleStop.Text = "Stop";
			this.btn_consoleStop.UseVisualStyleBackColor = true;
			this.btn_consoleStop.Click += new System.EventHandler(this.Btn_consoleStop_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsc_ConnectedDevices,
            this.tsd_Power,
            this.tsd_WirelessAdb,
            this.tsb_KillServer,
            this.tsb_OpenShell,
            this.tsb_AdbRoot,
            this.toolStripLabel1,
            this.tsb_AdbUnroot,
            this.tsb_AlwayClearConsole});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(12, 10, 11, 3);
			this.toolStrip1.Size = new System.Drawing.Size(1034, 36);
			this.toolStrip1.TabIndex = 13;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsc_ConnectedDevices
			// 
			this.tsc_ConnectedDevices.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsc_ConnectedDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tsc_ConnectedDevices.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			this.tsc_ConnectedDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsc_ConnectedDevices.Name = "tsc_ConnectedDevices";
			this.tsc_ConnectedDevices.Size = new System.Drawing.Size(150, 23);
			this.tsc_ConnectedDevices.SelectedIndexChanged += new System.EventHandler(this.Tsc_ConnectedDevices_SelectedIndexChanged);
			// 
			// tsd_Power
			// 
			this.tsd_Power.AutoToolTip = false;
			this.tsd_Power.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_PowerRebootNormal,
            this.tsm_PowerRebootRecovery,
            this.tsm_PowerRebootBootloader,
            this.tsm_PowerRebootFastboot,
            this.tsm_PowerSideloadMode,
            this.tsm_PowerShutdown,
            this.tsm_PowerSleep});
			this.tsd_Power.Image = global::adbGUI.Properties.Resources.power;
			this.tsd_Power.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsd_Power.Name = "tsd_Power";
			this.tsd_Power.Size = new System.Drawing.Size(96, 20);
			this.tsd_Power.Text = "Power Menu";
			// 
			// tsm_PowerRebootNormal
			// 
			this.tsm_PowerRebootNormal.Name = "tsm_PowerRebootNormal";
			this.tsm_PowerRebootNormal.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerRebootNormal.Text = "Reboot Normal";
			this.tsm_PowerRebootNormal.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerRebootRecovery
			// 
			this.tsm_PowerRebootRecovery.Name = "tsm_PowerRebootRecovery";
			this.tsm_PowerRebootRecovery.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerRebootRecovery.Text = "Reboot Recovery";
			this.tsm_PowerRebootRecovery.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerRebootBootloader
			// 
			this.tsm_PowerRebootBootloader.Name = "tsm_PowerRebootBootloader";
			this.tsm_PowerRebootBootloader.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerRebootBootloader.Text = "Reboot Bootloader";
			this.tsm_PowerRebootBootloader.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerRebootFastboot
			// 
			this.tsm_PowerRebootFastboot.Name = "tsm_PowerRebootFastboot";
			this.tsm_PowerRebootFastboot.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerRebootFastboot.Text = "Reboot Fastboot";
			this.tsm_PowerRebootFastboot.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerSideloadMode
			// 
			this.tsm_PowerSideloadMode.Name = "tsm_PowerSideloadMode";
			this.tsm_PowerSideloadMode.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerSideloadMode.Text = "Sideload Mode";
			this.tsm_PowerSideloadMode.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerShutdown
			// 
			this.tsm_PowerShutdown.Name = "tsm_PowerShutdown";
			this.tsm_PowerShutdown.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerShutdown.Text = "Shutdown";
			this.tsm_PowerShutdown.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsm_PowerSleep
			// 
			this.tsm_PowerSleep.Name = "tsm_PowerSleep";
			this.tsm_PowerSleep.Size = new System.Drawing.Size(163, 22);
			this.tsm_PowerSleep.Text = "Sleep";
			this.tsm_PowerSleep.Click += new System.EventHandler(this.Tsb_Power_Click);
			// 
			// tsd_WirelessAdb
			// 
			this.tsd_WirelessAdb.AutoToolTip = false;
			this.tsd_WirelessAdb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_IpAdress,
            this.tsm_WirelessConnect,
            this.tsm_WirelessDisconnect});
			this.tsd_WirelessAdb.Image = global::adbGUI.Properties.Resources.wifi;
			this.tsd_WirelessAdb.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsd_WirelessAdb.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsd_WirelessAdb.Name = "tsd_WirelessAdb";
			this.tsd_WirelessAdb.Size = new System.Drawing.Size(101, 20);
			this.tsd_WirelessAdb.Text = "Wireless ADB";
			// 
			// tst_IpAdress
			// 
			this.tst_IpAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tst_IpAdress.Name = "tst_IpAdress";
			this.tst_IpAdress.Size = new System.Drawing.Size(123, 20);
			this.tst_IpAdress.Text = "192.168.0.44:5555";
			// 
			// tsm_WirelessConnect
			// 
			this.tsm_WirelessConnect.Name = "tsm_WirelessConnect";
			this.tsm_WirelessConnect.Size = new System.Drawing.Size(183, 22);
			this.tsm_WirelessConnect.Text = "Connect Device";
			this.tsm_WirelessConnect.Click += new System.EventHandler(this.Tsm_WirelessConnect_Click);
			// 
			// tsm_WirelessDisconnect
			// 
			this.tsm_WirelessDisconnect.Name = "tsm_WirelessDisconnect";
			this.tsm_WirelessDisconnect.Size = new System.Drawing.Size(183, 22);
			this.tsm_WirelessDisconnect.Text = "Disconnect All";
			this.tsm_WirelessDisconnect.Click += new System.EventHandler(this.Tsm_WirelessDisconnect_Click);
			// 
			// tsb_KillServer
			// 
			this.tsb_KillServer.AutoToolTip = false;
			this.tsb_KillServer.Image = ((System.Drawing.Image)(resources.GetObject("tsb_KillServer.Image")));
			this.tsb_KillServer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_KillServer.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsb_KillServer.Name = "tsb_KillServer";
			this.tsb_KillServer.Size = new System.Drawing.Size(74, 20);
			this.tsb_KillServer.Text = "Kill Server";
			this.tsb_KillServer.Click += new System.EventHandler(this.Tsb_KillServer_Click);
			// 
			// tsb_OpenShell
			// 
			this.tsb_OpenShell.AutoToolTip = false;
			this.tsb_OpenShell.Image = ((System.Drawing.Image)(resources.GetObject("tsb_OpenShell.Image")));
			this.tsb_OpenShell.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_OpenShell.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsb_OpenShell.Name = "tsb_OpenShell";
			this.tsb_OpenShell.Size = new System.Drawing.Size(79, 20);
			this.tsb_OpenShell.Text = "Open Shell";
			this.tsb_OpenShell.Click += new System.EventHandler(this.Tsb_OpenShell_Click);
			// 
			// tsb_AdbRoot
			// 
			this.tsb_AdbRoot.AutoToolTip = false;
			this.tsb_AdbRoot.Image = global::adbGUI.Properties.Resources.hash;
			this.tsb_AdbRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_AdbRoot.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsb_AdbRoot.Name = "tsb_AdbRoot";
			this.tsb_AdbRoot.Size = new System.Drawing.Size(75, 20);
			this.tsb_AdbRoot.Text = "ADB Root";
			this.tsb_AdbRoot.Click += new System.EventHandler(this.Tsb_AdbRoot_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(107, 20);
			this.toolStripLabel1.Text = "Connected Devices: ";
			// 
			// tsb_AdbUnroot
			// 
			this.tsb_AdbUnroot.AutoToolTip = false;
			this.tsb_AdbUnroot.Image = global::adbGUI.Properties.Resources.unroot;
			this.tsb_AdbUnroot.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_AdbUnroot.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.tsb_AdbUnroot.Name = "tsb_AdbUnroot";
			this.tsb_AdbUnroot.Size = new System.Drawing.Size(84, 20);
			this.tsb_AdbUnroot.Text = "ADB Unroot";
			this.tsb_AdbUnroot.Click += new System.EventHandler(this.Tsb_AdbUnroot_Click);
			// 
			// tsb_AlwayClearConsole
			// 
			this.tsb_AlwayClearConsole.CheckOnClick = true;
			this.tsb_AlwayClearConsole.Image = global::adbGUI.Properties.Resources.eraser;
			this.tsb_AlwayClearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_AlwayClearConsole.Name = "tsb_AlwayClearConsole";
			this.tsb_AlwayClearConsole.Size = new System.Drawing.Size(128, 20);
			this.tsb_AlwayClearConsole.Text = "Always Clear Console";
			this.tsb_AlwayClearConsole.CheckedChanged += new System.EventHandler(this.Tsb_AlwayClearConsole_CheckedChanged);
			// 
			// btn_ConsoleClear
			// 
			this.btn_ConsoleClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ConsoleClear.Location = new System.Drawing.Point(969, 561);
			this.btn_ConsoleClear.Name = "btn_ConsoleClear";
			this.btn_ConsoleClear.Size = new System.Drawing.Size(54, 23);
			this.btn_ConsoleClear.TabIndex = 14;
			this.btn_ConsoleClear.Text = "Clear";
			this.btn_ConsoleClear.UseVisualStyleBackColor = true;
			this.btn_ConsoleClear.Click += new System.EventHandler(this.Btn_ConsoleClear_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.trv_commandTreeView);
			this.panel2.Location = new System.Drawing.Point(13, 39);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 544);
			this.panel2.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 595);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btn_ConsoleClear);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_consoleStop);
			this.Controls.Add(this.btn_executeCommand);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.cbx_customCommand);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(1050, 634);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "adbGUI";
			this.toolTip.SetToolTip(this, "Enter command without adb.");
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.panel1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.ToolTip toolTip;
            private System.Windows.Forms.Button btn_executeCommand;
            private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TreeView trv_commandTreeView;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consoleStop;
        private System.Windows.Forms.ComboBox cbx_customCommand;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsd_WirelessAdb;
        private System.Windows.Forms.ToolStripTextBox tst_IpAdress;
        private System.Windows.Forms.ToolStripMenuItem tsm_WirelessConnect;
        private System.Windows.Forms.ToolStripMenuItem tsm_WirelessDisconnect;
        private System.Windows.Forms.ToolStripButton tsb_KillServer;
        private System.Windows.Forms.ToolStripButton tsb_OpenShell;
        private System.Windows.Forms.ToolStripButton tsb_AdbRoot;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsb_AdbUnroot;
        internal System.Windows.Forms.ToolStripComboBox tsc_ConnectedDevices;
        private System.Windows.Forms.ToolStripDropDownButton tsd_Power;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootNormal;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootRecovery;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootBootloader;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootFastboot;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerSideloadMode;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerSleep;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerShutdown;
		private System.Windows.Forms.Button btn_ConsoleClear;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStripButton tsb_AlwayClearConsole;
	}
}

