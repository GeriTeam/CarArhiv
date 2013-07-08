using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarWorkCards
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmRegistar fmRegistar = new fmRegistar();
            fmRegistar.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fmEdit fmEdit = new fmEdit();
            fmEdit.Show();
        }
    }
}
