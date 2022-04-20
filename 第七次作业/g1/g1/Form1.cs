namespace g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crawler myCrawler = new Crawler();
            string startUrl = textBox1.Text;
            myCrawler.urls.Add(startUrl, false);
            new Thread(myCrawler.Crawl).Start();
        }
    }
}