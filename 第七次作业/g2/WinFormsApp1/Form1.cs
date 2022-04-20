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
            //年的前两位： (18 | 19 | 20)
            //月份：((0[1 - 9]) | 10 | 11 | 12)
            //天数： (([0 - 2][1 - 9]) | 10 | 20 | 30 | 31)     
            //三位顺序码： \d{ 3}
            //校验码： [0 - 9Xx]
            string pattern = @"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$";
            if (Regex.IsMatch(id, pattern))
            {
                MessageBox.Show("是合法身份证号");
            }else MessageBox.Show("不是合法身份证号");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}