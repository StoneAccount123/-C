using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace g1
{
    internal class Crawler
    {
        public Hashtable urls = new Hashtable();
        public int count = 0;
        public void Crawl()
        {
            Console.WriteLine("开始爬行了。。。。。");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = Download(current);
                urls[current] = true;
                count++;
                Parse(html);
            }
            Console.WriteLine("爬行结束");
            Console.ReadKey();
        }
        public string Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString() + ".txt";
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
        public void Parse(string html)
        {
            //Console.WriteLine(html);
        }

       

    }
}