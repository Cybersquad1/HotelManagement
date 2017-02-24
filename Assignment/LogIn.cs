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
    public partial class LogIn : Form
    {
        private Employee emp;

        public LogIn()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*'; // text unables to view the characters
        }

     
        private void LogIn_Load(object sender, EventArgs e) //Details of the employee.
        {
            //setting the values to the employee
            string niNumber = "AA11AA11";
            string name = "David";
            string surname = "Micallef";
            string address = "22, Triq il Qasab, Bormla";
            string idNumber = "0054332M";
            int telephone = 21223664;
            string user = "admin";
            string pass = "admin";

            emp = new Employee(niNumber, name, surname, address, idNumber, telephone, user, pass); // creating a new employee
        }

        private void btnLogIn_Click(object sender, EventArgs e) //Will tell you tht you have succesfully logged in. 
        {
            if (ValidateControls()) // if all form is validated
            {
                MessageBox.Show("Succesfully Logged In\n Welcome Mr. " + emp.Surname);  // shows a message to the logged in user

                Menu m1 = new Menu(emp); // goes back to the menu
                this.Hide();
                m1.ShowDialog();
            }
            
        }
        private bool ValidateControls() //Errors if username or password are wrong.
        {
            errorProvider.Clear();
            bool correct = true;

            if (txtPass.Text == string.Empty && txtPass.Enabled)
            {
                errorProvider.SetError(txtPass, "Incorrect Inputs");
                correct = false;
            }
            if (txtUser.Text == string.Empty && txtUser.Enabled)
            {
                errorProvider.SetError(txtUser, "Incorrect Inputs");
                correct = false;
            }
            if (txtPass.Text != emp.Pass)
            {
                errorProvider.SetError(txtPass, "Incorrect Password");
                correct = false;
            }
            if (txtUser.Text != emp.Pass)
            {
                errorProvider.SetError(txtUser, "Incorrect Username");
                correct = false;
            }
            return correct;
        }

        private void btnClear_Click(object sender, EventArgs e) // To clear the fields if one makes any kind of mistake. 
        {
            txtPass.Text = "";
            txtUser.Text = "";
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }

   

}
