namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ������ ����������� ���������� ������� - ����� ������� ������� (��� �������� ������� � ���������)
            // � ������� ������� ���� ����������

            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if(cbShowDate.Checked )
            {
                labelTime.Text+=$"\n{DateTime.Today.ToString("yyyy.MM.dd")}";
            }
        }
    }
}
