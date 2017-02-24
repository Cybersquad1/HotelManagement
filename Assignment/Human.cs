using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public abstract class Human // Declaring a new class called 'Human' with Public as protection level.
    {
        protected string name, surname, address, idNumber;  // Declaring the variables inside the class, and setting it's protection level to Protected.
        protected int telephone;  // Declaring the variables inside the class, and setting it's protection level to Protected.

        public int Telephone // This is the encapsulation of the property (Telephone).
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Name // This is the encapsulation of the property (Name).
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname // This is the encapsulation of the property (Surname).
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Address // This is the encapsulation of the property (Address).
        {
            get { return address; }
            set { address = value; }
        }

        public string IdNumber // This is the encapsulation of the property (IdNumber).
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        public Human() //  // This is the default constructor of the Human with default values/properties.
        {
            this.name = "";
            this.surname = "";
            this.address = "";
            this.idNumber = "";
            this.telephone = 00000000;
        }

        public Human(string name, string surname, string address, string idNumber, int telephone)
            : this() // This is the overloaded constractor of the human with the values below.
        {
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.idNumber = idNumber;
            this.telephone = telephone;
        }

        public string Getinfo() // Get information. 
        {
            return "Name: " + name + "\n" + "Surname: " + surname + "\n" + "Address: " + address + "\n" + "IdNumber: " + idNumber + "\n" + "Telephone: " + telephone;
        }

 
        
    }
}
