using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public abstract class ConsumableItems // Declaring a new class called 'Consumable_Items' with Public as protection level.
    {
        private string itemName; // Declaring the variables inside the class, and setting it's protection level to Private.

        protected string ItemName // This is the encapsulation of the property (Item_Name)
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private double price; // Declaring the variables inside the class, and setting it's protection level to Private.

        protected double Price // This is the encapsulation of the property (Price)
        {
            get { return price; }
            set { price = value; }
        }


        public ConsumableItems() // This is the default constructor of the ConsumableItems with default values/properties.
        {
               
        }

        public ConsumableItems(string itemName, double price) // This is the overloaded constractor of the bill with the values below.
        {
            this.itemName = itemName;
            this.price = price;
        }

        public string GetInfo() // Get info method, gets the information.
        {
            return "Item Name: " + itemName + "\n " + " Price: €" + price;
        }

        public abstract double GetPrice(double a); //Abstract class with one input. 
    }
}
