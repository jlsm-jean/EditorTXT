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
    public partial class FormAjuda : Form
    {
        public FormAjuda()
        {
            InitializeComponent();
            webBrowser.Navigate("https://www.google.com/");
        }
    }
}
