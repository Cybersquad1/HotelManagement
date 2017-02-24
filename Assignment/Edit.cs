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
    public partial class Edit : Form
    {
        //declaring employee
        private Employee emp;

        public Edit()
        {
            InitializeComponent();
        }
        public Edit(Employee emp):this() //getting employee from a previous form
        {
            this.emp = emp;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDS1.tblBookingDate' table. You can move, or remove it, as needed.
           
            this.tblCustomerTableAdapter1.Fill(this.customerDS1.tblCustomer);
        }

        private void customerDS1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu(emp); // gets the user back to the menu
            this.Hide();
            m1.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //updates a the new properties
            this.Validate();
            tblCustomerBindingSource.EndEdit();
            this.tblCustomerTableAdapter1.Update(this.customerDS1.tblCustomer);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string x = (string)cbxId.SelectedValue; // gets the id
            
            tblCustomerTableAdapter1.DeleteQuery(x); // deletes by id
            this.tblCustomerTableAdapter1.Fill(this.customerDS1.tblCustomer);
            
        }
    }
}
