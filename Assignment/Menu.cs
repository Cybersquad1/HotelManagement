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
    public partial class Menu : Form
    {
        //declaring variables
        private Employee emp;
        public Menu()
        {
            InitializeComponent();
           
        }
        public Menu(Employee emp):this()
        {
            this.emp = emp;
            lblEmployee.Text = emp.GetInfo(); //showing the employee details
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn l1 = new LogIn(); // Gets you to the log in form
            this.Hide();
            l1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //  exits the application
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Booking b = new Booking(emp); // go to the new booking
            this.Hide();
            b.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order o = new Order(emp); // go to the new order form
            this.Hide();
            o.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit e2 = new Edit(emp); // goes to the edit form
            this.Hide();
            e2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckOutForm c = new CheckOutForm (emp); // goes to the check out form 
            this.Hide();
            c.ShowDialog();
        }
    }
}
