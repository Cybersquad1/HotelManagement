namespace Assignment
{
    partial class CheckOutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDS1 = new Assignment.CustomerDS();
            this.tableAdapterManager1 = new Assignment.CustomerDSTableAdapters.TableAdapterManager();
            this.tblBookingDateTableAdapter1 = new Assignment.CustomerDSTableAdapters.tblBookingDateTableAdapter();
            this.tblCustomerTableAdapter1 = new Assignment.CustomerDSTableAdapters.tblCustomerTableAdapter();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblBooking = new System.Windows.Forms.Label();
            this.tblCustomertblBookingDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomertblBookingDateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomertblBookingDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomertblBookingDateBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer :";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.DataSource = this.tblCustomerBindingSource;
            this.cbxCustomer.DisplayMember = "name";
            this.cbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(75, 6);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(342, 21);
            this.cbxCustomer.TabIndex = 1;
            this.cbxCustomer.ValueMember = "idNumber";
            this.cbxCustomer.SelectedIndexChanged += new System.EventHandler(this.cbxCustomer_SelectedIndexChanged);
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.customerDS1;
            // 
            // customerDS1
            // 
            this.customerDS1.DataSetName = "CustomerDS";
            this.customerDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblBookingDateTableAdapter = this.tblBookingDateTableAdapter1;
            this.tableAdapterManager1.tblCustomerTableAdapter = this.tblCustomerTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Assignment.CustomerDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblBookingDateTableAdapter1
            // 
            this.tblBookingDateTableAdapter1.ClearBeforeFill = true;
            // 
            // tblCustomerTableAdapter1
            // 
            this.tblCustomerTableAdapter1.ClearBeforeFill = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 280);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(342, 280);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Location = new System.Drawing.Point(12, 43);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(0, 13);
            this.lblBooking.TabIndex = 4;
            // 
            // tblCustomertblBookingDateBindingSource
            // 
            this.tblCustomertblBookingDateBindingSource.DataMember = "tblCustomer_tblBookingDate";
            this.tblCustomertblBookingDateBindingSource.DataSource = this.tblCustomerBindingSource;
            // 
            // tblCustomertblBookingDateBindingSource1
            // 
            this.tblCustomertblBookingDateBindingSource1.DataMember = "tblCustomer_tblBookingDate";
            this.tblCustomertblBookingDateBindingSource1.DataSource = this.tblCustomerBindingSource;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 315);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.label1);
            this.Name = "CheckOutForm";
            this.Text = "Check Out Form";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomertblBookingDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomertblBookingDateBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private CustomerDS customerDS1;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private CustomerDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private CustomerDSTableAdapters.tblBookingDateTableAdapter tblBookingDateTableAdapter1;
        private CustomerDSTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.BindingSource tblCustomertblBookingDateBindingSource;
        private System.Windows.Forms.BindingSource tblCustomertblBookingDateBindingSource1;
    }
}