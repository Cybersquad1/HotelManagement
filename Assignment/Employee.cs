using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public class Employee : Human // Declaring a new class called 'Employee' with Public as protection level.
    {
        private string niNumber; // Declaring the variables inside the class, and setting it's protection level to Private.

        public string NiNumber // This is the encapsulation of the property (NiNumber).
        {
            get { return niNumber; }
            set { niNumber = value; }
        }

        private string user; // Declaring the variables inside the class, and setting it's protection level to Private.

        public string User // This is the encapsulation of the property (User).
        {
            get { return user; }
            set { user = value; }
        }

        private string pass; // Declaring the variables inside the class, and setting it's protection level to Private. (admin, admin)

        public string Pass // This is the encapsulation of the property (Pass).
        {
            get { return pass; }
            set { pass = value; }
        }

        public Employee()  // This is the default constructor of the employee with default values/properties.
        {

        }

        public Employee(string niNumber, string name, string surname, string address, string idNumber, int telephone,string user, string pass)
            : base(name, surname, address, idNumber, telephone) // This is the overloaded constractor of the employee with the values below.
        {
            this.niNumber = niNumber;
            this.user = user;
            this.pass = pass;
        }

        public string GetInfo() // Get information. 
        {
            return  Getinfo () + "\nNi Number: " + niNumber + "\nUsername: " + user;
        }
    }
}
