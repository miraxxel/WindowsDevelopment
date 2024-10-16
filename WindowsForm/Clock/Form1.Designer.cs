namespace Clock
{
    partial class Form1
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
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            cbShowDate = new CheckBox();
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
            cbShowDate.Location = new Point(287, 377);
            cbShowDate.Name = "cbShowDate";
            cbShowDate.Size = new Size(273, 44);
            cbShowDate.TabIndex = 1;
            cbShowDate.Text = "показать дату";
            cbShowDate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbShowDate);
            Controls.Add(labelTime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private CheckBox cbShowDate;
    }
}
