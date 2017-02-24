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
    public partial class Booking : Form
    {
        // Declaring The Variable
        private Bill bill;
        private List<Booking_Date> bdlst;
        private Customer cust;
        private Booking_Date bd;
        private Rooms room;
        private Employee emp;

        public Booking()
        {
            
            InitializeComponent();
            room = new Rooms(); // Intilizing a new room

            cbxTyp.Items.AddRange(Enum.GetNames(typeof(RoomType)));// Getting the values of roomtype to cbx
            cbxRoomNo.Items.AddRange(Enum.GetNames(typeof(RoomNo)));// Getting the values of roomNo to cbx
           
        }
        public Booking(Employee emp):this() // getting the employee from the other table
        {
            this.emp = emp;

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu(emp); // btn that returns to the menu
            this.Hide();
            m1.ShowDialog();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDS.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.customerDS.tblCustomer); // filling the data from the table customer
            this.tblBookingDateTableAdapter1.Fill(this.customerDS.tblBookingDate); // filling the data from the table Booking
        
        }

        private void cbxTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
          //Checking for which the index is selected in cbx
           if (cbxTyp.SelectedIndex == 0)
            {
                
                double price = room.GetRoomPrice(RoomType.Single); // getting the roomprice and providing the input
                lblPerNight.Text = "€" + price.ToString(); // label is set according to the price
            }
            //Same applies for the conditions below , the only diffrence is the index selected and the input
           if (cbxTyp.SelectedIndex == 1)
           {

               double price = room.GetRoomPrice(RoomType.Double);
               lblPerNight.Text = "€" + price.ToString();
           }
           if (cbxTyp.SelectedIndex == 2)
           {

               double price = room.GetRoomPrice(RoomType.Triple);
               lblPerNight.Text = "€" + price.ToString();
           }
        }

        private bool ValidateControls() // method that return bool to validate controls
        {
            bool correct = true;

            if ( txtName.Text == string.Empty && txtName.Enabled)
            {
                errorProvider2.SetError(txtName, "Empty");
                correct = false;
            }
            if ( txtSurname.Text == string.Empty && txtSurname.Enabled)
            {
                errorProvider2.SetError(txtSurname, "Empty");
                correct = false;
            }
            if ( txtSurname.Text == string.Empty && txtSurname.Enabled)
            {
                errorProvider2.SetError(txtSurname, "Empty");
                correct = false;
            }
            if ( txtTelephone.Text == string.Empty && txtTelephone.Enabled)
            {
                errorProvider2.SetError(txtTelephone, "Empty");
                correct = false;
            }
            if ( txtMobile.Text == string.Empty && txtMobile.Enabled)
            {
                errorProvider2.SetError(txtMobile, "Empty");
                correct = false;
            }
            if ( txtEmail.Text == string.Empty && txtEmail.Enabled)
            {
                errorProvider2.SetError(txtMobile, "Empty");
                correct = false;
            }
            if ( txtId.Text == string.Empty && txtId.Enabled)
            {
                errorProvider2.SetError(txtId, "Empty");
                correct = false;
            }
            if ( txtAddress.Text == string.Empty && txtAddress.Enabled)
            {
                errorProvider2.SetError(txtAddress, "Empty");
                correct = false;
            }
            if (dateFromPick.Value.Date < DateTime.Now.Date)
            {
                errorProvider2.SetError(dateFromPick, "Invalid Dates");
                correct = false;
            }
            if (dateToPick.Value.Date < DateTime.Now.Date)
            {
                errorProvider2.SetError(dateToPick, "Invalid Dates");
                correct = false;
            }
            return correct;
        }

        private void btnCountinue_Click(object sender, EventArgs e)
        {
            //Declaring the Variables
            int mobileNumber;
            string email = txtEmail.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string address = txtAddress.Text;
            string idNumber = txtId.Text;
            string bdId = txtBdId.Text;
            int telephone;

            double bookingDays;
            double roomPrice;
            double bookingPrice;

            Email userEmail = new Email(); // intializing a new email
          
            if (ValidateControls() && int.TryParse(txtMobile.Text, out mobileNumber) && int.TryParse(txtMobile.Text, out telephone)) // the form is validated and the inputs taken
             {
                 DateTime dateFrom = new DateTime(); // intilizing a new date (From)
                 DateTime dateTo = new DateTime();// intilizing a new date (to)
                 dateFrom = dateFromPick.Value.Date; // Getting the value from
                 dateTo = dateToPick.Value.Date; // Getting the value to

                 TimeSpan t = dateTo.Date - dateFrom.Date; //setting the time span to get the days
                 bookingDays = t.TotalDays; // getting total days
                    
                 RoomNo roomNo = (RoomNo)Enum.Parse(typeof(RoomNo), cbxRoomNo.SelectedItem.ToString()); // Get roomNo from enums of the cbx
                 RoomType type = (RoomType)Enum.Parse(typeof(RoomType), cbxTyp.SelectedItem.ToString()); // Get type from enums of the cbx

                 cust = new Customer(mobileNumber, email, name, surname, address, idNumber, telephone); // Intilizing a new customer with all the details

               
                 roomPrice = room.GetRoomPrice(type); // getting the room price and inputing the type
                 bookingPrice = bookingDays * roomPrice; // Getting the price of the booking


                
                 room = new Rooms(roomNo, type, roomPrice, bdlst); // Creating a room and settinf it's properties
                 bd = new Booking_Date(emp, cust, dateFrom, dateTo, room, bookingPrice,bdId); // creating a booking date and giving it its properties
                 bill = new Bill(cust, emp, bd); // crearing a new bill

         
                 tblCustomerTableAdapter.InsertQuery(mobileNumber, email, name, surname, address, idNumber, telephone); //inserting the date to the database
                 tblBookingDateTableAdapter1.Insert(bd.Emp.ToString(), emp.ToString(), dateFrom, dateTo, room.ToString(), bookingPrice.ToString(), bdId); ; //inserting the date to the database

                 this.tblCustomerTableAdapter.Fill(this.customerDS.tblCustomer); // filling the tables
                 this.tblBookingDateTableAdapter1.Fill(this.customerDS.tblBookingDate);
                 MessageBox.Show("Booking"+ "\nInfo:" + cust.GetInfo() +"\n" + bd.GetInfo() + "\n" +"Type: " + type ); // messages box al the booking info


                 userEmail.SendEmail(txtEmail.Text, "neil.b.borg@mcast.edu.mt", "DETAILS OF YOUR BOOKING", "\nEnjoy Your Stay" + bd.GetInfo()); // sending the email

                 Menu m1 = new Menu(emp); // Sets the user back to the menu
                 this.Hide();
                 m1.ShowDialog();
             }
        }

      
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tblCustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //saving and updating the database
            this.Validate();
            this.tblCustomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerDS);

        }

        private void dateFromPick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
