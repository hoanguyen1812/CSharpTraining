using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DownloadHtml("https://youtube.com");
            DownloadHtmlTaskAsync("https://youtube.com");
        }

        public async Task DownloadHtmlTaskAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);
            using (var streamWriter = new StreamWriter(@"D:\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var streamWriter = new StreamWriter(@"D:\result.html"))
            {
                streamWriter.Write(html);
            }

        }
    }
}
