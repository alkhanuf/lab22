namespace lab22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.sen1;
            textBox2.Text = Properties.Settings.Default.sen2;
            labelRes.Text = Properties.Settings.Default.res;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sen1 = textBox1.Text;
            string sen2 = textBox2.Text;

            List<string> list = Utils.FindWords(sen1, sen2);
            string res = string.Join(',', list);

            labelRes.Text = res;

            Properties.Settings.Default.sen1 = sen1;
            Properties.Settings.Default.sen2 = sen2;
            Properties.Settings.Default.res = res;

            Properties.Settings.Default.Save();
        }
    }
}
