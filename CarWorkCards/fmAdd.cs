using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web.UI;

namespace CarWorkCards
{
    public partial class fmAdd : Form
    {
        OleDbConnection CunnectionToCarArhiv = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\radoslav\Documents\GitHub\CarArhiv\CarWorkCards\CarArhiv.mdb");
        OleDbDataAdapter AdapterToCarArhiv = new OleDbDataAdapter();
     //   OleDbDataReader ReaderCarArhiv;
        DataSet CarArhivAdd_DataSet = new DataSet();
        DataTable CarArhivDataTableAdapter = new DataTable("CAR_LIST");
        
        
        public fmAdd()
        {
            InitializeComponent();
            gdAdd.DataSource = CarArhivAdd_DataSet;
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
            
           // this.cAR_LISTTableAdapter.Insert(MARKA: edtMarka.Text, DK_NOMER: edtDK_Nomer.Text);
            //this.cAR_LISTTableAdapter.Fill(this.carArhiv_DB_DataSet.CAR_LIST);
            CunnectionToCarArhiv.Open();
            //AdapterToCarArhiv.TableMappings["CAR_LIST"].DataSetTable.Insert(1,"Rado");            
            //MessageBox.Show("Готово");
            gdAdd.Refresh();
            gdAdd.DataSource = CarArhivAdd_DataSet;
          //  gdAdd.Bind;
        }
    }
}
