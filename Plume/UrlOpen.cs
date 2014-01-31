using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plume
{
    public partial class UrlOpen : Form
    {
        public UrlOpen()
        {
            InitializeComponent();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();

            if (ret == DialogResult.OK) {
                cmbFileName.Text = openFileDialog1.FileName;
                cmbFileName.Items.Add(openFileDialog1.FileName);
            }
        }
    }
}