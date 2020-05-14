using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerWin
{
    public partial class Form1 : System.Windows.Forms.Form
    {
      
       public SimpleCrawler Crawler { get; set; }
       
        public Form1(){
            InitializeComponent();
            Crawler = new SimpleCrawler();
           
            textBox1.DataBindings.Add("Text", Crawler, "StartUrl");
        }

        private void Crawler_PageDownloaded(object o, InformEventArgs e)
        {
            if (this.listBox1.InvokeRequired)
            {
                Action<InformEventArgs> action = AddResult;
                this.Invoke(action, e);
            }
            else
            {
                AddResult(e);
            }
        }

        private void AddResult(InformEventArgs e)
        {
            if (e.Url == null)
            {
                listBox1.Items.Add(e.Message);
            }
            else
            {
                listBox1.Items.Add("正在爬取：" + e.Url + "\t状态为：" + e.Message);
                listBox1.Items.Add(e.Url);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Crawler.Inform += Crawler_PageDownloaded;
   
            new Thread(Crawler.Start).Start();
        }
    }
}
    

