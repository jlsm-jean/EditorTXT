﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXT_EDITOR
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
            WebBrowser webBrozer = new WebBrowser();
            webBrozer.Dock = DockStyle.Fill;
            webBrozer.Navigate(Application.StartupPath + @"sobre\index.html");
            this.Controls.Add(webBrozer);
        }
    }
}
