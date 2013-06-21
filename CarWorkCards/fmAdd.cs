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
    public partial class fmAdd : Form
    {
        public fmAdd()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void fmAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carArhiv_DB_DataSet.CAR_LIST' table. You can move, or remove it, as needed.
           // this.cAR_LISTTableAdapter.Fill(this.carArhiv_DB_DataSet.CAR_LIST);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cAR_LISTTableAdapter.Insert(MARKA: edtMarka.Text, DK_NOMER: edtDK_Nomer.Text);
            this.cAR_LISTTableAdapter.Fill(this.carArhiv_DB_DataSet.CAR_LIST);
        }
    }
}
