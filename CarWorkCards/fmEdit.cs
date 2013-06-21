using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarWorkCards
{
    public partial class fmEdit : Form
    {
        public fmEdit()
        {
            InitializeComponent();
        }

        private void fmEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carArhivDataSet.REPAIR' table. You can move, or remove it, as needed.
            this.rEPAIRTableAdapter.Fill(this.carArhivDataSet.REPAIR);
            // TODO: This line of code loads data into the 'carArhiv_DB_DataSet.CAR_LIST' table. You can move, or remove it, as needed.
            this.cAR_LISTTableAdapter.Fill(this.carArhiv_DB_DataSet.CAR_LIST);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Int64 iRecordId = 0;
            int selectedIndex = 0;
            gdEdit.SelectedRows.ToString(); 
            if (gdEdit.SelectedRows.Count > 0)
            {
                selectedIndex = gdEdit.SelectedRows[0].Index;
                iRecordId = Convert.ToInt64(gdEdit.Rows[selectedIndex].Cells[0].Value);
                // insert delete commands heere
            }

 
            MessageBox.Show(gdEdit.SelectedCells..ToString());
           
        }

        private void gdEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
