﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naughty_Note
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void labelMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/mohamedmamdouh392000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
