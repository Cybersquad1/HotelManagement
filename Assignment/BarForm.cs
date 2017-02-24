using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace Assignment
{
    public partial class BarForm : Form 
    {
        // Declaring the variables
        private double tmptotal = 0;
        private Customer cust;
        private Employee emp;
        private Bar bar;
        private BarItems cola, sprite, vodka;
        private BarItemType nonAlcholicTyp, alcholicTyp;
        private int quantity;
        private List<BarItems> lstItems;

        public BarForm()
        {
            InitializeComponent();
            cust = (Customer)cbxCustomer.SelectedValue; // Getting the values to the combo box.
            bar = new Bar(cust, lstItems); // Initializing a new bar. 
            lstItems = new List<BarItems>(); // Items in the bar. 
            
            nonAlcholicTyp = BarItemType.NonAlcaholic; // Enums
            alcholicTyp = BarItemType.Alcaholic; // Enums
           
            cola = new BarItems(nonAlcholicTyp,quantity, "Coca Cola", 1.20 ); // Items
            sprite = new BarItems(nonAlcholicTyp, quantity, "Sprite", 1.20); // Items
            vodka = new BarItems(alcholicTyp, quantity, "Vodka", 2.50); // Items

            cbxItem.Items.Add(cola.GetInfo()); // Adding the items in the combo box.
            cbxItem.Items.Add(sprite.GetInfo()); // Adding the items in the combo box.
            cbxItem.Items.Add(vodka.GetInfo()); // Adding the items in the combo box.

            
        }
        public BarForm(Employee emp) // Getting the employee from another form.
            : this() 
        {
            this.emp = emp; // Setting the empoyee from the other form to this form.
        }

        private void BarForm_Load(object sender, EventArgs e) 
        {
            this.tblCustomerTableAdapter1.Fill(this.customerDS1.tblCustomer); // Filling the information from the table of the customer. 
        }

        private void btnMenu_Click(object sender, EventArgs e) // Button that takes you to the menu. 
        {
            Menu m1 = new Menu(emp);
            this.Hide();
            m1.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                
            if (cbxItem.SelectedIndex == 0 && Int32.TryParse(txtQuantity.Text,out quantity)) // checking for selected index and getting the quantity
            {
                cola = new BarItems(nonAlcholicTyp, quantity,"Coca Cola", 1.20);
                lstItems.Add(cola); // adding cola to list of the bar
                barLst.Items.Add(cola.GetInfo() + " Type: " + cola.Type.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + cola.GetPrice(quantity).ToString()); // adding the items to the list and appears in the list of the form
               
            }

            if (cbxItem.SelectedIndex == 1 && Int32.TryParse(txtQuantity.Text, out quantity))
            {
                sprite = new BarItems(nonAlcholicTyp, quantity, "Sprite", 1.20);
                lstItems.Add(sprite);
                barLst.Items.Add(sprite.GetInfo() + " Type: " + sprite.Type.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + sprite.GetPrice(quantity).ToString());
               
            }
            if (cbxItem.SelectedIndex == 2 && Int32.TryParse(txtQuantity.Text, out quantity))
            {
                vodka = new BarItems(alcholicTyp, quantity, "Vodka", 2.50);
                lstItems.Add(vodka);
                barLst.Items.Add(vodka.GetInfo() + " Type: " + vodka.Type.ToString() + " Quantity: " + quantity.ToString() + "\n Total Price: €" + vodka.GetPrice(quantity).ToString());
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (BarItems item in lstItems) // Looping ever item in the lst items
            {
                tmptotal += item.GetPrice(item.Quantity);  //getting the total and adding it to the tmptotal                                                                                                                      
            }

            barLst.Items.Add("\n Total Price Of Bill: €" + tmptotal); // adding the items in the form of the list and the tmp total
            btnAdd.Enabled = false; // the  btnadd is disabled as the bill is already caluclated
            btnCalculate.Enabled = false; // the btncalculae is disabled as the bill is already calculated
            MessageBox.Show("\n Total Price Of Bar : €" + tmptotal.ToString()); // showing the total price on list that is on the form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Order o = new Order(emp); //Get you back to the order menus
            this.Hide();
            o.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintBarBill(); // Printing the bill
            btnPrint.Enabled = false; // setting the print btn to false only print once
        }

        //Open Print Dialog To Print A Documents
        public void PrintBarBill()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(pdoc_PrintPage); // Setting the print to print the docments
            DialogResult result = printDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK) // if result ok print dialogs
                {

                    printDocument.Print();
                }
            }
            catch
            {
                MessageBox.Show("Printing has a problem!"); // A problem is in the printers
            }
        }

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // The Doumentt to be printed
            Graphics graphic = e.Graphics;
            Font font = new Font("Cambria", 12);
            float FontHeight = font.GetHeight();

            int startX = 17;
            int startY = 17;


            graphic.DrawString("HOTELS BAR BILL \n", new Font("Cambria", 22), new SolidBrush(Color.Black), startX, startY);
            
            string strText = "\n";
            foreach (object x in barLst.Items) // looping to get all the items
             {
                 strText = strText + x.ToString() + "\n";
             }
            
            graphic.DrawString("\n"+strText, new Font("Cambria", 22), new SolidBrush(Color.Black), startX, startY);
  

            
        }
    }
}
