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
    public partial class Order : Form
    {
        //declaring the emp
        private Employee emp;
        public Order()
        {
            InitializeComponent();
        }

        public Order(Employee emp):this() //getting the employee from the prvious table
        {
            this.emp = emp;
        }
        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu(emp); //Goes back to menu
            this.Hide();
            m1.ShowDialog();
        }

        private void btnRoomSer_Click(object sender, EventArgs e)
        {
            RoomServiceForm rs = new RoomServiceForm(emp); // goes to room service
            this.Hide();
            rs.ShowDialog();
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            BarForm b = new BarForm(emp); // goes to the bar form
            this.Hide();
            b.ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            test tst = new test(emp);
            this.Hide();
            tst.ShowDialog();
        }
    }
}
