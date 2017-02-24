using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public class BarItems : ConsumableItems // Declaring a new class called 'Bar_Items' with Public as protection level.
    {
        private BarItemType type; // Declaring the variables inside the class, and setting it's protection level to Private.

        public BarItemType Type // This is the encapsulation of the property (Bar_Item_type).
        {
            get { return type; }
            set { type = value; }
        }

        private int quantity; // Declaring the variables inside the class, and setting it's protection level to Private.

        public int Quantity // This is the encapsulation of the property (Quantity).
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public BarItems() // This is the default constructor of the BarItems with default values/properties.
        {

        }

        public BarItems(BarItemType type, int quantity, string itemName, double price)
            : base(itemName, price) // This is the overloaded constractor of the BarItems with the values below.
        {
            this.type = type;
            this.ItemName = itemName;
            this.Price = price;
            this.quantity = quantity;
        
        }

        public override double GetPrice(double quantity) // Overridden method that gets the price and has an input of quantity which has a datatype of double. 
        {
            double tmpPrice = Price * quantity;
            return tmpPrice;
        }
  
    }
}
