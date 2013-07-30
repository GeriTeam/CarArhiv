namespace CarWorkCards
{
    partial class fmRegistar
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
            this.gdAdd = new System.Windows.Forms.DataGridView();
            this.mARKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKNOMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GOD_PROIZVODSTVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_LIST_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carArhiv_DB_DataSet = new CarWorkCards.CarArhiv_DB_DataSet_CarList();
            this.btnFilter = new System.Windows.Forms.Button();
            this.edtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtDK_Nomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtModel = new System.Windows.Forms.TextBox();
            this.carArhivDataSet = new CarWorkCards.CarArhiv_DB_DataSet_Rapair();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cAR_LISTTableAdapter = new CarWorkCards.CarArhiv_DB_DataSetTableAdapters.CAR_LISTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gdAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhiv_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhivDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdAdd
            // 
            this.gdAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gdAdd.AutoGenerateColumns = false;
            this.gdAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mARKADataGridViewTextBoxColumn,
            this.MODEL,
            this.dKNOMERDataGridViewTextBoxColumn,
            this.COLOR,
            this.CUSTOMER,
            this.TELEFON,
            this.GOD_PROIZVODSTVO,
            this.CAR_LIST_CODE});
            this.gdAdd.DataSource = this.cARLISTBindingSource;
            this.gdAdd.Location = new System.Drawing.Point(12, 80);
            this.gdAdd.Name = "gdAdd";
            this.gdAdd.Size = new System.Drawing.Size(652, 241);
            this.gdAdd.TabIndex = 0;
            this.gdAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdAdd_CellClick);
            this.gdAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdAdd_CellContentClick);
            this.gdAdd.Click += new System.EventHandler(this.gdAdd_Click);
            // 
            // mARKADataGridViewTextBoxColumn
            // 
            this.mARKADataGridViewTextBoxColumn.DataPropertyName = "MARKA";
            this.mARKADataGridViewTextBoxColumn.HeaderText = "Марка";
            this.mARKADataGridViewTextBoxColumn.Name = "mARKADataGridViewTextBoxColumn";
            // 
            // MODEL
            // 
            this.MODEL.DataPropertyName = "MODEL";
            this.MODEL.HeaderText = "Модел";
            this.MODEL.Name = "MODEL";
            this.MODEL.Width = 60;
            // 
            // dKNOMERDataGridViewTextBoxColumn
            // 
            this.dKNOMERDataGridViewTextBoxColumn.DataPropertyName = "DK_NOMER";
            this.dKNOMERDataGridViewTextBoxColumn.HeaderText = "Рег. номер";
            this.dKNOMERDataGridViewTextBoxColumn.Name = "dKNOMERDataGridViewTextBoxColumn";
            this.dKNOMERDataGridViewTextBoxColumn.ToolTipText = "Рег. номер";
            this.dKNOMERDataGridViewTextBoxColumn.Width = 60;
            // 
            // COLOR
            // 
            this.COLOR.DataPropertyName = "COLOR";
            this.COLOR.HeaderText = "Цвят";
            this.COLOR.Name = "COLOR";
            this.COLOR.Width = 45;
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.DataPropertyName = "CUSTOMER";
            this.CUSTOMER.HeaderText = "Собственик";
            this.CUSTOMER.Name = "CUSTOMER";
            this.CUSTOMER.Width = 189;
            // 
            // TELEFON
            // 
            this.TELEFON.DataPropertyName = "TELEFON";
            this.TELEFON.HeaderText = "Телефон";
            this.TELEFON.Name = "TELEFON";
            this.TELEFON.Width = 75;
            // 
            // GOD_PROIZVODSTVO
            // 
            this.GOD_PROIZVODSTVO.DataPropertyName = "GOD_PROIZVODSTVO";
            this.GOD_PROIZVODSTVO.HeaderText = "Год. производство";
            this.GOD_PROIZVODSTVO.Name = "GOD_PROIZVODSTVO";
            this.GOD_PROIZVODSTVO.Width = 80;
            // 
            // CAR_LIST_CODE
            // 
            this.CAR_LIST_CODE.DataPropertyName = "CAR_LIST_CODE";
            this.CAR_LIST_CODE.HeaderText = "CAR_LIST_CODE";
            this.CAR_LIST_CODE.Name = "CAR_LIST_CODE";
            this.CAR_LIST_CODE.Visible = false;
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
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFilter.Location = new System.Drawing.Point(477, 24);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(165, 27);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Филтър";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtMarka
            // 
            this.edtMarka.Location = new System.Drawing.Point(241, 31);
            this.edtMarka.Name = "edtMarka";
            this.edtMarka.Size = new System.Drawing.Size(108, 20);
            this.edtMarka.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Рег. номер";
            // 
            // edtDK_Nomer
            // 
            this.edtDK_Nomer.Location = new System.Drawing.Point(13, 31);
            this.edtDK_Nomer.Name = "edtDK_Nomer";
            this.edtDK_Nomer.Size = new System.Drawing.Size(108, 20);
            this.edtDK_Nomer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Модел";
            // 
            // edtModel
            // 
            this.edtModel.Location = new System.Drawing.Point(127, 31);
            this.edtModel.Name = "edtModel";
            this.edtModel.Size = new System.Drawing.Size(108, 20);
            this.edtModel.TabIndex = 6;
            // 
            // carArhivDataSet
            // 
            this.carArhivDataSet.DataSetName = "CarArhivDataSet";
            this.carArhivDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.edtTelefon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.edtMarka);
            this.panel1.Controls.Add(this.edtModel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edtDK_Nomer);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 64);
            this.panel1.TabIndex = 8;
            // 
            // edtTelefon
            // 
            this.edtTelefon.Location = new System.Drawing.Point(355, 31);
            this.edtTelefon.Name = "edtTelefon";
            this.edtTelefon.Size = new System.Drawing.Size(108, 20);
            this.edtTelefon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Телефон";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 58);
            this.panel2.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(3, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Изтриване";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(219, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(210, 27);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Редактиране";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(433, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавяне на нов";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cAR_LISTTableAdapter
            // 
            this.cAR_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // fmRegistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gdAdd);
            this.Name = "fmRegistar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистър...";
            this.Load += new System.EventHandler(this.fmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhiv_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carArhivDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdAdd;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox edtMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtDK_Nomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtModel;
        private CarArhiv_DB_DataSet_Rapair carArhivDataSet;
        private CarArhiv_DB_DataSet_CarList carArhiv_DB_DataSet;
        private System.Windows.Forms.BindingSource cARLISTBindingSource;
        private CarArhiv_DB_DataSetTableAdapters.CAR_LISTTableAdapter cAR_LISTTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox edtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dKNOMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFON;
        private System.Windows.Forms.DataGridViewTextBoxColumn GOD_PROIZVODSTVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_LIST_CODE;
    }
}