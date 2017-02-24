using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{

    public class Booking_Date // Declaring a new class called 'Booking_Date' with Public as protection level.
    {
        private Employee emp;  // Declaring the variables inside the class, and setting it's protection level to Private.

        public Employee Emp // This is the encapsulation of the property (Employee).
        {
            get { return emp; }
        }

        private Customer cust;  // Declaring the variables inside the class, and setting it's protection level to Private.

        public Customer Cust // This is the encapsulation of the property (Customer).
        {
            get { return cust; } 
        }

        private DateTime dateFrom;  // Declaring the variables inside the class, and setting it's protection level to Private.

        public DateTime DateFrom // This is the encapsulation of the property (DateTime).
        {
            get { return dateFrom; }
            set { dateFrom = value; }
        }

        private DateTime dateTo;  // Declaring the variables inside the class, and setting it's protection level to Private.

        public DateTime DateTo // This is the encapsulation of the property (DateTime).
        {
            get { return dateTo; }
            set { dateTo = value; }
        }

        private Rooms room;  // Declaring the variables inside the class, and setting it's protection level to Private.

        public Rooms Room // This is the encapsulation of the property (Rooms).
        {
            get { return room; }
            set { room = value; }
        }

        private double bookingPrice;  // Declaring the variables inside the class, and setting it's protection level to Private.

        public double BookingPrice // This is the encapsulation of the property (BookingPrice).
        {
            get { return bookingPrice; }
            set { bookingPrice = value; }
        }

        private string BdId;  // Declaring the variables inside the class, and setting it's protection level to Private.

        public string BdId1 // This is the encapsulation of the property (BdId1). //BookingDays
        {
            get { return BdId; }
            set { BdId = value; }
        }

        public Booking_Date() // This is the default constructor of the BookingDate with default values/properties.
        {

        }

        public Booking_Date(Employee emp, Customer cust, DateTime dateFrom, DateTime dateTo, Rooms room, double bookingPrice, string bdId) // This is the overloaded constractor of the bill with the values below.
        {
            this.emp = emp;
            this.cust = cust;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.room = room;
            this.bookingPrice = bookingPrice;
            this.BdId = bdId;
        }

        public double GetBookingPrice(double bookingDays, double roomPrice) // Getting the price of the room and multiplying them per days. Has two inputs.
        {
            double tmpBookingPrice = roomPrice * bookingDays;

            return tmpBookingPrice;
        }

        public string GetInfo() // Get information
        {
            return 
                    "\nDate From: " + dateFrom + "\n" +
                    "Date To: " + dateTo + "\n" +
                    "Room: " + room.RoomNo + "\n" +
                    "Price:  €" + bookingPrice;
        }
    }
}
