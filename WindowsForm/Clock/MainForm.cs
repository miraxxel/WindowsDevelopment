namespace Clock
{
    public partial class MainForm : Form
    {
        ColorDialog backgroundColorDialog; // если не инициализируем, то получаются не объекты, а ссылки
        ColorDialog foregroundColorDialog;
        public MainForm() // конструктор формы
        {
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
            backgroundColorDialog = new ColorDialog();
            foregroundColorDialog = new ColorDialog();
            SetVisibility(false);
            this.Location = new Point
                (
                    System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width,
                    50
                );
            this.Text += $" Location: {this.Location.X}x{this.Location.Y}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // неявно добавленный обработчик события - самая обычная функция (кто отправил событие и параметры)
            // у каждого события свой обработчик

            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (cbShowDate.Checked)
            {
                labelTime.Text += $"\n{DateTime.Today.ToString("yyyy.MM.dd")}";
            }
            notifyIconSystemTray.Text = "Current time " + labelTime.Text;
        }

        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable : FormBorderStyle.None;
            this.ShowInTaskbar = visible;
            cbShowDate.Visible = visible;
            btnHideControls.Visible = visible;
            labelTime.BackColor = visible ? Color.Empty : backgroundColorDialog.Color;
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            //SetVisibility(false);
            showControlsToolStripMenuItem.Checked = false;
            notifyIconSystemTray.ShowBalloonTip(3, "Важная информация", "Чтобы вернуть как было нажмите дважды по часам", ToolTipIcon.Info);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            //SetVisibility(true);
            showControlsToolStripMenuItem.Checked = true;
        }

        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Current time:\n" + labelTime.Text;
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topmostПоверхВсехОконToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostПоверхВсехОконToolStripMenuItem.Checked;
        }

        private void showControlsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(((ToolStripMenuItem)sender).Checked);
        }

        private void showDateПоказатьДатуToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDate.Checked = ((ToolStripMenuItem)sender).Checked;
        }

        private void cbShowDate_CheckedChanged(object sender, EventArgs e)
        {
            showDateПоказатьДатуToolStripMenuItem.Checked = ((CheckBox)sender).Checked;
            // т.к. дочерние элементы отправляют (генерируют) события, обработчик события принимает отправителя и аргументы события 
            // sender - элемент интерфейса (отправитель) 
        }

        private void notifyIconSystemTray_DoubleClick(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void foregroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.ForeColor = foregroundColorDialog.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.BackColor = backgroundColorDialog.Color;
            }
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(Font.)
        }
    }
}