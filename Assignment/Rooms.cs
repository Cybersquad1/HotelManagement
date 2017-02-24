using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{

    public class Rooms // Declaring a new class called 'Rooms' with Public as protection level.
    {

        private RoomNo roomNo; // Declaring the variables inside the class, and setting it's protection level to Private.

        public RoomNo RoomNo // This is the encapsulation of the propertRoomNo).
        {
            get { return roomNo; }
            set { roomNo = value; }
        }


        private RoomType type; // Declaring the variables inside the class, and setting it's protection level to Private.

        public RoomType Type // This is the encapsulation of the property (RoomType).
        {
            get { return type; }
            set { type = value; }
        }

        private double roomPrice; // Declaring the variables inside the class, and setting it's protection level to Private.

        public double RoomPrice // This is the encapsulation of the property (RoomPrice).
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }

        private List<Booking_Date> bd; // Declaring the variables inside the class, and setting it's protection level to Private.

        public List<Booking_Date> Bd // This is the encapsulation of the property (Booking_Date).
        {
          get { return bd; }
          set { bd = value; }
        }


        public Rooms() // This is the default constructor of the Rooms with default values/properties.
        {

        }

        public Rooms(RoomNo roomNo, RoomType type, double roomPrice, List<Booking_Date> bd) // This is the overloaded constractor of the bill with the values below.
        {
            this.roomNo = roomNo;
            this.type = type;
            this.roomPrice = roomPrice;
            this.bd = bd;
        }
        
        public double GetRoomPrice(RoomType typ) // Method to get the room price. 
        {
            double tmpRoomPrice = 0;

            if (typ == RoomType.Single)
            {
                tmpRoomPrice = 10.00;
                return tmpRoomPrice;
            }

            if (typ == RoomType.Double)
            {
                tmpRoomPrice = 20.00;
                return tmpRoomPrice;
            }

            if (typ == RoomType.Triple)
            {
                tmpRoomPrice = 30.00;
                return tmpRoomPrice;
            }
            return tmpRoomPrice;
            
        }
    }
}
