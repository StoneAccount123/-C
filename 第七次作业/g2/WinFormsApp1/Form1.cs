using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            //���ǰ��λ�� (18 | 19 | 20)
            //�·ݣ�((0[1 - 9]) | 10 | 11 | 12)
            //������ (([0 - 2][1 - 9]) | 10 | 20 | 30 | 31)     
            //��λ˳���룺 \d{ 3}
            //У���룺 [0 - 9Xx]
            string pattern = @"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$";
            if (Regex.IsMatch(id, pattern))
            {
                MessageBox.Show("�ǺϷ����֤��");
            }else MessageBox.Show("���ǺϷ����֤��");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}