using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Assignment
{
    public partial class RoomServiceForm : Form
    {
        //Declaring vaiables
        private Employee emp;

        private double tmptotal = 0;
        private Customer cust;
        private RoomService roomService;
        private FoodItems prawn, margerita, tortellini, beef, peasoup, hamSandwich;
        private FoodType seafood,pizza,pasta,meat,soups,sandwiches;
        private int quantity;
        private List<FoodItems> lstFoodItems;

        public RoomServiceForm()
        {
            InitializeComponent();
            cust = (Customer)cbxCustomer.SelectedValue;
            roomService = new RoomService(cust, lstFoodItems);
            lstFoodItems = new List<FoodItems>();

            seafood = FoodType.Seafood;
            pizza = FoodType.Pizza;
            pasta = FoodType.Pasta;
            meat = FoodType.Meat;
            soups = FoodType.Soups;
            sandwiches = FoodType.Sandwiches;

            prawn = new FoodItems(seafood, quantity, "Prawn Platter", 15.25);
            margerita = new FoodItems(pizza, quantity, "Margerita Pizza", 9.50);
            tortellini = new FoodItems(pasta, quantity, "Tortellini", 12.30);
            beef = new FoodItems(meat, quantity, "250g Of Beef", 25.75);
            peasoup = new FoodItems(soups, quantity, "Pea Soup", 8.23);
            hamSandwich = new FoodItems(sandwiches, quantity, "Ham And Cheese Sandwich", 4.35);

            cbxFood.Items.Add(prawn.GetInfo());
            cbxFood.Items.Add(margerita.GetInfo());
            cbxFood.Items.Add(tortellini.GetInfo());
            cbxFood.Items.Add(beef.GetInfo());
            cbxFood.Items.Add(peasoup.GetInfo());
            cbxFood.Items.Add(hamSandwich.GetInfo());
        }
        public RoomServiceForm(Employee emp):this()
        {
            this.emp = emp;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintRoomServiceBill();
        }

        private void RoomServiceForm_Load(object sender, EventArgs e)
        {
            this.tblCustomerTableAdapter1.Fill(this.customerDS1.tblCustomer);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Order o = new Order(emp);
            this.Hide();
            o.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             if (cbxFood.SelectedIndex == 0 && Int32.TryParse(txtQuantity.Text,out quantity))
            {
                prawn = new FoodItems(seafood, quantity, "Prawn Platter", 15.25);
                lstFoodItems.Add(prawn);
                lstFood.Items.Add(prawn.GetInfo() + " Type: " + prawn.Typ.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + prawn.GetPrice(quantity).ToString());
            }
            if (cbxFood.SelectedIndex == 1 && Int32.TryParse(txtQuantity.Text,out quantity))
            {
                margerita = new FoodItems(pizza, quantity, "Margerita Pizza", 9.50);
                lstFoodItems.Add(margerita);
                lstFood.Items.Add(margerita.GetInfo() + " Type: " + margerita.Typ.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + margerita.GetPrice(quantity).ToString());
            }
            if (cbxFood.SelectedIndex == 2 && Int32.TryParse(txtQuantity.Text,out quantity))
            {
                tortellini = new FoodItems(pasta, quantity, "Tortellini", 12.30);
                lstFoodItems.Add(tortellini);
                lstFood.Items.Add(tortellini.GetInfo() + " Type: " + tortellini.Typ.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + tortellini.GetPrice(quantity).ToString());
            }
            if (cbxFood.SelectedIndex == 3 && Int32.TryParse(txtQuantity.Text,out quantity))
            {
                beef = new FoodItems(meat, quantity, "250g Of Beef", 25.75);
                lstFoodItems.Add(beef);
                lstFood.Items.Add(beef.GetInfo() + " Type: " + beef.Typ.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + beef.GetPrice(quantity).ToString());
            }
            if (cbxFood.SelectedIndex == 4 && Int32.TryParse(txtQuantity.Text,out quantity))
            {
                peasoup = new FoodItems(soups, quantity, "Pea Soup", 8.23);
                lstFoodItems.Add(peasoup);
                lstFood.Items.Add(peasoup.GetInfo() + " Type: " + peasoup.Typ.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + peasoup.GetPrice(quantity).ToString());
            }
            if (cbxFood.SelectedIndex == 5 && Int32.TryParse(txtQuantity.Text,out quantity))
            {
                hamSandwich = new FoodItems(sandwiches, quantity, "Ham And Cheese Sandwich", 4.35);
                lstFoodItems.Add(hamSandwich);
                lstFood.Items.Add(hamSandwich.GetInfo() + " Type: " + hamSandwich.Typ.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + hamSandwich.GetPrice(quantity).ToString());
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu(emp);
            this.Hide();
            m1.ShowDialog();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (FoodItems item in lstFoodItems)
            {
                tmptotal += item.GetPrice(item.Quantity);
            }

            lstFood.Items.Add("\n Total Price Of Bill: €" + tmptotal);
            btnAdd.Enabled = false;
            btnCalculate.Enabled = false;
            MessageBox.Show("\n Total Price Of Bar : €" + tmptotal.ToString());
        }
        public void PrintRoomServiceBill()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
            DialogResult result = printDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK)
                {

                    printDocument.Print();
                }
            }
            catch
            {
                MessageBox.Show("Printing has a problem!");
            }
        }

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Cambria", 12);
            float FontHeight = font.GetHeight();

            int startX = 17;
            int startY = 17;


            graphic.DrawString("HOTELS ROOM SERVICE BILL \n", new Font("Cambria", 22), new SolidBrush(Color.Black), startX, startY);

            string strText = "\n";
            foreach (object x in lstFood.Items)
            {
                strText = strText + x.ToString() + "\n";
            }
            graphic.DrawString("\n" + strText, new Font("Cambria", 22), new SolidBrush(Color.Black), startX, startY);



        }
        }
    
}
