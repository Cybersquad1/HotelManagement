using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tblBookingDateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBookingDateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerDS);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDS.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.customerDS.tblCustomer);
            // TODO: This line of code loads data into the 'customerDS.tblBookingDate' table. You can move, or remove it, as needed.
            this.tblBookingDateTableAdapter.Fill(this.customerDS.tblBookingDate);

        }
    }
}
