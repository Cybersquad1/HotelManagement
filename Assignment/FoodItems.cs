using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public class FoodItems : ConsumableItems  // Declaring a new class called 'Food_Items' with Public as protection level.
    {
        private FoodType typ; // Declaring the variables inside the class, and setting it's protection level to Private.

        public FoodType Typ // This is the encapsulation of the property (Food_Type).
        {
            get { return typ; }
            set { typ = value; }
        }

        private int quantity; // Declaring the variables inside the class, and setting it's protection level to Private.

        public int Quantity // This is the encapsulation of the property (Quantity).
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public FoodItems() // This is the default constructor of the FoodItems with default values/properties.
        {
            
        }


        public FoodItems(FoodType typ, int quantity, string itemName, double price) // This is the overloaded constractor of the bill with the values below.
        {
            this.typ = typ;
            this.quantity = quantity;
            this.ItemName = itemName;
            this.Price = price;
        }

        public override double GetPrice(double quantity) // This is an overriden method which inherits from the consumable items method.
        {
            double tmpPrice = Price * quantity;
            return tmpPrice;
        }
    }
}
