namespace CarWorkCards
{
    partial class fmAdd
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
            this.carArhiv_DB_DataSet = new CarWorkCards.CarArhiv_DB_DataSet();
            this.carArhivDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdAdd = new System.Windows.Forms.DataGridView();
            this.cARLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAR_LISTTableAdapter = new CarWorkCards.CarArhiv_DB_DataSetTableAdapters.CAR_LISTTableAdapter();
            this.cARLISTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKNOMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.edtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtDK_Nomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtModel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carArhiv_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhivDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARLISTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carArhiv_DB_DataSet
            // 
            this.carArhiv_DB_DataSet.DataSetName = "CarArhiv_DB_DataSet";
            this.carArhiv_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carArhivDBDataSetBindingSource
            // 
            this.carArhivDBDataSetBindingSource.DataSource = this.carArhiv_DB_DataSet;
            this.carArhivDBDataSetBindingSource.Position = 0;
            // 
            // gdAdd
            // 
            this.gdAdd.AutoGenerateColumns = false;
            this.gdAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cARLISTCODEDataGridViewTextBoxColumn,
            this.mARKADataGridViewTextBoxColumn,
            this.dKNOMERDataGridViewTextBoxColumn});
            this.gdAdd.DataSource = this.cARLISTBindingSource;
            this.gdAdd.Location = new System.Drawing.Point(12, 12);
            this.gdAdd.Name = "gdAdd";
            this.gdAdd.Size = new System.Drawing.Size(352, 289);
            this.gdAdd.TabIndex = 0;
            // 
            // cARLISTBindingSource
            // 
            this.cARLISTBindingSource.DataMember = "CAR_LIST";
            this.cARLISTBindingSource.DataSource = this.carArhivDBDataSetBindingSource;
            // 
            // cAR_LISTTableAdapter
            // 
            this.cAR_LISTTableAdapter.ClearBeforeFill = true;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(587, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добави автомобила";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtMarka
            // 
            this.edtMarka.Location = new System.Drawing.Point(383, 73);
            this.edtMarka.Name = "edtMarka";
            this.edtMarka.Size = new System.Drawing.Size(108, 20);
            this.edtMarka.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Рег. номер";
            // 
            // edtDK_Nomer
            // 
            this.edtDK_Nomer.Location = new System.Drawing.Point(383, 31);
            this.edtDK_Nomer.Name = "edtDK_Nomer";
            this.edtDK_Nomer.Size = new System.Drawing.Size(108, 20);
            this.edtDK_Nomer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Модел";
            // 
            // edtModel
            // 
            this.edtModel.Location = new System.Drawing.Point(383, 115);
            this.edtModel.Name = "edtModel";
            this.edtModel.Size = new System.Drawing.Size(108, 20);
            this.edtModel.TabIndex = 6;
            // 
            // fmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtDK_Nomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtMarka);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gdAdd);
            this.Name = "fmAdd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carArhiv_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhivDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARLISTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource carArhivDBDataSetBindingSource;
        private CarArhiv_DB_DataSet carArhiv_DB_DataSet;
        private System.Windows.Forms.DataGridView gdAdd;
        private System.Windows.Forms.BindingSource cARLISTBindingSource;
        private CarArhiv_DB_DataSetTableAdapters.CAR_LISTTableAdapter cAR_LISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARLISTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dKNOMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox edtMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtDK_Nomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtModel;
    }
}