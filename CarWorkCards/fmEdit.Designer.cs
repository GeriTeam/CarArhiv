namespace CarWorkCards
{
    partial class fmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gdEdit = new System.Windows.Forms.DataGridView();
            this.cARLISTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKNOMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carArhiv_DB_DataSet = new CarWorkCards.CarArhiv_DB_DataSet();
            this.cAR_LISTTableAdapter = new CarWorkCards.CarArhiv_DB_DataSetTableAdapters.CAR_LISTTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rEPAIRCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARLISTCODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLEMENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLEMENTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPAIRDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPAIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carArhivDataSet = new CarWorkCards.CarArhivDataSet();
            this.rEPAIRTableAdapter = new CarWorkCards.CarArhivDataSetTableAdapters.REPAIRTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gdEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhiv_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPAIRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhivDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gdEdit
            // 
            this.gdEdit.AllowUserToAddRows = false;
            this.gdEdit.AllowUserToDeleteRows = false;
            this.gdEdit.AutoGenerateColumns = false;
            this.gdEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cARLISTCODEDataGridViewTextBoxColumn,
            this.mARKADataGridViewTextBoxColumn,
            this.dKNOMERDataGridViewTextBoxColumn});
            this.gdEdit.DataSource = this.cARLISTBindingSource;
            this.gdEdit.Location = new System.Drawing.Point(25, 13);
            this.gdEdit.Name = "gdEdit";
            this.gdEdit.Size = new System.Drawing.Size(658, 85);
            this.gdEdit.TabIndex = 0;
            this.gdEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdEdit_CellContentClick);
            // 
            // cARLISTCODEDataGridViewTextBoxColumn
            // 
            this.cARLISTCODEDataGridViewTextBoxColumn.DataPropertyName = "CAR_LIST_CODE";
            this.cARLISTCODEDataGridViewTextBoxColumn.HeaderText = "CAR_LIST_CODE";
            this.cARLISTCODEDataGridViewTextBoxColumn.Name = "cARLISTCODEDataGridViewTextBoxColumn";
            // 
            // mARKADataGridViewTextBoxColumn
            // 
            this.mARKADataGridViewTextBoxColumn.DataPropertyName = "MARKA";
            this.mARKADataGridViewTextBoxColumn.HeaderText = "MARKA";
            this.mARKADataGridViewTextBoxColumn.Name = "mARKADataGridViewTextBoxColumn";
            // 
            // dKNOMERDataGridViewTextBoxColumn
            // 
            this.dKNOMERDataGridViewTextBoxColumn.DataPropertyName = "DK_NOMER";
            this.dKNOMERDataGridViewTextBoxColumn.HeaderText = "DK_NOMER";
            this.dKNOMERDataGridViewTextBoxColumn.Name = "dKNOMERDataGridViewTextBoxColumn";
            // 
            // cARLISTBindingSource
            // 
            this.cARLISTBindingSource.DataMember = "CAR_LIST";
            this.cARLISTBindingSource.DataSource = this.carArhiv_DB_DataSet;
            // 
            // carArhiv_DB_DataSet
            // 
            this.carArhiv_DB_DataSet.DataSetName = "CarArhiv_DB_DataSet";
            this.carArhiv_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAR_LISTTableAdapter
            // 
            this.cAR_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(728, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEPAIRCODEDataGridViewTextBoxColumn,
            this.cARLISTCODEDataGridViewTextBoxColumn1,
            this.eLEMENTNAMEDataGridViewTextBoxColumn,
            this.eLEMENTNUMBERDataGridViewTextBoxColumn,
            this.rEPAIRDATEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEPAIRBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 100);
            this.dataGridView1.TabIndex = 2;
            // 
            // rEPAIRCODEDataGridViewTextBoxColumn
            // 
            this.rEPAIRCODEDataGridViewTextBoxColumn.DataPropertyName = "REPAIR_CODE";
            this.rEPAIRCODEDataGridViewTextBoxColumn.HeaderText = "REPAIR_CODE";
            this.rEPAIRCODEDataGridViewTextBoxColumn.Name = "rEPAIRCODEDataGridViewTextBoxColumn";
            // 
            // cARLISTCODEDataGridViewTextBoxColumn1
            // 
            this.cARLISTCODEDataGridViewTextBoxColumn1.DataPropertyName = "CAR_LIST_CODE";
            this.cARLISTCODEDataGridViewTextBoxColumn1.HeaderText = "CAR_LIST_CODE";
            this.cARLISTCODEDataGridViewTextBoxColumn1.Name = "cARLISTCODEDataGridViewTextBoxColumn1";
            // 
            // eLEMENTNAMEDataGridViewTextBoxColumn
            // 
            this.eLEMENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "ELEMENT_NAME";
            this.eLEMENTNAMEDataGridViewTextBoxColumn.HeaderText = "ELEMENT_NAME";
            this.eLEMENTNAMEDataGridViewTextBoxColumn.Name = "eLEMENTNAMEDataGridViewTextBoxColumn";
            // 
            // eLEMENTNUMBERDataGridViewTextBoxColumn
            // 
            this.eLEMENTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ELEMENT_NUMBER";
            this.eLEMENTNUMBERDataGridViewTextBoxColumn.HeaderText = "ELEMENT_NUMBER";
            this.eLEMENTNUMBERDataGridViewTextBoxColumn.Name = "eLEMENTNUMBERDataGridViewTextBoxColumn";
            // 
            // rEPAIRDATEDataGridViewTextBoxColumn
            // 
            this.rEPAIRDATEDataGridViewTextBoxColumn.DataPropertyName = "REPAIR_DATE";
            this.rEPAIRDATEDataGridViewTextBoxColumn.HeaderText = "REPAIR_DATE";
            this.rEPAIRDATEDataGridViewTextBoxColumn.Name = "rEPAIRDATEDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // rEPAIRBindingSource
            // 
            this.rEPAIRBindingSource.DataMember = "REPAIR";
            this.rEPAIRBindingSource.DataSource = this.carArhivDataSet;
            // 
            // carArhivDataSet
            // 
            this.carArhivDataSet.DataSetName = "CarArhivDataSet";
            this.carArhivDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEPAIRTableAdapter
            // 
            this.rEPAIRTableAdapter.ClearBeforeFill = true;
            // 
            // fmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gdEdit);
            this.Name = "fmEdit";
            this.Text = "fmEdit";
            this.Load += new System.EventHandler(this.fmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhiv_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPAIRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhivDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdEdit;
        private CarArhiv_DB_DataSet carArhiv_DB_DataSet;
        private System.Windows.Forms.BindingSource cARLISTBindingSource;
        private CarArhiv_DB_DataSetTableAdapters.CAR_LISTTableAdapter cAR_LISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARLISTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dKNOMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarArhivDataSet carArhivDataSet;
        private System.Windows.Forms.BindingSource rEPAIRBindingSource;
        private CarArhivDataSetTableAdapters.REPAIRTableAdapter rEPAIRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPAIRCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARLISTCODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLEMENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLEMENTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPAIRDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;

    }
}