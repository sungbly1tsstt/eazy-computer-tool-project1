﻿using System;
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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {   
            var NowPath = Application.StartupPath;
            //webBrowser1 = new WebBrowser();
            webBrowser1.Navigate(NowPath + "/DefPlusing/calc/calc.html");
        }
    }
}
