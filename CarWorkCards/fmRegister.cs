using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CarWorkCards
{
    public partial class fmRegistar : Form
    {
        public int PK_KOD = new int();
        int currentRow = -1;
        public fmRegistar()
        {
            InitializeComponent();
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void fmAdd_Load(object sender, EventArgs e)
        {
            string queryFilter;            
            queryFilter = "select * from CAR_LIST where MARKA like" + edtMarka.Text;        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edtDK_Nomer.Text.Length == 0 && edtMarka.Text.Length == 0 &&
                edtModel.Text.Length == 0 && edtTelefon.Text.Length == 0)
                this.cAR_LISTTableAdapter.Fill(this.carArhiv_DB_DataSet.CAR_LIST);
            else
                this.cAR_LISTTableAdapter.Filter(this.carArhiv_DB_DataSet.CAR_LIST, ("%" + edtMarka.Text + "%"),
                    ("%" + edtDK_Nomer.Text + "%"), ("%" + edtModel.Text + "%"),  ("%" + edtTelefon.Text + "%"));           


        }

        private void gdAdd_Click(object sender, EventArgs e)
        {

        }

        private void gdAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fmAdd fmAdd = new fmAdd();
            fmAdd.Show();

        }

        private void gdAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            
            currentRow = gdAdd.CurrentRow.Index;
            gdAdd.Rows[currentRow].Selected = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentRow != -1)
            {
                //MessageBox.Show(gdAdd..ToString());

                
            }

        }
    }
}
