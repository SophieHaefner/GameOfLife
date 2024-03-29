﻿
namespace GameOfLife
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripImportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripQuitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripShowHudMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripShowNeighborCountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripShowGridMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripShowHelpersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripGenerationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripLiveStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripTotalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripOptionsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPlayButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPauseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripNextButton = new System.Windows.Forms.ToolStripButton();
            this.graphicsPanel = new GameOfLife.GraphicsPanel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuPlayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuPauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuNextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDisplaySeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuFillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuShowHudMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuShowNeighborCountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuShowGridMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuShowHelpersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hudPanel = new System.Windows.Forms.Panel();
            this.hudTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.hudScaleValueLabel = new System.Windows.Forms.Label();
            this.hudBorderValueLabel = new System.Windows.Forms.Label();
            this.hudSeedValueLabel = new System.Windows.Forms.Label();
            this.hudIntervalValueLabel = new System.Windows.Forms.Label();
            this.hudScaleNameLabel = new System.Windows.Forms.Label();
            this.hudBorderNameLabel = new System.Windows.Forms.Label();
            this.hudSeedNameLabel = new System.Windows.Forms.Label();
            this.hudIntervalNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.graphicsPanel.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.hudPanel.SuspendLayout();
            this.hudTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.toolStrip, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.graphicsPanel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(944, 501);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFileMenu,
            this.menuStripToolsMenu,
            this.menuStripViewMenu,
            this.menuStripHelpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(944, 20);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuStripFileMenu
            // 
            this.menuStripFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNewMenuItem,
            this.menuStripOpenMenuItem,
            this.menuStripFileMenuSeparator1,
            this.menuStripSaveMenuItem,
            this.menuStripSaveAsMenuItem,
            this.menuStripImportMenuItem,
            this.menuStripFileMenuSeparator2,
            this.menuStripQuitMenuItem});
            this.menuStripFileMenu.ForeColor = System.Drawing.Color.Black;
            this.menuStripFileMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuStripFileMenu.Name = "menuStripFileMenu";
            this.menuStripFileMenu.Size = new System.Drawing.Size(45, 14);
            this.menuStripFileMenu.Text = "&File";
            // 
            // menuStripNewMenuItem
            // 
            this.menuStripNewMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripNewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripNewMenuItem.Name = "menuStripNewMenuItem";
            this.menuStripNewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStripNewMenuItem.Size = new System.Drawing.Size(208, 22);
            this.menuStripNewMenuItem.Text = "&New";
            this.menuStripNewMenuItem.Click += new System.EventHandler(this.menuStripNewMenuItem_Click);
            // 
            // menuStripOpenMenuItem
            // 
            this.menuStripOpenMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripOpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripOpenMenuItem.Name = "menuStripOpenMenuItem";
            this.menuStripOpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuStripOpenMenuItem.Size = new System.Drawing.Size(208, 22);
            this.menuStripOpenMenuItem.Text = "&Open";
            this.menuStripOpenMenuItem.Click += new System.EventHandler(this.menuStripOpenMenuItem_Click);
            // 
            // menuStripFileMenuSeparator1
            // 
            this.menuStripFileMenuSeparator1.Name = "menuStripFileMenuSeparator1";
            this.menuStripFileMenuSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // menuStripSaveMenuItem
            // 
            this.menuStripSaveMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripSaveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripSaveMenuItem.Name = "menuStripSaveMenuItem";
            this.menuStripSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuStripSaveMenuItem.Size = new System.Drawing.Size(208, 22);
            this.menuStripSaveMenuItem.Text = "&Save";
            this.menuStripSaveMenuItem.Click += new System.EventHandler(this.menuStripSaveMenuItem_Click);
            // 
            // menuStripSaveAsMenuItem
            // 
            this.menuStripSaveAsMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripSaveAsMenuItem.Name = "menuStripSaveAsMenuItem";
            this.menuStripSaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuStripSaveAsMenuItem.Size = new System.Drawing.Size(208, 22);
            this.menuStripSaveAsMenuItem.Text = "Save &As";
            this.menuStripSaveAsMenuItem.Click += new System.EventHandler(this.menuStripSaveAsMenuItem_Click);
            // 
            // menuStripImportMenuItem
            // 
            this.menuStripImportMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripImportMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripImportMenuItem.Name = "menuStripImportMenuItem";
            this.menuStripImportMenuItem.Size = new System.Drawing.Size(208, 22);
            this.menuStripImportMenuItem.Text = "&Import";
            this.menuStripImportMenuItem.Click += new System.EventHandler(this.menuStripImportMenuItem_Click);
            // 
            // menuStripFileMenuSeparator2
            // 
            this.menuStripFileMenuSeparator2.Name = "menuStripFileMenuSeparator2";
            this.menuStripFileMenuSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // menuStripQuitMenuItem
            // 
            this.menuStripQuitMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripQuitMenuItem.Name = "menuStripQuitMenuItem";
            this.menuStripQuitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuStripQuitMenuItem.Size = new System.Drawing.Size(208, 22);
            this.menuStripQuitMenuItem.Text = "&Quit";
            this.menuStripQuitMenuItem.Click += new System.EventHandler(this.menuStripQuitMenuItem_Click);
            // 
            // menuStripToolsMenu
            // 
            this.menuStripToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripOptionsMenuItem,
            this.menuStripClearMenuItem,
            this.menuStripFillMenuItem});
            this.menuStripToolsMenu.ForeColor = System.Drawing.Color.Black;
            this.menuStripToolsMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuStripToolsMenu.Name = "menuStripToolsMenu";
            this.menuStripToolsMenu.Size = new System.Drawing.Size(52, 14);
            this.menuStripToolsMenu.Text = "&Tools";
            // 
            // menuStripOptionsMenuItem
            // 
            this.menuStripOptionsMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripOptionsMenuItem.Name = "menuStripOptionsMenuItem";
            this.menuStripOptionsMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.menuStripOptionsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuStripOptionsMenuItem.Text = "Options";
            this.menuStripOptionsMenuItem.Click += new System.EventHandler(this.menuStripOptionsMenuItem_Click);
            // 
            // menuStripClearMenuItem
            // 
            this.menuStripClearMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripClearMenuItem.Name = "menuStripClearMenuItem";
            this.menuStripClearMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuStripClearMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuStripClearMenuItem.Text = "Clear";
            this.menuStripClearMenuItem.Click += new System.EventHandler(this.menuStripClearMenuItem_Click);
            // 
            // menuStripFillMenuItem
            // 
            this.menuStripFillMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripFillMenuItem.Name = "menuStripFillMenuItem";
            this.menuStripFillMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuStripFillMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuStripFillMenuItem.Text = "Fill";
            this.menuStripFillMenuItem.Click += new System.EventHandler(this.menuStripFillMenuItem_Click);
            // 
            // menuStripViewMenu
            // 
            this.menuStripViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripShowHudMenuItem,
            this.menuStripShowNeighborCountMenuItem,
            this.menuStripShowGridMenuItem,
            this.menuStripShowHelpersMenuItem});
            this.menuStripViewMenu.ForeColor = System.Drawing.Color.Black;
            this.menuStripViewMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuStripViewMenu.Name = "menuStripViewMenu";
            this.menuStripViewMenu.Size = new System.Drawing.Size(45, 14);
            this.menuStripViewMenu.Text = "&View";
            this.menuStripViewMenu.DropDownOpened += new System.EventHandler(this.menuStripViewMenu_DropDownOpened);
            // 
            // menuStripShowHudMenuItem
            // 
            this.menuStripShowHudMenuItem.Checked = true;
            this.menuStripShowHudMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuStripShowHudMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripShowHudMenuItem.Name = "menuStripShowHudMenuItem";
            this.menuStripShowHudMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuStripShowHudMenuItem.Size = new System.Drawing.Size(222, 22);
            this.menuStripShowHudMenuItem.Text = "Show HUD";
            this.menuStripShowHudMenuItem.Click += new System.EventHandler(this.menuStripShowHudMenuItem_Click);
            // 
            // menuStripShowNeighborCountMenuItem
            // 
            this.menuStripShowNeighborCountMenuItem.Checked = true;
            this.menuStripShowNeighborCountMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuStripShowNeighborCountMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripShowNeighborCountMenuItem.Name = "menuStripShowNeighborCountMenuItem";
            this.menuStripShowNeighborCountMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuStripShowNeighborCountMenuItem.Size = new System.Drawing.Size(222, 22);
            this.menuStripShowNeighborCountMenuItem.Text = "Show Neighbor Count";
            this.menuStripShowNeighborCountMenuItem.Click += new System.EventHandler(this.menuStripShowNeighborCountMenuItem_Click);
            // 
            // menuStripShowGridMenuItem
            // 
            this.menuStripShowGridMenuItem.Checked = true;
            this.menuStripShowGridMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuStripShowGridMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripShowGridMenuItem.Name = "menuStripShowGridMenuItem";
            this.menuStripShowGridMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuStripShowGridMenuItem.Size = new System.Drawing.Size(222, 22);
            this.menuStripShowGridMenuItem.Text = "Show Grid";
            this.menuStripShowGridMenuItem.Click += new System.EventHandler(this.menuStripShowGridMenuItem_Click);
            // 
            // menuStripShowHelpersMenuItem
            // 
            this.menuStripShowHelpersMenuItem.Name = "menuStripShowHelpersMenuItem";
            this.menuStripShowHelpersMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuStripShowHelpersMenuItem.Size = new System.Drawing.Size(222, 22);
            this.menuStripShowHelpersMenuItem.Text = "Show Helpers";
            this.menuStripShowHelpersMenuItem.Click += new System.EventHandler(this.menuStripShowHelpersMenuItem_Click);
            // 
            // menuStripHelpMenu
            // 
            this.menuStripHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripAboutMenuItem});
            this.menuStripHelpMenu.ForeColor = System.Drawing.Color.Black;
            this.menuStripHelpMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuStripHelpMenu.Name = "menuStripHelpMenu";
            this.menuStripHelpMenu.Size = new System.Drawing.Size(45, 14);
            this.menuStripHelpMenu.Text = "&Help";
            // 
            // menuStripAboutMenuItem
            // 
            this.menuStripAboutMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuStripAboutMenuItem.Name = "menuStripAboutMenuItem";
            this.menuStripAboutMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.menuStripAboutMenuItem.Size = new System.Drawing.Size(131, 22);
            this.menuStripAboutMenuItem.Text = "About";
            this.menuStripAboutMenuItem.Click += new System.EventHandler(this.menuStripAboutMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripGenerationStatusLabel,
            this.statusStripSeparator1,
            this.statusStripLiveStatusLabel,
            this.statusStripSeparator2,
            this.statusStripTotalStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 481);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(944, 20);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStripGenerationStatusLabel
            // 
            this.statusStripGenerationStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusStripGenerationStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.statusStripGenerationStatusLabel.Name = "statusStripGenerationStatusLabel";
            this.statusStripGenerationStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusStripGenerationStatusLabel.Size = new System.Drawing.Size(104, 18);
            this.statusStripGenerationStatusLabel.Text = "Generation: 0";
            // 
            // statusStripSeparator1
            // 
            this.statusStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.statusStripSeparator1.Name = "statusStripSeparator1";
            this.statusStripSeparator1.Size = new System.Drawing.Size(6, 16);
            // 
            // statusStripLiveStatusLabel
            // 
            this.statusStripLiveStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusStripLiveStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.statusStripLiveStatusLabel.Name = "statusStripLiveStatusLabel";
            this.statusStripLiveStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusStripLiveStatusLabel.Size = new System.Drawing.Size(62, 18);
            this.statusStripLiveStatusLabel.Text = "Live: 0";
            // 
            // statusStripSeparator2
            // 
            this.statusStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.statusStripSeparator2.Name = "statusStripSeparator2";
            this.statusStripSeparator2.Size = new System.Drawing.Size(6, 16);
            // 
            // statusStripTotalStatusLabel
            // 
            this.statusStripTotalStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusStripTotalStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.statusStripTotalStatusLabel.Name = "statusStripTotalStatusLabel";
            this.statusStripTotalStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusStripTotalStatusLabel.Size = new System.Drawing.Size(69, 18);
            this.statusStripTotalStatusLabel.Text = "Total: 0";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOptionsButton,
            this.toolStripSeparator1,
            this.toolStripNewButton,
            this.toolStripSaveButton,
            this.toolStripSeparator2,
            this.toolStripPlayButton,
            this.toolStripPauseButton,
            this.toolStripNextButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 20);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(944, 50);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripOptionsButton
            // 
            this.toolStripOptionsButton.AutoSize = false;
            this.toolStripOptionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOptionsButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOptionsButton.Image")));
            this.toolStripOptionsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOptionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOptionsButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripOptionsButton.Name = "toolStripOptionsButton";
            this.toolStripOptionsButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripOptionsButton.Text = "Options";
            this.toolStripOptionsButton.Click += new System.EventHandler(this.toolStripOptionsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripNewButton
            // 
            this.toolStripNewButton.AutoSize = false;
            this.toolStripNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewButton.Image")));
            this.toolStripNewButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripNewButton.Name = "toolStripNewButton";
            this.toolStripNewButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripNewButton.Text = "New";
            this.toolStripNewButton.Click += new System.EventHandler(this.toolStripNewButton_Click);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.AutoSize = false;
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
            this.toolStripSaveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripSaveButton.Text = "Save";
            this.toolStripSaveButton.Click += new System.EventHandler(this.toolStripSaveButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripPlayButton
            // 
            this.toolStripPlayButton.AutoSize = false;
            this.toolStripPlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlayButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlayButton.Image")));
            this.toolStripPlayButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlayButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripPlayButton.Name = "toolStripPlayButton";
            this.toolStripPlayButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripPlayButton.Text = "Play";
            this.toolStripPlayButton.Click += new System.EventHandler(this.toolStripPlayButton_Click);
            // 
            // toolStripPauseButton
            // 
            this.toolStripPauseButton.AutoSize = false;
            this.toolStripPauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPauseButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPauseButton.Image")));
            this.toolStripPauseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPauseButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripPauseButton.Name = "toolStripPauseButton";
            this.toolStripPauseButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripPauseButton.Text = "Pause";
            this.toolStripPauseButton.Click += new System.EventHandler(this.toolStripPauseButton_Click);
            // 
            // toolStripNextButton
            // 
            this.toolStripNextButton.AutoSize = false;
            this.toolStripNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNextButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNextButton.Image")));
            this.toolStripNextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNextButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripNextButton.Name = "toolStripNextButton";
            this.toolStripNextButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripNextButton.Text = "Next";
            this.toolStripNextButton.Click += new System.EventHandler(this.toolStripNextButton_Click);
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.graphicsPanel.ContextMenuStrip = this.contextMenu;
            this.graphicsPanel.Controls.Add(this.hudPanel);
            this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel.Location = new System.Drawing.Point(0, 70);
            this.graphicsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(944, 411);
            this.graphicsPanel.TabIndex = 3;
            this.graphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel_Paint);
            this.graphicsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuPlayMenuItem,
            this.contextMenuPauseMenuItem,
            this.contextMenuNextMenuItem,
            this.contextMenuDisplaySeparator1,
            this.contextMenuOptionsMenuItem,
            this.contextMenuClearMenuItem,
            this.contextMenuFillMenuItem,
            this.toolStripSeparator3,
            this.contextMenuShowHudMenuItem,
            this.contextMenuShowNeighborCountMenuItem,
            this.contextMenuShowGridMenuItem,
            this.contextMenuShowHelpersMenuItem});
            this.contextMenu.Name = "contextMenuStrip";
            this.contextMenu.Size = new System.Drawing.Size(206, 258);
            this.contextMenu.Opened += new System.EventHandler(this.contextMenu_Opened);
            // 
            // contextMenuPlayMenuItem
            // 
            this.contextMenuPlayMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuPlayMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuPlayMenuItem.Name = "contextMenuPlayMenuItem";
            this.contextMenuPlayMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuPlayMenuItem.Text = "Play";
            this.contextMenuPlayMenuItem.Click += new System.EventHandler(this.contextMenuPlayMenuItem_Click);
            // 
            // contextMenuPauseMenuItem
            // 
            this.contextMenuPauseMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuPauseMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuPauseMenuItem.Name = "contextMenuPauseMenuItem";
            this.contextMenuPauseMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuPauseMenuItem.Text = "Pause";
            this.contextMenuPauseMenuItem.Click += new System.EventHandler(this.contextMenuPauseMenuItem_Click);
            // 
            // contextMenuNextMenuItem
            // 
            this.contextMenuNextMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuNextMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuNextMenuItem.Name = "contextMenuNextMenuItem";
            this.contextMenuNextMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuNextMenuItem.Text = "Next";
            this.contextMenuNextMenuItem.Click += new System.EventHandler(this.contextMenuNextMenuItem_Click);
            // 
            // contextMenuDisplaySeparator1
            // 
            this.contextMenuDisplaySeparator1.Name = "contextMenuDisplaySeparator1";
            this.contextMenuDisplaySeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // contextMenuOptionsMenuItem
            // 
            this.contextMenuOptionsMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuOptionsMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuOptionsMenuItem.Name = "contextMenuOptionsMenuItem";
            this.contextMenuOptionsMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuOptionsMenuItem.Text = "Options";
            this.contextMenuOptionsMenuItem.Click += new System.EventHandler(this.contextMenuOptionsMenuItem_Click);
            // 
            // contextMenuClearMenuItem
            // 
            this.contextMenuClearMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuClearMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuClearMenuItem.Name = "contextMenuClearMenuItem";
            this.contextMenuClearMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuClearMenuItem.Text = "Clear";
            this.contextMenuClearMenuItem.Click += new System.EventHandler(this.contextMenuClearMenuItem_Click);
            // 
            // contextMenuFillMenuItem
            // 
            this.contextMenuFillMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuFillMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuFillMenuItem.Name = "contextMenuFillMenuItem";
            this.contextMenuFillMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuFillMenuItem.Text = "Fill";
            this.contextMenuFillMenuItem.Click += new System.EventHandler(this.contextMenuFillMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // contextMenuShowHudMenuItem
            // 
            this.contextMenuShowHudMenuItem.Checked = true;
            this.contextMenuShowHudMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextMenuShowHudMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuShowHudMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuShowHudMenuItem.Name = "contextMenuShowHudMenuItem";
            this.contextMenuShowHudMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuShowHudMenuItem.Text = "Show HUD";
            this.contextMenuShowHudMenuItem.Click += new System.EventHandler(this.contextMenuShowHudMenuItem_Click);
            // 
            // contextMenuShowNeighborCountMenuItem
            // 
            this.contextMenuShowNeighborCountMenuItem.Checked = true;
            this.contextMenuShowNeighborCountMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextMenuShowNeighborCountMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuShowNeighborCountMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuShowNeighborCountMenuItem.Name = "contextMenuShowNeighborCountMenuItem";
            this.contextMenuShowNeighborCountMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuShowNeighborCountMenuItem.Text = "Show Neighbor Count";
            this.contextMenuShowNeighborCountMenuItem.Click += new System.EventHandler(this.contextMenuShowNeighborCountMenuItem_Click);
            // 
            // contextMenuShowGridMenuItem
            // 
            this.contextMenuShowGridMenuItem.Checked = true;
            this.contextMenuShowGridMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextMenuShowGridMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.contextMenuShowGridMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contextMenuShowGridMenuItem.Name = "contextMenuShowGridMenuItem";
            this.contextMenuShowGridMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuShowGridMenuItem.Text = "Show Grid";
            this.contextMenuShowGridMenuItem.Click += new System.EventHandler(this.contextMenuShowGridMenuItem_Click);
            // 
            // contextMenuShowHelpersMenuItem
            // 
            this.contextMenuShowHelpersMenuItem.Name = "contextMenuShowHelpersMenuItem";
            this.contextMenuShowHelpersMenuItem.Size = new System.Drawing.Size(205, 22);
            this.contextMenuShowHelpersMenuItem.Text = "Show Helpers";
            this.contextMenuShowHelpersMenuItem.Click += new System.EventHandler(this.contextMenuShowHelpersMenuItem_Click);
            // 
            // hudPanel
            // 
            this.hudPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudPanel.AutoSize = true;
            this.hudPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hudPanel.BackColor = System.Drawing.Color.Black;
            this.hudPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hudPanel.BackgroundImage")));
            this.hudPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hudPanel.Controls.Add(this.hudTableLayout);
            this.hudPanel.Location = new System.Drawing.Point(0, 319);
            this.hudPanel.Margin = new System.Windows.Forms.Padding(0);
            this.hudPanel.Name = "hudPanel";
            this.hudPanel.Padding = new System.Windows.Forms.Padding(2);
            this.hudPanel.Size = new System.Drawing.Size(174, 92);
            this.hudPanel.TabIndex = 0;
            // 
            // hudTableLayout
            // 
            this.hudTableLayout.AutoSize = true;
            this.hudTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hudTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudTableLayout.ColumnCount = 2;
            this.hudTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.hudTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.hudTableLayout.Controls.Add(this.hudScaleValueLabel, 1, 3);
            this.hudTableLayout.Controls.Add(this.hudBorderValueLabel, 1, 2);
            this.hudTableLayout.Controls.Add(this.hudSeedValueLabel, 1, 1);
            this.hudTableLayout.Controls.Add(this.hudIntervalValueLabel, 1, 0);
            this.hudTableLayout.Controls.Add(this.hudScaleNameLabel, 0, 3);
            this.hudTableLayout.Controls.Add(this.hudBorderNameLabel, 0, 2);
            this.hudTableLayout.Controls.Add(this.hudSeedNameLabel, 0, 1);
            this.hudTableLayout.Controls.Add(this.hudIntervalNameLabel, 0, 0);
            this.hudTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hudTableLayout.Location = new System.Drawing.Point(2, 2);
            this.hudTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.hudTableLayout.Name = "hudTableLayout";
            this.hudTableLayout.RowCount = 4;
            this.hudTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hudTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hudTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hudTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hudTableLayout.Size = new System.Drawing.Size(170, 88);
            this.hudTableLayout.TabIndex = 1;
            // 
            // hudScaleValueLabel
            // 
            this.hudScaleValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudScaleValueLabel.AutoSize = true;
            this.hudScaleValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudScaleValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudScaleValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudScaleValueLabel.Location = new System.Drawing.Point(90, 66);
            this.hudScaleValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudScaleValueLabel.Name = "hudScaleValueLabel";
            this.hudScaleValueLabel.Size = new System.Drawing.Size(80, 22);
            this.hudScaleValueLabel.TabIndex = 8;
            this.hudScaleValueLabel.Text = "64 x 32";
            // 
            // hudBorderValueLabel
            // 
            this.hudBorderValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudBorderValueLabel.AutoSize = true;
            this.hudBorderValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudBorderValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudBorderValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudBorderValueLabel.Location = new System.Drawing.Point(90, 44);
            this.hudBorderValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudBorderValueLabel.Name = "hudBorderValueLabel";
            this.hudBorderValueLabel.Size = new System.Drawing.Size(50, 22);
            this.hudBorderValueLabel.TabIndex = 7;
            this.hudBorderValueLabel.Text = "Wrap";
            // 
            // hudSeedValueLabel
            // 
            this.hudSeedValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudSeedValueLabel.AutoSize = true;
            this.hudSeedValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudSeedValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudSeedValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudSeedValueLabel.Location = new System.Drawing.Point(90, 22);
            this.hudSeedValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudSeedValueLabel.Name = "hudSeedValueLabel";
            this.hudSeedValueLabel.Size = new System.Drawing.Size(50, 22);
            this.hudSeedValueLabel.TabIndex = 6;
            this.hudSeedValueLabel.Text = "2000";
            // 
            // hudIntervalValueLabel
            // 
            this.hudIntervalValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudIntervalValueLabel.AutoSize = true;
            this.hudIntervalValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudIntervalValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudIntervalValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudIntervalValueLabel.Location = new System.Drawing.Point(90, 0);
            this.hudIntervalValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudIntervalValueLabel.Name = "hudIntervalValueLabel";
            this.hudIntervalValueLabel.Size = new System.Drawing.Size(30, 22);
            this.hudIntervalValueLabel.TabIndex = 5;
            this.hudIntervalValueLabel.Text = "20";
            // 
            // hudScaleNameLabel
            // 
            this.hudScaleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudScaleNameLabel.AutoSize = true;
            this.hudScaleNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudScaleNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudScaleNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudScaleNameLabel.Location = new System.Drawing.Point(0, 66);
            this.hudScaleNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudScaleNameLabel.Name = "hudScaleNameLabel";
            this.hudScaleNameLabel.Size = new System.Drawing.Size(60, 22);
            this.hudScaleNameLabel.TabIndex = 5;
            this.hudScaleNameLabel.Text = "Scale";
            // 
            // hudBorderNameLabel
            // 
            this.hudBorderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudBorderNameLabel.AutoSize = true;
            this.hudBorderNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudBorderNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudBorderNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudBorderNameLabel.Location = new System.Drawing.Point(0, 44);
            this.hudBorderNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudBorderNameLabel.Name = "hudBorderNameLabel";
            this.hudBorderNameLabel.Size = new System.Drawing.Size(70, 22);
            this.hudBorderNameLabel.TabIndex = 3;
            this.hudBorderNameLabel.Text = "Border";
            // 
            // hudSeedNameLabel
            // 
            this.hudSeedNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudSeedNameLabel.AutoSize = true;
            this.hudSeedNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudSeedNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudSeedNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudSeedNameLabel.Location = new System.Drawing.Point(0, 22);
            this.hudSeedNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudSeedNameLabel.Name = "hudSeedNameLabel";
            this.hudSeedNameLabel.Size = new System.Drawing.Size(50, 22);
            this.hudSeedNameLabel.TabIndex = 3;
            this.hudSeedNameLabel.Text = "Seed";
            // 
            // hudIntervalNameLabel
            // 
            this.hudIntervalNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudIntervalNameLabel.AutoSize = true;
            this.hudIntervalNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudIntervalNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudIntervalNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudIntervalNameLabel.Location = new System.Drawing.Point(0, 0);
            this.hudIntervalNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudIntervalNameLabel.Name = "hudIntervalNameLabel";
            this.hudIntervalNameLabel.Size = new System.Drawing.Size(90, 22);
            this.hudIntervalNameLabel.TabIndex = 4;
            this.hudIntervalNameLabel.Text = "Interval";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.tableLayoutPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.graphicsPanel.ResumeLayout(false);
            this.graphicsPanel.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.hudPanel.ResumeLayout(false);
            this.hudPanel.PerformLayout();
            this.hudTableLayout.ResumeLayout(false);
            this.hudTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripOpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripFileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStripSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripSaveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripImportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripQuitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripOptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripClearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripViewMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripAboutMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripGenerationStatusLabel;
        private System.Windows.Forms.ToolStripSeparator statusStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLiveStatusLabel;
        private System.Windows.Forms.ToolStripSeparator statusStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel statusStripTotalStatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripOptionsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripPlayButton;
        private System.Windows.Forms.ToolStripButton toolStripPauseButton;
        private System.Windows.Forms.ToolStripButton toolStripNextButton;
        private GraphicsPanel graphicsPanel;
        private System.Windows.Forms.Panel hudPanel;
        private System.Windows.Forms.TableLayoutPanel hudTableLayout;
        private System.Windows.Forms.Label hudScaleValueLabel;
        private System.Windows.Forms.Label hudBorderValueLabel;
        private System.Windows.Forms.Label hudSeedValueLabel;
        private System.Windows.Forms.Label hudIntervalValueLabel;
        private System.Windows.Forms.Label hudScaleNameLabel;
        private System.Windows.Forms.Label hudBorderNameLabel;
        private System.Windows.Forms.Label hudSeedNameLabel;
        private System.Windows.Forms.Label hudIntervalNameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuShowHudMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuShowGridMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuOptionsMenuItem;
        private System.Windows.Forms.ToolStripSeparator contextMenuDisplaySeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuClearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuPlayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuPauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuNextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem contextMenuShowNeighborCountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripFillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuFillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripShowHudMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripShowNeighborCountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripShowGridMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripFileMenuSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripNewButton;
        private System.Windows.Forms.ToolStripMenuItem menuStripShowHelpersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuShowHelpersMenuItem;
    }
}

