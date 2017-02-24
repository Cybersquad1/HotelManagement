using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public class Customer : Human // Declaring a new class called 'Customer' with Public as protection level.
    {
        private int mobileNumber; // Declaring the variables inside the class, and setting it's protection level to Private.

        public int MobileNumber // This is the encapsulation of the property (MobileNumber).
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        private string email; // Declaring the variables inside the class, and setting it's protection level to Private.

        public string Email // This is the encapsulation of the property (Email).
        {
            get { return email; }
            set { email = value; }
        }


        public Customer() // This is the default constructor of the customer with default values/properties.
        {

        }

        public Customer(int mobileNumber, string email, string name, string surname, string address, string idNumber, int telephone)
            : base(name, surname, address, idNumber, telephone) // This is the overloaded constractor of the customer with the values below.
        {
            this.mobileNumber = mobileNumber;
            this.email = email;
        }

        public string GetInfo() // Get information
        {
            return Getinfo() + "\n Mob: " + mobileNumber + "\n E-Mail: " + email;
        }
    }
}
