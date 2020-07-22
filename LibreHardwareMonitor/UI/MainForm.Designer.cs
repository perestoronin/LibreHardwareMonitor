// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) LibreHardwareMonitor and Contributors.
// Partial Copyright (C) Michael Möller <mmoeller@openhardwaremonitor.org> and Contributors.
// All Rights Reserved.

namespace LibreHardwareMonitor.UI
{
    using System.Windows.Forms;

    sealed partial class MainForm
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
            this.sensor = new Aga.Controls.Tree.TreeColumn();
            this.value = new Aga.Controls.Tree.TreeColumn();
            this.min = new Aga.Controls.Tree.TreeColumn();
            this.max = new Aga.Controls.Tree.TreeColumn();
            this.nodeImage = new Aga.Controls.Tree.NodeControls.NodeIcon();
            this.nodeCheckBox = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            this.nodeTextBoxText = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBoxValue = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBoxMin = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBoxMax = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.mainMenu = new MenuStrip(); // this.components);
            this.fileMenuItem = new ToolStripMenuItem();
            this.saveReportMenuItem = new ToolStripMenuItem();
            this.MenuItem2 = new ToolStripSeparator();
            this.resetMenuItem = new ToolStripMenuItem();
            this.menuItem5 = new ToolStripMenuItem();
            this.mainboardMenuItem = new ToolStripMenuItem();
            this.cpuMenuItem = new ToolStripMenuItem();
            this.ramMenuItem = new ToolStripMenuItem();
            this.gpuMenuItem = new ToolStripMenuItem();
            this.fanControllerMenuItem = new ToolStripMenuItem();
            this.hddMenuItem = new ToolStripMenuItem();
            this.nicMenuItem = new ToolStripMenuItem();
            this.menuItem6 = new ToolStripSeparator();
            this.exitMenuItem = new ToolStripMenuItem();
            this.viewMenuItem = new ToolStripMenuItem();
            this.resetMinMaxMenuItem = new ToolStripMenuItem();
            this.MenuItem3 = new ToolStripSeparator();
            this.hiddenMenuItem = new ToolStripMenuItem();
            this.plotMenuItem = new ToolStripMenuItem();
            this.gadgetMenuItem = new ToolStripMenuItem();
            this.MenuItem1 = new ToolStripMenuItem();
            this.columnsMenuItem = new ToolStripMenuItem();
            this.valueMenuItem = new ToolStripMenuItem();
            this.minMenuItem = new ToolStripMenuItem();
            this.maxMenuItem = new ToolStripMenuItem();
            this.optionsMenuItem = new ToolStripMenuItem();
            this.startMinMenuItem = new ToolStripMenuItem();
            this.minTrayMenuItem = new ToolStripMenuItem();
            this.minCloseMenuItem = new ToolStripMenuItem();
            this.startupMenuItem = new ToolStripMenuItem();
            this.separatorMenuItem = new ToolStripSeparator();
            this.temperatureUnitsMenuItem = new ToolStripMenuItem();
            this.celsiusMenuItem = new ToolStripMenuItem();
            this.fahrenheitMenuItem = new ToolStripMenuItem();
            this.plotLocationMenuItem = new ToolStripMenuItem();
            this.plotWindowMenuItem = new ToolStripMenuItem();
            this.plotBottomMenuItem = new ToolStripMenuItem();
            this.plotRightMenuItem = new ToolStripMenuItem();
            this.logSeparatorMenuItem = new ToolStripSeparator();
            this.logSensorsMenuItem = new ToolStripMenuItem();
            this.loggingIntervalMenuItem = new ToolStripMenuItem();
            this.log1sMenuItem = new ToolStripMenuItem();
            this.log2sMenuItem = new ToolStripMenuItem();
            this.log5sMenuItem = new ToolStripMenuItem();
            this.log10sMenuItem = new ToolStripMenuItem();
            this.log30sMenuItem = new ToolStripMenuItem();
            this.log1minMenuItem = new ToolStripMenuItem();
            this.log2minMenuItem = new ToolStripMenuItem();
            this.log5minMenuItem = new ToolStripMenuItem();
            this.log10minMenuItem = new ToolStripMenuItem();
            this.log30minMenuItem = new ToolStripMenuItem();
            this.log1hMenuItem = new ToolStripMenuItem();
            this.log2hMenuItem = new ToolStripMenuItem();
            this.log6hMenuItem = new ToolStripMenuItem();
            this.sensorValuesTimeWindowMenuItem = new ToolStripMenuItem();
            this.timeWindow30sMenuItem = new ToolStripMenuItem();
            this.timeWindow1minMenuItem = new ToolStripMenuItem();
            this.timeWindow2minMenuItem = new ToolStripMenuItem();
            this.timeWindow5minMenuItem = new ToolStripMenuItem();
            this.timeWindow10minMenuItem = new ToolStripMenuItem();
            this.timeWindow30minMenuItem = new ToolStripMenuItem();
            this.timeWindow1hMenuItem = new ToolStripMenuItem();
            this.timeWindow2hMenuItem = new ToolStripMenuItem();
            this.timeWindow6hMenuItem = new ToolStripMenuItem();
            this.timeWindow12hMenuItem = new ToolStripMenuItem();
            this.timeWindow24hMenuItem = new ToolStripMenuItem();
            this.webMenuItemSeparator = new ToolStripSeparator();
            this.webMenuItem = new ToolStripMenuItem();
            this.runWebServerMenuItem = new ToolStripMenuItem();
            this.serverPortMenuItem = new ToolStripMenuItem();
            this.authWebServerMenuItem = new ToolStripMenuItem();
            this.helpMenuItem = new ToolStripMenuItem();
            this.aboutMenuItem = new ToolStripMenuItem();
            this.treeContextMenu = new ContextMenuStrip();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer = new LibreHardwareMonitor.UI.SplitContainerAdv();
            this.treeView = new Aga.Controls.Tree.TreeViewAdv();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sensor
            // 
            this.sensor.Header = "Sensor";
            this.sensor.SortOrder = System.Windows.Forms.SortOrder.None;
            this.sensor.TooltipText = null;
            this.sensor.Width = 250;
            // 
            // value
            // 
            this.value.Header = "Value";
            this.value.SortOrder = System.Windows.Forms.SortOrder.None;
            this.value.TooltipText = null;
            this.value.Width = 100;
            // 
            // min
            // 
            this.min.Header = "Min";
            this.min.SortOrder = System.Windows.Forms.SortOrder.None;
            this.min.TooltipText = null;
            this.min.Width = 100;
            // 
            // max
            // 
            this.max.Header = "Max";
            this.max.SortOrder = System.Windows.Forms.SortOrder.None;
            this.max.TooltipText = null;
            this.max.Width = 100;
            // 
            // nodeImage
            // 
            this.nodeImage.DataPropertyName = "Image";
            this.nodeImage.LeftMargin = 1;
            this.nodeImage.ParentColumn = this.sensor;
            this.nodeImage.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Fit;
            // 
            // nodeCheckBox
            // 
            this.nodeCheckBox.DataPropertyName = "Plot";
            this.nodeCheckBox.EditEnabled = true;
            this.nodeCheckBox.LeftMargin = 3;
            this.nodeCheckBox.ParentColumn = this.sensor;
            // 
            // nodeTextBoxText
            // 
            this.nodeTextBoxText.DataPropertyName = "Text";
            this.nodeTextBoxText.EditEnabled = true;
            this.nodeTextBoxText.IncrementalSearchEnabled = true;
            this.nodeTextBoxText.LeftMargin = 3;
            this.nodeTextBoxText.ParentColumn = this.sensor;
            this.nodeTextBoxText.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.nodeTextBoxText.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxValue
            // 
            this.nodeTextBoxValue.DataPropertyName = "Value";
            this.nodeTextBoxValue.IncrementalSearchEnabled = true;
            this.nodeTextBoxValue.LeftMargin = 3;
            this.nodeTextBoxValue.ParentColumn = this.value;
            this.nodeTextBoxValue.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.nodeTextBoxValue.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxMin
            // 
            this.nodeTextBoxMin.DataPropertyName = "Min";
            this.nodeTextBoxMin.IncrementalSearchEnabled = true;
            this.nodeTextBoxMin.LeftMargin = 3;
            this.nodeTextBoxMin.ParentColumn = this.min;
            this.nodeTextBoxMin.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.nodeTextBoxMin.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxMax
            // 
            this.nodeTextBoxMax.DataPropertyName = "Max";
            this.nodeTextBoxMax.IncrementalSearchEnabled = true;
            this.nodeTextBoxMax.LeftMargin = 3;
            this.nodeTextBoxMax.ParentColumn = this.max;
            this.nodeTextBoxMax.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.nodeTextBoxMax.UseCompatibleTextRendering = true;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new ToolStripMenuItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.optionsMenuItem,
            this.helpMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.MergeIndex = 0;
            this.fileMenuItem.MergeAction = MergeAction.Insert;
            this.fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.saveReportMenuItem,
            this.MenuItem2,
            this.resetMenuItem,
            this.menuItem5,
            this.menuItem6,
            this.exitMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // saveReportMenuItem
            // 
            this.saveReportMenuItem.MergeIndex = 0;
            this.saveReportMenuItem.MergeAction = MergeAction.Insert;
            this.saveReportMenuItem.Text = "Save Report...";
            this.saveReportMenuItem.Click += new System.EventHandler(this.SaveReportMenuItem_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.MergeIndex = 1;
            this.MenuItem2.MergeAction = MergeAction.Insert;
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.MergeIndex = 2;
            this.resetMenuItem.MergeAction = MergeAction.Insert;
            this.resetMenuItem.Text = "Reset";
            this.resetMenuItem.Click += new System.EventHandler(this.ResetClick);
            // 
            // menuItem5
            // 
            this.menuItem5.MergeIndex = 3;
            this.menuItem5.MergeAction = MergeAction.Insert;
            this.menuItem5.DropDownItems.AddRange(new ToolStripMenuItem[] {
            this.mainboardMenuItem,
            this.cpuMenuItem,
            this.ramMenuItem,
            this.gpuMenuItem,
            this.fanControllerMenuItem,
            this.hddMenuItem,
            this.nicMenuItem});
            this.menuItem5.Text = "Hardware";
            // 
            // mainboardMenuItem
            // 
            this.mainboardMenuItem.MergeIndex = 0;
            this.mainboardMenuItem.MergeAction = MergeAction.Insert;
            this.mainboardMenuItem.Text = "Motherboard";
            // 
            // cpuMenuItem
            // 
            this.cpuMenuItem.MergeIndex = 1;
            this.cpuMenuItem.MergeAction = MergeAction.Insert;
            this.cpuMenuItem.Text = "CPU";
            // 
            // ramMenuItem
            // 
            this.ramMenuItem.MergeIndex = 2;
            this.ramMenuItem.MergeAction = MergeAction.Insert;
            this.ramMenuItem.Text = "RAM";
            // 
            // gpuMenuItem
            // 
            this.gpuMenuItem.MergeIndex = 3;
            this.gpuMenuItem.MergeAction = MergeAction.Insert;
            this.gpuMenuItem.Text = "GPU";
            // 
            // fanControllerMenuItem
            // 
            this.fanControllerMenuItem.MergeIndex = 4;
            this.fanControllerMenuItem.MergeAction = MergeAction.Insert;
            this.fanControllerMenuItem.Text = "Fan Controllers";
            // 
            // hddMenuItem
            // 
            this.hddMenuItem.MergeIndex = 5;
            this.hddMenuItem.MergeAction = MergeAction.Insert;
            this.hddMenuItem.Text = "Hard Disk Drives";
            // 
            // nicMenuItem
            // 
            this.nicMenuItem.MergeIndex = 6;
            this.nicMenuItem.MergeAction = MergeAction.Insert;
            this.nicMenuItem.Text = "Network";
            // 
            // menuItem6
            // 
            this.menuItem6.MergeIndex = 4;
            this.menuItem6.MergeAction = MergeAction.Insert;
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.MergeIndex = 5;
            this.exitMenuItem.MergeAction = MergeAction.Insert;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.MergeIndex = 1;
            this.viewMenuItem.MergeAction = MergeAction.Insert;
            this.viewMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.resetMinMaxMenuItem,
            this.MenuItem3,
            this.hiddenMenuItem,
            this.plotMenuItem,
            this.gadgetMenuItem,
            this.MenuItem1,
            this.columnsMenuItem});
            this.viewMenuItem.Text = "View";
            // 
            // resetMinMaxMenuItem
            // 
            this.resetMinMaxMenuItem.MergeIndex = 0;
            this.resetMinMaxMenuItem.MergeAction = MergeAction.Insert;
            this.resetMinMaxMenuItem.Text = "Reset Min/Max";
            this.resetMinMaxMenuItem.Click += new System.EventHandler(this.ResetMinMaxMenuItem_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.MergeIndex = 1;
            this.MenuItem3.MergeAction = MergeAction.Insert;
            // 
            // hiddenMenuItem
            // 
            this.hiddenMenuItem.MergeIndex = 2;
            this.hiddenMenuItem.MergeAction = MergeAction.Insert;
            this.hiddenMenuItem.Text = "Show Hidden Sensors";
            // 
            // plotMenuItem
            // 
            this.plotMenuItem.MergeIndex = 3;
            this.plotMenuItem.MergeAction = MergeAction.Insert;
            this.plotMenuItem.Text = "Show Plot";
            // 
            // gadgetMenuItem
            // 
            this.gadgetMenuItem.MergeIndex = 4;
            this.gadgetMenuItem.MergeAction = MergeAction.Insert;
            this.gadgetMenuItem.Text = "Show Gadget";
            // 
            // MenuItem1
            // 
            this.MenuItem1.MergeIndex = 5;
            this.MenuItem1.MergeAction = MergeAction.Insert;
            // 
            // columnsMenuItem
            // 
            this.columnsMenuItem.MergeIndex = 6;
            this.columnsMenuItem.MergeAction = MergeAction.Insert;
            this.columnsMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] {
            this.valueMenuItem,
            this.minMenuItem,
            this.maxMenuItem});
            this.columnsMenuItem.Text = "Columns";
            // 
            // valueMenuItem
            // 
            this.valueMenuItem.MergeIndex = 0;
            this.valueMenuItem.MergeAction = MergeAction.Insert;
            this.valueMenuItem.Text = "Value";
            // 
            // minMenuItem
            // 
            this.minMenuItem.MergeIndex = 1;
            this.minMenuItem.MergeAction = MergeAction.Insert;
            this.minMenuItem.Text = "Min";
            // 
            // maxMenuItem
            // 
            this.maxMenuItem.MergeIndex = 2;
            this.maxMenuItem.MergeAction = MergeAction.Insert;
            this.maxMenuItem.Text = "Max";
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.MergeIndex = 2;
            this.optionsMenuItem.MergeAction = MergeAction.Insert;
            this.optionsMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.startMinMenuItem,
            this.minTrayMenuItem,
            this.minCloseMenuItem,
            this.startupMenuItem,
            this.separatorMenuItem,
            this.temperatureUnitsMenuItem,
            this.plotLocationMenuItem,
            this.logSeparatorMenuItem,
            this.logSensorsMenuItem,
            this.loggingIntervalMenuItem,
            this.sensorValuesTimeWindowMenuItem,
            this.webMenuItemSeparator,
            this.webMenuItem});
            this.optionsMenuItem.Text = "Options";
            // 
            // startMinMenuItem
            // 
            this.startMinMenuItem.MergeIndex = 0;
            this.startMinMenuItem.MergeAction = MergeAction.Insert;
            this.startMinMenuItem.Text = "Start Minimized";
            // 
            // minTrayMenuItem
            // 
            this.minTrayMenuItem.MergeIndex = 1;
            this.minTrayMenuItem.MergeAction = MergeAction.Insert;
            this.minTrayMenuItem.Text = "Minimize To Tray";
            // 
            // minCloseMenuItem
            // 
            this.minCloseMenuItem.MergeIndex = 2;
            this.minCloseMenuItem.MergeAction = MergeAction.Insert;
            this.minCloseMenuItem.Text = "Minimize On Close";
            // 
            // startupMenuItem
            // 
            this.startupMenuItem.MergeIndex = 3;
            this.startupMenuItem.MergeAction = MergeAction.Insert;
            this.startupMenuItem.Text = "Run On Windows Startup";
            // 
            // separatorMenuItem
            // 
            this.separatorMenuItem.MergeIndex = 4;
            this.separatorMenuItem.MergeAction = MergeAction.Insert;
            // 
            // temperatureUnitsMenuItem
            // 
            this.temperatureUnitsMenuItem.MergeIndex = 5;
            this.temperatureUnitsMenuItem.MergeAction = MergeAction.Insert;
            this.temperatureUnitsMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] {
            this.celsiusMenuItem,
            this.fahrenheitMenuItem});
            this.temperatureUnitsMenuItem.Text = "Temperature Unit";
            // 
            // celsiusMenuItem
            // 
            this.celsiusMenuItem.MergeIndex = 0;
            this.celsiusMenuItem.MergeAction = MergeAction.Insert;
            // this.celsiusMenuItem.RadioCheck = true; // TODO
            this.celsiusMenuItem.Text = "Celsius";
            this.celsiusMenuItem.Click += new System.EventHandler(this.CelsiusMenuItem_Click);
            // 
            // fahrenheitMenuItem
            // 
            this.fahrenheitMenuItem.MergeIndex = 1;
            this.fahrenheitMenuItem.MergeAction = MergeAction.Insert;
            // this.fahrenheitMenuItem.RadioCheck = true; // TODO
            this.fahrenheitMenuItem.Text = "Fahrenheit";
            this.fahrenheitMenuItem.Click += new System.EventHandler(this.FahrenheitMenuItem_Click);
            // 
            // plotLocationMenuItem
            // 
            this.plotLocationMenuItem.MergeIndex = 6;
            this.plotLocationMenuItem.MergeAction = MergeAction.Insert;
            this.plotLocationMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] {
            this.plotWindowMenuItem,
            this.plotBottomMenuItem,
            this.plotRightMenuItem});
            this.plotLocationMenuItem.Text = "Plot Location";
            // 
            // plotWindowMenuItem
            // 
            this.plotWindowMenuItem.MergeIndex = 0;
            this.plotWindowMenuItem.MergeAction = MergeAction.Insert;
            // this.plotWindowMenuItem.RadioCheck = true; // TODO
            this.plotWindowMenuItem.Text = "Window";
            // 
            // plotBottomMenuItem
            // 
            this.plotBottomMenuItem.MergeIndex = 1;
            this.plotBottomMenuItem.MergeAction = MergeAction.Insert;
            // this.plotBottomMenuItem.RadioCheck = true; // TODO
            this.plotBottomMenuItem.Text = "Bottom";
            // 
            // plotRightMenuItem
            // 
            this.plotRightMenuItem.MergeIndex = 2;
            this.plotRightMenuItem.MergeAction = MergeAction.Insert;
            // this.plotRightMenuItem.RadioCheck = true; // TODO
            this.plotRightMenuItem.Text = "Right";
            // 
            // logSeparatorMenuItem
            // 
            this.logSeparatorMenuItem.MergeIndex = 7;
            this.logSeparatorMenuItem.MergeAction = MergeAction.Insert;
            // 
            // logSensorsMenuItem
            // 
            this.logSensorsMenuItem.MergeIndex = 8;
            this.logSensorsMenuItem.MergeAction = MergeAction.Insert;
            this.logSensorsMenuItem.Text = "Log Sensors";
            // 
            // loggingIntervalMenuItem
            // 
            this.loggingIntervalMenuItem.MergeIndex = 9;
            this.loggingIntervalMenuItem.MergeAction = MergeAction.Insert;
            this.loggingIntervalMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] {
            this.log1sMenuItem,
            this.log2sMenuItem,
            this.log5sMenuItem,
            this.log10sMenuItem,
            this.log30sMenuItem,
            this.log1minMenuItem,
            this.log2minMenuItem,
            this.log5minMenuItem,
            this.log10minMenuItem,
            this.log30minMenuItem,
            this.log1hMenuItem,
            this.log2hMenuItem,
            this.log6hMenuItem});
            this.loggingIntervalMenuItem.Text = "Logging Interval";
            // 
            // log1sMenuItem
            // 
            this.log1sMenuItem.MergeIndex = 0;
            this.log1sMenuItem.MergeAction = MergeAction.Insert;
            // this.log1sMenuItem.RadioCheck = true; // TODO
            this.log1sMenuItem.Text = "1s";
            // 
            // log2sMenuItem
            // 
            this.log2sMenuItem.MergeIndex = 1;
            this.log2sMenuItem.MergeAction = MergeAction.Insert;
            // this.log2sMenuItem.RadioCheck = true; // TODO
            this.log2sMenuItem.Text = "2s";
            // 
            // log5sMenuItem
            // 
            this.log5sMenuItem.MergeIndex = 2;
            this.log5sMenuItem.MergeAction = MergeAction.Insert;
            // this.log5sMenuItem.RadioCheck = true; // TODO
            this.log5sMenuItem.Text = "5s";
            // 
            // log10sMenuItem
            // 
            this.log10sMenuItem.MergeIndex = 3;
            this.log10sMenuItem.MergeAction = MergeAction.Insert;
            // this.log10sMenuItem.RadioCheck = true; // TODO
            this.log10sMenuItem.Text = "10s";
            // 
            // log30sMenuItem
            // 
            this.log30sMenuItem.MergeIndex = 4;
            this.log30sMenuItem.MergeAction = MergeAction.Insert;
            // this.log30sMenuItem.RadioCheck = true; // TODO
            this.log30sMenuItem.Text = "30s";
            // 
            // log1minMenuItem
            // 
            this.log1minMenuItem.MergeIndex = 5;
            this.log1minMenuItem.MergeAction = MergeAction.Insert;
            // this.log1minMenuItem.RadioCheck = true; // TODO
            this.log1minMenuItem.Text = "1min";
            // 
            // log2minMenuItem
            // 
            this.log2minMenuItem.MergeIndex = 6;
            this.log2minMenuItem.MergeAction = MergeAction.Insert;
            // this.log2minMenuItem.RadioCheck = true; // TODO
            this.log2minMenuItem.Text = "2min";
            // 
            // log5minMenuItem
            // 
            this.log5minMenuItem.MergeIndex = 7;
            this.log5minMenuItem.MergeAction = MergeAction.Insert;
            // this.log5minMenuItem.RadioCheck = true; // TODO
            this.log5minMenuItem.Text = "5min";
            // 
            // log10minMenuItem
            // 
            this.log10minMenuItem.MergeIndex = 8;
            this.log10minMenuItem.MergeAction = MergeAction.Insert;
            // this.log10minMenuItem.RadioCheck = true; // TODO
            this.log10minMenuItem.Text = "10min";
            // 
            // log30minMenuItem
            // 
            this.log30minMenuItem.MergeIndex = 9;
            this.log30minMenuItem.MergeAction = MergeAction.Insert;
            // this.log30minMenuItem.RadioCheck = true; // TODO
            this.log30minMenuItem.Text = "30min";
            // 
            // log1hMenuItem
            // 
            this.log1hMenuItem.MergeIndex = 10;
            this.log1hMenuItem.MergeAction = MergeAction.Insert;
            // this.log1hMenuItem.RadioCheck = true; // TODO
            this.log1hMenuItem.Text = "1h";
            // 
            // log2hMenuItem
            // 
            this.log2hMenuItem.MergeIndex = 11;
            this.log2hMenuItem.MergeAction = MergeAction.Insert;
            // this.log2hMenuItem.RadioCheck = true; // TODO
            this.log2hMenuItem.Text = "2h";
            // 
            // log6hMenuItem
            // 
            this.log6hMenuItem.MergeIndex = 12;
            this.log6hMenuItem.MergeAction = MergeAction.Insert;
            // this.log6hMenuItem.RadioCheck = true; // TODO
            this.log6hMenuItem.Text = "6h";
            // 
            // sensorValuesTimeWindowMenuItem
            // 
            this.sensorValuesTimeWindowMenuItem.MergeIndex = 10;
            this.sensorValuesTimeWindowMenuItem.MergeAction = MergeAction.Insert;
            this.sensorValuesTimeWindowMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] {
            this.timeWindow30sMenuItem,
            this.timeWindow1minMenuItem,
            this.timeWindow2minMenuItem,
            this.timeWindow5minMenuItem,
            this.timeWindow10minMenuItem,
            this.timeWindow30minMenuItem,
            this.timeWindow1hMenuItem,
            this.timeWindow2hMenuItem,
            this.timeWindow6hMenuItem,
            this.timeWindow12hMenuItem,
            this.timeWindow24hMenuItem});
            this.sensorValuesTimeWindowMenuItem.Text = "Sensor Values Time Window";
            // 
            // timeWindow30sMenuItem
            // 
            this.timeWindow30sMenuItem.MergeIndex = 0;
            this.timeWindow30sMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow30sMenuItem.RadioCheck = true; // TODO
            this.timeWindow30sMenuItem.Text = "30s";
            // 
            // timeWindow1minMenuItem
            // 
            this.timeWindow1minMenuItem.MergeIndex = 1;
            this.timeWindow1minMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow1minMenuItem.RadioCheck = true; // TODO
            this.timeWindow1minMenuItem.Text = "1min";
            // 
            // timeWindow2minMenuItem
            // 
            this.timeWindow2minMenuItem.MergeIndex = 2;
            this.timeWindow2minMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow2minMenuItem.RadioCheck = true; // TODO
            this.timeWindow2minMenuItem.Text = "2min";
            // 
            // timeWindow5minMenuItem
            // 
            this.timeWindow5minMenuItem.MergeIndex = 3;
            this.timeWindow5minMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow5minMenuItem.RadioCheck = true; // TODO
            this.timeWindow5minMenuItem.Text = "5min";
            // 
            // timeWindow10minMenuItem
            // 
            this.timeWindow10minMenuItem.MergeIndex = 4;
            this.timeWindow10minMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow10minMenuItem.RadioCheck = true; // TODO
            this.timeWindow10minMenuItem.Text = "10min";
            // 
            // timeWindow30minMenuItem
            // 
            this.timeWindow30minMenuItem.MergeIndex = 5;
            this.timeWindow30minMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow30minMenuItem.RadioCheck = true; // TODO
            this.timeWindow30minMenuItem.Text = "30min";
            // 
            // timeWindow1hMenuItem
            // 
            this.timeWindow1hMenuItem.MergeIndex = 6;
            this.timeWindow1hMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow1hMenuItem.RadioCheck = true; // TODO
            this.timeWindow1hMenuItem.Text = "1h";
            // 
            // timeWindow2hMenuItem
            // 
            this.timeWindow2hMenuItem.MergeIndex = 7;
            this.timeWindow2hMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow2hMenuItem.RadioCheck = true; // TODO
            this.timeWindow2hMenuItem.Text = "2n";
            // 
            // timeWindow6hMenuItem
            // 
            this.timeWindow6hMenuItem.MergeIndex = 8;
            this.timeWindow6hMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow6hMenuItem.RadioCheck = true; // TODO
            this.timeWindow6hMenuItem.Text = "6h";
            // 
            // timeWindow12hMenuItem
            // 
            this.timeWindow12hMenuItem.MergeIndex = 9;
            this.timeWindow12hMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow12hMenuItem.RadioCheck = true; // TODO
            this.timeWindow12hMenuItem.Text = "12h";
            // 
            // timeWindow24hMenuItem
            // 
            this.timeWindow24hMenuItem.MergeIndex = 10;
            this.timeWindow24hMenuItem.MergeAction = MergeAction.Insert;
            // this.timeWindow24hMenuItem.RadioCheck = true; // TODO
            this.timeWindow24hMenuItem.Text = "24h";
            // 
            // webMenuItemSeparator
            // 
            this.webMenuItemSeparator.MergeIndex = 11;
            this.webMenuItemSeparator.MergeAction = MergeAction.Insert;
            // 
            // webMenuItem
            // 
            this.webMenuItem.MergeIndex = 12;
            this.webMenuItem.MergeAction = MergeAction.Insert; // TODO
            this.webMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] {
            this.runWebServerMenuItem,
            this.serverPortMenuItem,
            this.authWebServerMenuItem});
            this.webMenuItem.Text = "Remote Web Server";
            // 
            // runWebServerMenuItem
            // 
            this.runWebServerMenuItem.MergeIndex = 0;
            this.runWebServerMenuItem.MergeAction = MergeAction.Insert; // TODO
            this.runWebServerMenuItem.Text = "Run";
            // 
            // serverPortMenuItem
            // 
            this.serverPortMenuItem.MergeIndex = 1;
            this.serverPortMenuItem.MergeAction = MergeAction.Insert; // TODO
            this.serverPortMenuItem.Text = "Port";
            this.serverPortMenuItem.Click += new System.EventHandler(this.ServerPortMenuItem_Click);
            // 
            // authWebServerMenuItem
            // 
            this.authWebServerMenuItem.MergeIndex = 2;
            this.authWebServerMenuItem.MergeAction = MergeAction.Insert; // TODO
            this.authWebServerMenuItem.Text = "Authentication";
            this.authWebServerMenuItem.Click += new System.EventHandler(this.AuthWebServerMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.MergeIndex = 3;
            this.helpMenuItem.MergeAction = MergeAction.Insert; // TODO
            this.helpMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.MergeIndex = 0;
            this.aboutMenuItem.MergeAction = MergeAction.Insert; // TODO
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "LibreHardwareMonitor.Report.txt";
            this.saveFileDialog.Filter = "Text Documents|*.txt|All Files|*.*";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save Report As";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // splitContainer
            // 
            this.splitContainer.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.splitContainer.Color = System.Drawing.SystemColors.Control;
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Size = new System.Drawing.Size(386, 483);
            this.splitContainer.SplitterDistance = 354;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 3;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Columns.Add(this.sensor);
            this.treeView.Columns.Add(this.value);
            this.treeView.Columns.Add(this.min);
            this.treeView.Columns.Add(this.max);
            this.treeView.DefaultToolTipProvider = null;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeView.FullRowSelect = true;
            this.treeView.GridLineStyle = Aga.Controls.Tree.GridLineStyle.Horizontal;
            this.treeView.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Model = null;
            this.treeView.Name = "treeView";
            this.treeView.NodeControls.Add(this.nodeImage);
            this.treeView.NodeControls.Add(this.nodeCheckBox);
            this.treeView.NodeControls.Add(this.nodeTextBoxText);
            this.treeView.NodeControls.Add(this.nodeTextBoxValue);
            this.treeView.NodeControls.Add(this.nodeTextBoxMin);
            this.treeView.NodeControls.Add(this.nodeTextBoxMax);
            this.treeView.SelectedNode = null;
            this.treeView.Size = new System.Drawing.Size(386, 354);
            this.treeView.TabIndex = 0;
            this.treeView.Text = "treeView";
            this.treeView.UseColumns = true;
            this.treeView.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.TreeView_NodeMouseDoubleClick);
            this.treeView.Click += new System.EventHandler(this.TreeView_Click);
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            this.treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseMove);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 533);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            // this.Menu = this.mainMenu; // TODO
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Libre Hardware Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_MoveOrResize);
            this.Move += new System.EventHandler(this.MainForm_MoveOrResize);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv treeView;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private Aga.Controls.Tree.TreeColumn sensor;
        private Aga.Controls.Tree.TreeColumn value;
        private Aga.Controls.Tree.TreeColumn min;
        private Aga.Controls.Tree.TreeColumn max;
        private Aga.Controls.Tree.NodeControls.NodeIcon nodeImage;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxText;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxValue;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMin;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMax;
        private SplitContainerAdv splitContainer;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotMenuItem;
        private Aga.Controls.Tree.NodeControls.NodeCheckBox nodeCheckBox;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorMenuItem;
        private System.Windows.Forms.ContextMenuStrip treeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem startMinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem hiddenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem columnsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureUnitsMenuItem;
        private System.Windows.Forms.ToolStripSeparator webMenuItemSeparator;
        private System.Windows.Forms.ToolStripMenuItem celsiusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fahrenheitMenuItem;
        private System.Windows.Forms.ToolStripSeparator MenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetMinMaxMenuItem;
        private System.Windows.Forms.ToolStripSeparator MenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gadgetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minCloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuItem6;
        private System.Windows.Forms.ToolStripMenuItem plotLocationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotBottomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotRightMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runWebServerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverPortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem5;
        private System.Windows.Forms.ToolStripMenuItem mainboardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cpuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gpuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fanControllerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logSensorsMenuItem;
        private System.Windows.Forms.ToolStripSeparator logSeparatorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggingIntervalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log1sMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log2sMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log5sMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log10sMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log30sMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log1minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log2minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log5minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log10minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log30minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log1hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log2hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log6hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorValuesTimeWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow30sMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow1minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow2minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow5minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow10minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow30minMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow1hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow2hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow6hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow12hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWindow24hMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authWebServerMenuItem;
    }
}

