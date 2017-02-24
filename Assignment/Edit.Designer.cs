namespace Assignment
{
    partial class Edit
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
            this.customerDS1 = new Assignment.CustomerDS();
            this.tableAdapterManager1 = new Assignment.CustomerDSTableAdapters.TableAdapterManager();
            this.tblCustomerTableAdapter1 = new Assignment.CustomerDSTableAdapters.tblCustomerTableAdapter();
            this.customerDS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.tblCustomertblBookingDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBookingDateTableAdapter = new Assignment.CustomerDSTableAdapters.tblBookingDateTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomertblBookingDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDS1
            // 
            this.customerDS1.DataSetName = "CustomerDS";
            this.customerDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblBookingDateTableAdapter = null;
            this.tableAdapterManager1.tblCustomerTableAdapter = this.tblCustomerTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Assignment.CustomerDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCustomerTableAdapter1
            // 
            this.tblCustomerTableAdapter1.ClearBeforeFill = true;
            // 
            // customerDS1BindingSource
            // 
            this.customerDS1BindingSource.DataSource = this.customerDS1;
            this.customerDS1BindingSource.Position = 0;
            this.customerDS1BindingSource.CurrentChanged += new System.EventHandler(this.customerDS1BindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.idNumberDataGridViewTextBoxColumn,
            this.mobileNumber1DataGridViewTextBoxColumn,
            this.telephone1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCustomerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // idNumberDataGridViewTextBoxColumn
            // 
            this.idNumberDataGridViewTextBoxColumn.DataPropertyName = "idNumber";
            this.idNumberDataGridViewTextBoxColumn.HeaderText = "idNumber";
            this.idNumberDataGridViewTextBoxColumn.Name = "idNumberDataGridViewTextBoxColumn";
            // 
            // mobileNumber1DataGridViewTextBoxColumn
            // 
            this.mobileNumber1DataGridViewTextBoxColumn.DataPropertyName = "mobileNumber1";
            this.mobileNumber1DataGridViewTextBoxColumn.HeaderText = "mobileNumber1";
            this.mobileNumber1DataGridViewTextBoxColumn.Name = "mobileNumber1DataGridViewTextBoxColumn";
            // 
            // telephone1DataGridViewTextBoxColumn
            // 
            this.telephone1DataGridViewTextBoxColumn.DataPropertyName = "telephone1";
            this.telephone1DataGridViewTextBoxColumn.HeaderText = "telephone1";
            this.telephone1DataGridViewTextBoxColumn.Name = "telephone1DataGridViewTextBoxColumn";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.customerDS1BindingSource;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 319);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tblCustomertblBookingDateBindingSource
            // 
            this.tblCustomertblBookingDateBindingSource.DataMember = "tblCustomer_tblBookingDate";
            this.tblCustomertblBookingDateBindingSource.DataSource = this.tblCustomerBindingSource;
            // 
            // tblBookingDateTableAdapter
            // 
            this.tblBookingDateTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(331, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete By ID";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxId
            // 
            this.cbxId.DataSource = this.tblCustomerBindingSource;
            this.cbxId.DisplayMember = "name";
            this.cbxId.FormattingEnabled = true;
            this.cbxId.Location = new System.Drawing.Point(532, 275);
            this.cbxId.Name = "cbxId";
            this.cbxId.Size = new System.Drawing.Size(209, 21);
            this.cbxId.TabIndex = 4;
            this.cbxId.ValueMember = "idNumber";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 354);
            this.Controls.Add(this.cbxId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomertblBookingDateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomerDS customerDS1;
        private CustomerDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private CustomerDSTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter1;
        private System.Windows.Forms.BindingSource customerDS1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.BindingSource tblCustomertblBookingDateBindingSource;
        private CustomerDSTableAdapters.tblBookingDateTableAdapter tblBookingDateTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxId;
    }
}