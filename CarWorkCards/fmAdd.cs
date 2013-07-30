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

        private void fmAdd_Load(object sender, EventArgs e)
        {

            this.cAR_LISTTableAdapter.Fill(this.carArhiv_DB_DataSet_CarList.CAR_LIST);
                     


        }

        private void grdAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdAdd_DoubleClick(object sender, EventArgs e)
        {
            edtMarka.Text =
                grdAdd.Rows[0].Cells[this.carArhiv_DB_DataSet_CarList.CAR_LIST.MARKAColumn.ToString()].Value.ToString();  
        }
    }
}
