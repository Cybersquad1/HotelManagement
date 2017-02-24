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
    public partial class CheckOutForm : Form
    {
        private Customer cust;
        private Employee emp;
        private Bill bill;
        private Booking_Date bd;

        public CheckOutForm()
        {
            InitializeComponent();
              
        }
        public CheckOutForm(Employee emp):this()
        {
            this.emp = emp;
            cust = (Customer)cbxCustomer.SelectedValue; 
        }
        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDS1.tblBookingDate' table. You can move, or remove it, as needed.
            this.tblBookingDateTableAdapter1.Fill(this.customerDS1.tblBookingDate);
            this.tblCustomerTableAdapter1.Fill(this.customerDS1.tblCustomer);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu(emp);
            this.Hide();
            m1.ShowDialog();
        }

        private void cbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
         


        }

    }
}
