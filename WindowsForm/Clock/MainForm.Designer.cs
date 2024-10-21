namespace Clock
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            labelTime = new Label();
            contextMenuStrip = new ContextMenuStrip(components);
            topmostПоверхВсехОконToolStripMenuItem = new ToolStripMenuItem();
            showControlsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            showDateПоказатьДатуToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            colorToolStripMenuItem = new ToolStripMenuItem();
            foregroundColorToolStripMenuItem = new ToolStripMenuItem();
            backgroundColorToolStripMenuItem = new ToolStripMenuItem();
            fontsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            loadOnWindowsStartupЗапускатьПриЗапускеWindowsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            cbShowDate = new CheckBox();
            btnHideControls = new Button();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.ContextMenuStrip = contextMenuStrip;
            labelTime.Font = new Font("Cascadia Mono", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTime.Location = new Point(11, 10);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(174, 79);
            labelTime.TabIndex = 0;
            labelTime.Text = "Time";
            labelTime.DoubleClick += labelTime_DoubleClick;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { topmostПоверхВсехОконToolStripMenuItem, showControlsToolStripMenuItem, toolStripSeparator1, showDateПоказатьДатуToolStripMenuItem, toolStripSeparator2, colorToolStripMenuItem, fontsToolStripMenuItem, toolStripSeparator3, loadOnWindowsStartupЗапускатьПриЗапускеWindowsToolStripMenuItem, toolStripSeparator4, closeToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(483, 224);
            // 
            // topmostПоверхВсехОконToolStripMenuItem
            // 
            topmostПоверхВсехОконToolStripMenuItem.CheckOnClick = true;
            topmostПоверхВсехОконToolStripMenuItem.Name = "topmostПоверхВсехОконToolStripMenuItem";
            topmostПоверхВсехОконToolStripMenuItem.Size = new Size(482, 24);
            topmostПоверхВсехОконToolStripMenuItem.Text = "Topmost (Поверх всех окон)";
            topmostПоверхВсехОконToolStripMenuItem.CheckedChanged += topmostПоверхВсехОконToolStripMenuItem_CheckedChanged;
            // 
            // showControlsToolStripMenuItem
            // 
            showControlsToolStripMenuItem.CheckOnClick = true;
            showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            showControlsToolStripMenuItem.Size = new Size(482, 24);
            showControlsToolStripMenuItem.Text = "Show controls";
            showControlsToolStripMenuItem.CheckedChanged += showControlsToolStripMenuItem_CheckedChanged;
            
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(479, 6);
            // 
            // showDateПоказатьДатуToolStripMenuItem
            // 
            showDateПоказатьДатуToolStripMenuItem.CheckOnClick = true;
            showDateПоказатьДатуToolStripMenuItem.Name = "showDateПоказатьДатуToolStripMenuItem";
            showDateПоказатьДатуToolStripMenuItem.Size = new Size(482, 24);
            showDateПоказатьДатуToolStripMenuItem.Text = "Show date (Показать дату) ";
            showDateПоказатьДатуToolStripMenuItem.CheckedChanged += showDateПоказатьДатуToolStripMenuItem_CheckedChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(479, 6);
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foregroundColorToolStripMenuItem, backgroundColorToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(482, 24);
            colorToolStripMenuItem.Text = "Colors";
            // 
            // foregroundColorToolStripMenuItem
            // 
            foregroundColorToolStripMenuItem.Name = "foregroundColorToolStripMenuItem";
            foregroundColorToolStripMenuItem.Size = new Size(209, 26);
            foregroundColorToolStripMenuItem.Text = "Foreground color";
            foregroundColorToolStripMenuItem.Click += foregroundColorToolStripMenuItem_Click;
            // 
            // backgroundColorToolStripMenuItem
            // 
            backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            backgroundColorToolStripMenuItem.Size = new Size(209, 26);
            backgroundColorToolStripMenuItem.Text = "Background color";
            backgroundColorToolStripMenuItem.Click += backgroundColorToolStripMenuItem_Click;
            // 
            // fontsToolStripMenuItem
            // 
            fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            fontsToolStripMenuItem.Size = new Size(482, 24);
            fontsToolStripMenuItem.Text = "Fonts";
            fontsToolStripMenuItem.Click += fontsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(479, 6);
            // 
            // loadOnWindowsStartupЗапускатьПриЗапускеWindowsToolStripMenuItem
            // 
            loadOnWindowsStartupЗапускатьПриЗапускеWindowsToolStripMenuItem.Name = "loadOnWindowsStartupЗапускатьПриЗапускеWindowsToolStripMenuItem";
            loadOnWindowsStartupЗапускатьПриЗапускеWindowsToolStripMenuItem.Size = new Size(482, 24);
            loadOnWindowsStartupЗапускатьПриЗапускеWindowsToolStripMenuItem.Text = "Load on Windows startup (Запускать при запуске Windows)";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(479, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(482, 24);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // cbShowDate
            // 
            cbShowDate.AutoSize = true;
            cbShowDate.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbShowDate.Location = new Point(145, 377);
            cbShowDate.Name = "cbShowDate";
            cbShowDate.Size = new Size(273, 44);
            cbShowDate.TabIndex = 1;
            cbShowDate.Text = "показать дату";
            cbShowDate.UseVisualStyleBackColor = true;
            cbShowDate.CheckedChanged += cbShowDate_CheckedChanged;
            // 
            // btnHideControls
            // 
            btnHideControls.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnHideControls.Location = new Point(122, 316);
            btnHideControls.Name = "btnHideControls";
            btnHideControls.Size = new Size(321, 55);
            btnHideControls.TabIndex = 2;
            btnHideControls.Text = "скрыть элементы управления";
            btnHideControls.UseVisualStyleBackColor = true;
            btnHideControls.Click += btnHideControls_Click;
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipTitle = "Current time";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStrip;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "notifyIcon1";
            notifyIconSystemTray.Visible = true;
            notifyIconSystemTray.DoubleClick += notifyIconSystemTray_DoubleClick;
            notifyIconSystemTray.MouseMove += notifyIconSystemTray_MouseMove;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 470);
            Controls.Add(btnHideControls);
            Controls.Add(cbShowDate);
            Controls.Add(labelTime);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Clock";
            TransparencyKey = Color.White;
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private CheckBox cbShowDate;
        private Button btnHideControls;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem topmostПоверхВсехОконToolStripMenuItem;
        private ToolStripMenuItem showControlsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem showDateПоказатьДатуToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fontsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem loadOnWindowsStartupЗапускатьПриЗапускеWindowsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem foregroundColorToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
    }
}
