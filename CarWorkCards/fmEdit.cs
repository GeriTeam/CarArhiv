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
            
            this.rEPAIRTableAdapter.Fill(this.carArhivDataSet.REPAIR);            
            this.cAR_LISTTableAdapter.Fill(this.carArhiv_DB_DataSet.CAR_LIST);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 
            //TODO: Опитвам се да взимам PK key-а на селектирания ред или клетка
            Int64 iRecordId = 0;
            int selectedIndex = 0;
            gdEdit.SelectedRows.ToString(); 
            if (gdEdit.SelectedRows.Count > 0)
            {
                selectedIndex = gdEdit.SelectedRows[0].Index;
                iRecordId = Convert.ToInt64(gdEdit.Rows[selectedIndex].Cells[0].Value);
                // insert delete commands heere
            }

 
            MessageBox.Show(gdEdit.CurrentRow.ToString());
           
        }

        private void gdEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
