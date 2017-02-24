using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class test : Form
    {
        //Declaring Variables 
        private List<ConsumableItems> item;
        private Employee emp;
        public test()
        {
            InitializeComponent();
             // Adding the ranges in the comboboxes from the enumaration
            cbxFoodType.Items.AddRange(Enum.GetNames(typeof(FoodType)));

            cbxDrinkType.Items.AddRange(Enum.GetNames(typeof(BarItemType)));

            //Setting The Comboxes to disabled  when Load
            cbxDrinkType.Enabled = false; 
            cbxFoodType.Enabled = false;

            item = new List<ConsumableItems>(); // Creating a new instance
        } 
        public test(Employee emp):this()
        {
            this.emp = emp; // Getting The Employee From The Previous Form
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedItem.ToString() == "Drinks") // Check for the selected Item if drinks enable the drink type
            {
                cbxDrinkType.Enabled = true;
                cbxFoodType.Enabled = false;
            }
            else if (cbxType.SelectedItem.ToString() == "Food") // Same goes here but for the food Type
            {
                cbxFoodType.Enabled = true;
                cbxDrinkType.Enabled = false;
            }

            else // If non selected both ares disabled
            {
                cbxDrinkType.Enabled = false;
                cbxFoodType.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu(emp); //Goes back to menu
            this.Hide();
            m1.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxType.SelectedItem.ToString() == "Drinks") // If selected item is drinks
            {
              // Add the new item with the properities Inputted
                item.Add(new BarItems( (BarItemType)Enum.Parse(typeof(BarItemType), cbxDrinkType.SelectedItem.ToString()),1,txtItem.Text,double.Parse(txtPrice.Text)));
            }
            
            if (cbxType.SelectedItem.ToString() == "Food")
            {
                // Add the new item with the properities Inputted
                item.Add(new FoodItems( (FoodType)Enum.Parse(typeof(FoodType), cbxFoodType.SelectedItem.ToString()),1,txtItem.Text,double.Parse(txtPrice.Text)));
            }
            MessageBox.Show("Added new Item in the Test Form, Items Till Now:" + item.Count.ToString()); // Show the count of the items up till now
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            foreach (ConsumableItems i in item) // Looping for each consumable Items 
            {
                if (i.GetType() == typeof(FoodItems)) //  If item is of type Food
                {
                    FoodItems tmp = (FoodItems)i;   // Parsing from consumable items tp Food
                    MessageBox.Show(tmp.GetInfo()); // POLYMORPHISM (Shows All info)
                }
                if (i.GetType() == typeof(BarItems)) // If the item is of type drinks
                {
                    BarItems tmp = (BarItems)i; //Parsing from consumable items to food
                    MessageBox.Show(tmp.GetInfo()); // POLYMORPHISM (Shows All info) Method Chnages Form
                }
            }
        }

        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
