using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace Assignment
{
    public class Bar // Declaring a new class called 'Bar' with Public as protection level.
    {
        private Customer cust; // Declaring the variables inside the class, and setting it's protection level to Private.

        private List<BarItems> lstBarItems; // Declaring the variables inside the class, and setting it's protection level to Private.

        public List<BarItems> LstBarItems // This is the encapsulation of the property (Bar_Items)
        {
          get { return lstBarItems; }
          set { lstBarItems = value; }
        }

        public Customer Cust // This is the encapsulation of the property (Customer)
        {
            get { return cust; }
            set { cust = value; }
        }


        public Bar() // This is the default constructor of the Bar with default values/properties.
        {

        }

        public Bar(Customer cust, List<BarItems> lstBarItems) // This is the overloaded constractor of the bill with the values below.
        {
            this.cust = cust;
            this.lstBarItems = lstBarItems;
        }


    }
}
