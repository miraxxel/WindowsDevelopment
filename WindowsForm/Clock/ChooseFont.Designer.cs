namespace Clock
{
    partial class ChooseFont
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
            buttonOK = new Button();
            labelExample = new Label();
            buttonCancel = new Button();
            comboBoxFonts = new ComboBox();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(213, 259);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // labelExample
            // 
            labelExample.AutoSize = true;
            labelExample.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelExample.Location = new Point(12, 110);
            labelExample.Name = "labelExample";
            labelExample.Size = new Size(201, 62);
            labelExample.TabIndex = 1;
            labelExample.Text = "Example";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(313, 259);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxFonts
            // 
            comboBoxFonts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFonts.FormattingEnabled = true;
            comboBoxFonts.Location = new Point(12, 25);
            comboBoxFonts.Name = "comboBoxFonts";
            comboBoxFonts.Size = new Size(600, 28);
            comboBoxFonts.TabIndex = 3;
            comboBoxFonts.SelectedValueChanged += comboBoxFonts_SelectedValueChanged;
            // 
            // ChooseFont
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 300);
            Controls.Add(comboBoxFonts);
            Controls.Add(buttonCancel);
            Controls.Add(labelExample);
            Controls.Add(buttonOK);
            Name = "ChooseFont";
            Text = "ChooseFont";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private Label labelExample;
        private Button buttonCancel;
        private ComboBox comboBoxFonts;
    }
}