namespace DEDuino
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxComSelect = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusComConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusVersioninfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCOMListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SysTeayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SystrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SystrayMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SystrayMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SystrayMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCautionPanel = new System.Windows.Forms.GroupBox();
            this.checkBox_JshepCP = new System.Windows.Forms.CheckBox();
            this.radioButtonCautionOld = new System.Windows.Forms.RadioButton();
            this.radioButtonCautionNew = new System.Windows.Forms.RadioButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_isUno = new System.Windows.Forms.CheckBox();
            this.tabPageAdv = new System.Windows.Forms.TabPage();
            this.checkBox_onStartup = new System.Windows.Forms.CheckBox();
            this.Checkbox_BMS432 = new System.Windows.Forms.CheckBox();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SystrayMenu.SuspendLayout();
            this.groupBoxCautionPanel.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageAdv.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Location = new System.Drawing.Point(28, 85);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 41);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "&Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxComSelect
            // 
            this.comboBoxComSelect.FormattingEnabled = true;
            this.comboBoxComSelect.Location = new System.Drawing.Point(26, 34);
            this.comboBoxComSelect.Name = "comboBoxComSelect";
            this.comboBoxComSelect.Size = new System.Drawing.Size(139, 21);
            this.comboBoxComSelect.TabIndex = 1;
            this.comboBoxComSelect.Text = "COM3";
            this.toolTipMain.SetToolTip(this.comboBoxComSelect, "Choose Your Arduino\'s COM port");
            this.comboBoxComSelect.DropDown += new System.EventHandler(this.comboBoxComSelect_DropDown);
            this.comboBoxComSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxComSelect_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusComConnection,
            this.StatusVersioninfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 204);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(204, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusComConnection
            // 
            this.toolStripStatusComConnection.Name = "toolStripStatusComConnection";
            this.toolStripStatusComConnection.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusComConnection.Text = "Ready";
            // 
            // StatusVersioninfo
            // 
            this.StatusVersioninfo.Name = "StatusVersioninfo";
            this.StatusVersioninfo.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(204, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshCOMListToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // refreshCOMListToolStripMenuItem
            // 
            this.refreshCOMListToolStripMenuItem.Name = "refreshCOMListToolStripMenuItem";
            this.refreshCOMListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshCOMListToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.refreshCOMListToolStripMenuItem.Text = "&Refresh COM list";
            this.refreshCOMListToolStripMenuItem.Click += new System.EventHandler(this.refreshCOMListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SysTeayIcon
            // 
            this.SysTeayIcon.ContextMenuStrip = this.SystrayMenu;
            this.SysTeayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SysTeayIcon.Icon")));
            this.SysTeayIcon.Text = "DEDuino";
            this.SysTeayIcon.Visible = true;
            this.SysTeayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // SystrayMenu
            // 
            this.SystrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystrayMenuItemShow,
            this.toolStripSeparator2,
            this.SystrayMenuItemStart,
            this.toolStripSeparator3,
            this.SystrayMenuItemExit});
            this.SystrayMenu.Name = "SystrayMenu";
            this.SystrayMenu.Size = new System.Drawing.Size(101, 82);
            // 
            // SystrayMenuItemShow
            // 
            this.SystrayMenuItemShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SystrayMenuItemShow.Name = "SystrayMenuItemShow";
            this.SystrayMenuItemShow.Size = new System.Drawing.Size(100, 22);
            this.SystrayMenuItemShow.Text = "Hide";
            this.SystrayMenuItemShow.Click += new System.EventHandler(this.SystrayMenuItemShow_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // SystrayMenuItemStart
            // 
            this.SystrayMenuItemStart.Name = "SystrayMenuItemStart";
            this.SystrayMenuItemStart.Size = new System.Drawing.Size(100, 22);
            this.SystrayMenuItemStart.Text = "&Start";
            this.SystrayMenuItemStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(97, 6);
            // 
            // SystrayMenuItemExit
            // 
            this.SystrayMenuItemExit.Name = "SystrayMenuItemExit";
            this.SystrayMenuItemExit.Size = new System.Drawing.Size(100, 22);
            this.SystrayMenuItemExit.Text = "E&xit";
            this.SystrayMenuItemExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBoxCautionPanel
            // 
            this.groupBoxCautionPanel.Controls.Add(this.checkBox_JshepCP);
            this.groupBoxCautionPanel.Controls.Add(this.radioButtonCautionOld);
            this.groupBoxCautionPanel.Controls.Add(this.radioButtonCautionNew);
            this.groupBoxCautionPanel.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCautionPanel.Name = "groupBoxCautionPanel";
            this.groupBoxCautionPanel.Size = new System.Drawing.Size(159, 87);
            this.groupBoxCautionPanel.TabIndex = 2;
            this.groupBoxCautionPanel.TabStop = false;
            this.groupBoxCautionPanel.Text = "Caution Panel Layout";
            // 
            // checkBox_JshepCP
            // 
            this.checkBox_JshepCP.AutoSize = true;
            this.checkBox_JshepCP.Location = new System.Drawing.Point(6, 66);
            this.checkBox_JshepCP.Name = "checkBox_JshepCP";
            this.checkBox_JshepCP.Size = new System.Drawing.Size(145, 17);
            this.checkBox_JshepCP.TabIndex = 2;
            this.checkBox_JshepCP.Text = "PSCockpit Caution Panel";
            this.checkBox_JshepCP.UseVisualStyleBackColor = true;
            this.checkBox_JshepCP.CheckedChanged += new System.EventHandler(this.checkBox_JshepCP_CheckedChanged);
            // 
            // radioButtonCautionOld
            // 
            this.radioButtonCautionOld.AutoSize = true;
            this.radioButtonCautionOld.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCautionOld.Name = "radioButtonCautionOld";
            this.radioButtonCautionOld.Size = new System.Drawing.Size(101, 17);
            this.radioButtonCautionOld.TabIndex = 1;
            this.radioButtonCautionOld.Text = "Block < 40 (Old)";
            this.radioButtonCautionOld.UseVisualStyleBackColor = true;
            this.radioButtonCautionOld.CheckedChanged += new System.EventHandler(this.radioButtonCaution_CheckedChanged);
            // 
            // radioButtonCautionNew
            // 
            this.radioButtonCautionNew.AutoSize = true;
            this.radioButtonCautionNew.Checked = true;
            this.radioButtonCautionNew.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCautionNew.Name = "radioButtonCautionNew";
            this.radioButtonCautionNew.Size = new System.Drawing.Size(113, 17);
            this.radioButtonCautionNew.TabIndex = 0;
            this.radioButtonCautionNew.TabStop = true;
            this.radioButtonCautionNew.Text = "Block => 40 (New)";
            this.radioButtonCautionNew.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageAdv);
            this.tabControlMain.Location = new System.Drawing.Point(12, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(180, 174);
            this.tabControlMain.TabIndex = 7;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageMain.Controls.Add(this.label1);
            this.tabPageMain.Controls.Add(this.comboBoxComSelect);
            this.tabPageMain.Controls.Add(this.checkBox_isUno);
            this.tabPageMain.Controls.Add(this.buttonStart);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(172, 148);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select COM port:";
            // 
            // checkBox_isUno
            // 
            this.checkBox_isUno.AutoSize = true;
            this.checkBox_isUno.Location = new System.Drawing.Point(26, 61);
            this.checkBox_isUno.Name = "checkBox_isUno";
            this.checkBox_isUno.Size = new System.Drawing.Size(85, 17);
            this.checkBox_isUno.TabIndex = 5;
            this.checkBox_isUno.Text = "Arduino Uno";
            this.toolTipMain.SetToolTip(this.checkBox_isUno, "Enable if using Arduino Micro or Due using the Native USB port");
            this.checkBox_isUno.UseVisualStyleBackColor = true;
            this.checkBox_isUno.CheckedChanged += new System.EventHandler(this.checkBox_isUno_CheckedChanged);
            // 
            // tabPageAdv
            // 
            this.tabPageAdv.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAdv.Controls.Add(this.checkBox_onStartup);
            this.tabPageAdv.Controls.Add(this.Checkbox_BMS432);
            this.tabPageAdv.Controls.Add(this.groupBoxCautionPanel);
            this.tabPageAdv.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdv.Name = "tabPageAdv";
            this.tabPageAdv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdv.Size = new System.Drawing.Size(172, 148);
            this.tabPageAdv.TabIndex = 1;
            this.tabPageAdv.Text = "Advanced";
            // 
            // checkBox_onStartup
            // 
            this.checkBox_onStartup.AutoSize = true;
            this.checkBox_onStartup.Location = new System.Drawing.Point(12, 123);
            this.checkBox_onStartup.Name = "checkBox_onStartup";
            this.checkBox_onStartup.Size = new System.Drawing.Size(109, 17);
            this.checkBox_onStartup.TabIndex = 4;
            this.checkBox_onStartup.Text = "Launch at startup";
            this.checkBox_onStartup.UseVisualStyleBackColor = true;
            this.checkBox_onStartup.CheckedChanged += new System.EventHandler(this.checkBox_onStartup_CheckedChanged);
            // 
            // Checkbox_BMS432
            // 
            this.Checkbox_BMS432.AutoSize = true;
            this.Checkbox_BMS432.Checked = true;
            this.Checkbox_BMS432.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Checkbox_BMS432.Location = new System.Drawing.Point(12, 100);
            this.Checkbox_BMS432.Name = "Checkbox_BMS432";
            this.Checkbox_BMS432.Size = new System.Drawing.Size(105, 17);
            this.Checkbox_BMS432.TabIndex = 3;
            this.Checkbox_BMS432.Text = "FalconBMS 4.32";
            this.Checkbox_BMS432.UseVisualStyleBackColor = true;
            this.Checkbox_BMS432.CheckedChanged += new System.EventHandler(this.Checkbox_BMS432_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 226);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "DEDuino";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SystrayMenu.ResumeLayout(false);
            this.groupBoxCautionPanel.ResumeLayout(false);
            this.groupBoxCautionPanel.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageAdv.ResumeLayout(false);
            this.tabPageAdv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxComSelect;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusComConnection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCOMListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon SysTeayIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel StatusVersioninfo;
        private System.Windows.Forms.RadioButton radioButtonCautionNew;
        private System.Windows.Forms.RadioButton radioButtonCautionOld;
        private System.Windows.Forms.GroupBox groupBoxCautionPanel;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageAdv;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.CheckBox Checkbox_BMS432;
        private System.Windows.Forms.CheckBox checkBox_onStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip SystrayMenu;
        private System.Windows.Forms.ToolStripMenuItem SystrayMenuItemStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SystrayMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem SystrayMenuItemShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.CheckBox checkBox_JshepCP;
        private System.Windows.Forms.CheckBox checkBox_isUno;

    }
}

