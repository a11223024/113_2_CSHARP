using System.Diagnostics.Eventing.Reader;

namespace Tutorial_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            logListBox.Items.Add("�����o�Ӫ�����:");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distance, gas, average;

            if (double.TryParse(textBox1.Text, out distance))
            {
                if (double.TryParse(textBox2.Text, out gas))
                {
                    average = distance / gas;
                    label4.Text = "�����o��:" + average.ToString("f2") + "����/����";
                    logListBox.Items.Add(average.ToString("f2") + "����/����");
                }
                else
                {
                    MessageBox.Show("�o�ӽп�J�Ʀr");
                    textBox1.Focus();
                    textBox1.Text = "";

                }

            }

            else
            {
                MessageBox.Show("���{�п�J�Ʀr");
                textBox1.Focus();
                textBox1.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (logListBox.Items.Count > 1)
            {
                logListBox.Items.Add("�����o�Ӭ���");
                for (int i = 1; i < logListBox.Items.Count; i++)
                {
                    sum += double.Parse(logListBox.Items[i].ToString().Replace("����/����", ""));
                }
                logListBox.Items.Add("�����o��:" + (sum / (logListBox.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }

        }
    }
}
