using System.Security.Cryptography;
using System.Text;

namespace FINALPROJECT_inventory_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbProducts.Checked = true;
        }

        public void InterfaceMapping()
        {
            if (rbProducts.Checked)
            {
                lbField1.Text = "Name: ";
                lbField2.Text = "Description: ";
                lbField3.Text = "Category: ";
                lbField4.Text = "Unit Price: ";
                lbField1.Show();
                lbField2.Show();
                lbField3.Show();
                lbField4.Show();

                tbField1.Show();
                tbField2.Show();
                tbField3.Show();
                tbField4.Show();

                lbDelProd.Show();
                tbDelProd.Show();
                lbDelLoc.Hide();
                tbDelLoc.Hide();
            }
            else if (rbLocations.Checked)
            {
                lbField1.Text = "Name: ";
                lbField2.Text = "Address: ";
                lbField3.Text = "Type: ";
                lbField4.Text = "";
                lbField1.Show();
                lbField2.Show();
                lbField3.Show();
                lbField4.Hide();

                tbField1.Show();
                tbField2.Show();
                tbField3.Show();
                tbField4.Hide();

                lbDelProd.Hide();
                tbDelProd.Hide();
                lbDelLoc.Show();
                tbDelLoc.Show();
            }
            else
            {
                lbField1.Text = "ProductID: ";
                lbField2.Text = "LocationID: ";
                lbField3.Text = "Quantity: ";
                lbField4.Text = "";
                lbField1.Show();
                lbField2.Show();
                lbField3.Show();
                lbField4.Hide();

                tbField1.Show();
                tbField2.Show();
                tbField3.Show();
                tbField4.Hide();

                lbDelProd.Show();
                tbDelProd.Show();
                lbDelLoc.Show();
                tbDelLoc.Show();
            }

        }

        private void rbProducts_CheckedChanged(object sender, EventArgs e)
        {
            InterfaceMapping();
        }



        /*if user wants to do CRUD on products



         try
        {
           Convert.ToDouble(price)

         //Validation product = new Validation(name, desc,category, price)
        }
        catch
        {
            print "Price must be number"
        }

         */



        //if user wants to do CRUD on Locations
        //Validation product = new Validation(Name, address, Type)


        /*if user wants to do CRUD on Stock       
          try
         {
            Convert.ToDouble(quantity)

          Validation product = new Validation(ProductID(?), LocationID(?), Quantity)
         }
         catch
         {
             print "Quantity must be number"
         }


          */
    }
}

