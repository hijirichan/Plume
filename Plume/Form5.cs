﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plume
{
    public partial class Form5 : Form
    {
        public DialogResult linkflag = DialogResult.None;

        public Form5()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //リンク先に移動したことにする
            linkLabel1.LinkVisited = true;

            linkflag = DialogResult.OK;
            this.Close();
        }
    }
}