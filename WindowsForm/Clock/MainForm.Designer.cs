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
            timer1 = new System.Windows.Forms.Timer(components);
            cbShowDate = new CheckBox();
            btnHideControls = new Button();
            notifyIconSystemTray = new NotifyIcon(components);
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Cascadia Mono", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTime.Location = new Point(11, 10);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(174, 79);
            labelTime.TabIndex = 0;
            labelTime.Text = "Time";
            labelTime.DoubleClick += labelTime_DoubleClick;
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
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "notifyIcon1";
            notifyIconSystemTray.Visible = true;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private CheckBox cbShowDate;
        private Button btnHideControls;
        private NotifyIcon notifyIconSystemTray;
    }
}
