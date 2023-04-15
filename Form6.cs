using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //调用系统默认的浏览器
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/sungbly1tsstt/eazy-computer-tool-project1/tree/%E6%8C%89%E5%85%AC%E5%BC%8F%E8%AE%A1%E7%AE%97");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            webBrowser1 = new WebBrowser();
            var NowPath = Application.StartupPath;
            webBrowser1.Navigate(NowPath+"DefPlusing/math/agsjs/index.html");
        }
    }
}
