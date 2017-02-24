using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public class RoomService // Declaring a new class called 'Room_Service' with Public as protection level.
    {
        private Customer cust; // Declaring the variables inside the class, and setting it's protection level to Private.
        private List<FoodItems> foodItems; // Declaring the variables inside the class, and setting it's protection level to Private.

        public List<FoodItems> FoodItems // This is the encapsulation of the property (Food_Items)
        {
            get { return foodItems; }
            set { foodItems = value; }
        }

        public Customer Cust // This is the encapsulation of the property (Customer)
        {
            get { return cust; }
            set { cust = value; }
        }


        public RoomService() // This is the default constructor of the Room Service with default values/properties.
        {

        }

        public RoomService(Customer cust, List<FoodItems> foodItems) // This is the overloaded constractor of the bill with the values below.
        {
            this.cust = cust;
            this.foodItems = foodItems; 
        }
    }
}
