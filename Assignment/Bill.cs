using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public class Bill // Declaring a new class called 'Bill' with Public as protection level.
    {
        private Customer cust; // Declaring the variables inside the class, and setting it's protection level to Private.
        
        public Customer Cust // This is the encapsulation of the property (Customer).
        {
            get { return cust; }
            set { cust = value; }
        }

        private Employee emp; // Declaring the variables inside the class, and setting it's protection level to Private.

        public Employee Emp // This is the encapsulation of the property (Employee).
        {
            get { return emp; }
            set { emp = value; }
        }

        private Booking_Date bd; // Declaring the variables inside the class, and setting it's protection level to Private.

        public Booking_Date Bd // This is the encapsulation of the property (Booking_Date).
        {
            get { return bd; }
            set { bd = value; }
        }

        public Bill() // This is the default constructor of the Bill with default values/properties.
        {

        }

        public Bill(Customer cust, Employee emp, Booking_Date bd) // This is the overloaded constractor of the bill with the values below.
        {
            this.cust = cust;
            this.emp = emp;
            this.bd = bd;
        }
       
    }
}
