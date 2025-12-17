using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Collections.Generic;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINALPROJECT_inventory_
{
    public partial class Form1 : Form
    {
        //Create SQLActions object
        private readonly SqlActions db = new SqlActions();

        int prodID = -1;
        int locID = -1;

        TextBox[] updateFields;
        TextBox[] locStockFields;

        public Form1()
        {
            InitializeComponent();

            updateFields = new TextBox[] {upTB1, upTB2, upTB3, upTB4 };
            locStockFields = new TextBox[] {tbField1, tbField2, tbField3};

            rbProducts.Checked = true;
            InterfaceMapping();
            RefreshGrid();
        }

        public void InterfaceMapping()
        {
            ClearFields();

            if (rbProducts.Checked)
            {
                tbField4.Show();
                upTB4.Show();

                showFields(locStockFields, true, false);

                changeLabels("Name: ", "Description: ", "Category: ", "Unit Price: ");
            }
            else if (rbLocations.Checked)
            {
                tbField4.Hide();
                upTB4.Hide();

                showFields(locStockFields, false, true);

                changeLabels("Name: ", "Address: ", "Type: ", "");
            }
            else if (rbStock.Checked)
            {
                tbField4.Hide();
                upTB4.Hide();

                changeLabels("ProductID: ", "LocationID: ", "Quantity: ", "");
                showFields(locStockFields, true, true);
            }
        }


        private void rbProducts_CheckedChanged(object sender, EventArgs e)
        {
            InterfaceMapping();
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbProducts.Checked)
                {
                    Validation v = new Validation(tbField1.Text, tbField2.Text, tbField3.Text, tbField4.Text);
                    string msg = v.checkValues();

                    if (msg != "")
                    {
                        MessageBox.Show(msg);
                        return;
                    }
                    db.InsertProduct(v.name, v.description, v.category, v.price);
                    RefreshGrid();
                }
                else if (rbLocations.Checked)
                {
                    Validation v = new Validation(tbField1.Text, tbField2.Text, tbField3.Text);
                    string msg = v.checkValues();
                    if (msg != "")
                    {
                        MessageBox.Show(msg);
                        return;
                    }
                    db.InsertLocation(v.name, v.address, v.type);
                    RefreshGrid();
                }
                else if (rbStock.Checked)
                {
                    if (!int.TryParse(tbField1.Text.Trim(), out int productId))
                    {
                        MessageBox.Show("ID's must be a whole number.");
                        return;
                    }
                    if (!int.TryParse(tbField2.Text.Trim(), out int locationId))
                    {
                        MessageBox.Show("ID's must be a whole number.");
                        return;
                    }
                    else if (Convert.ToInt32(tbField3.Text) < 0)
                    {
                        MessageBox.Show("Quantity must be a positive number.");
                        return;
                    }
                    else
                    {
                        db.InsertStock(productId, locationId, Convert.ToInt32(tbField3.Text));
                        RefreshGrid();
                    }
                }
                ClearFields();
                RefreshGrid();
                dgvResults.ClearSelection();
                tbField1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool exists = CheckExistingProcess(tbDelProd, tbDelLoc);

            if (exists)
            {
                try
                {
                    if (rbProducts.Checked)
                    {
                        db.DeleteProduct(prodID);
                    }
                    else if (rbLocations.Checked)
                    {
                        db.DeleteLocation(locID);
                    }
                    else if (rbStock.Checked)
                    {
                        db.DeleteStock(prodID, locID);
                    }

                    RefreshGrid();
                    ClearFields();
                    tbField1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool exists = CheckExistingProcess(prodUpdTb, locUpdTb);

            if (exists)
            {
                List<string> fieldValues = new List<string>();
                try
                {
                    if (rbProducts.Checked)
                    {
                        //if ID exists, fill in the textboxes of that row for user
                        fieldValues = db.FillProductBoxes(prodID);

                        for (int i = 0; i < fieldValues.Count; i++)
                        {
                            updateFields[i].Text = fieldValues[i];
                        }
                    }
                    else
                    {
                        if(rbLocations.Checked)
                        {
                            fieldValues = db.FillLocationBoxes(locID);
                        }
                        else
                        {
                            upLbl1.Text = "Name: ";
                            upLbl2.Text = "Location: ";
                            upTB1.Enabled = false; upTB2.Enabled = false;
                            fieldValues = db.FillStockBoxes(prodID, locID);
                        }

                        for (int i = 0; i < fieldValues.Count; i++)
                        {
                            updateFields[i].Text = fieldValues[i];
                        }
                    }

                    btnUpdate.Enabled = true;
                
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbProducts.Checked)
            {
                Validation v = new Validation(upTB1.Text, upTB2.Text, upTB3.Text, upTB4.Text);
                string msg = v.checkValues();

                if (msg != "")
                {
                    MessageBox.Show(msg);
                    return;
                }
                db.UpdateProduct(v.name, v.description, v.category, v.price, prodUpdTb.Text);
                RefreshGrid();
            }
            else if (rbLocations.Checked)
            {
                Validation v = new Validation(upTB1.Text, upTB2.Text, upTB3.Text);
                string msg = v.checkValues();

                if (msg != "")
                {
                    MessageBox.Show(msg);
                    return;
                }
                db.UpdateLocation(v.name, v.address, v.type, locUpdTb.Text);
                RefreshGrid();
            }
            else if (rbStock.Checked)
            {
                if (!int.TryParse(upTB3.Text.Trim(), out int productId))
                {
                    MessageBox.Show("ID's must be a whole number.");
                    return;
                }
                if (!int.TryParse(upTB3.Text.Trim(), out int locationId))
                {
                    MessageBox.Show("ID's must be a whole number.");
                    return;
                }
                else if (Convert.ToInt32(upTB3.Text) < 0)
                {
                    MessageBox.Show("Quantity must be a positive number.");
                    return;
                }

                db.UpdateStock(Convert.ToInt32(prodUpdTb.Text), Convert.ToInt32(locUpdTb.Text), Convert.ToInt32(upTB3.Text));
                Console.WriteLine("Updated stock");
                RefreshGrid();
            }

            RefreshGrid();
            ClearFields();
            tbField1.Focus();        
        }

        //Refresh Grid based on selected radiobtn
        private void RefreshGrid()
        {
            prodID = -1;
            locID = -1;

            //Update Grid based on data
            if (rbProducts.Checked)
            {
                dgvResults.DataSource = db.GetProducts();
            }
            else if (rbLocations.Checked)
            {
                dgvResults.DataSource = db.GetLocations();
            }
            else if (rbStock.Checked)
            {
                dgvResults.DataSource = db.GetStockOnHand();
            }

            //Format Data Grid View
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResults.ReadOnly = true;
            dgvResults.AllowUserToAddRows = false;
        }
        public void showFields(Control[] fields, bool prodToggle, bool locToggle)
        {
            Control[] prodControls = new Control[] { lbDelProd, tbDelProd, prodUpdLbl, prodUpdTb };

            Control[] locControls = new Control[] { lbDelLoc, tbDelLoc, locUpdLbl, locUpdTb };


            foreach (Control field in fields)
            {
                field.Visible = true;
            }


            //hides / shows lables and textBoxes depending on what was passed in the params
            for(int i=0; i<prodControls.Length; i++)
            {
                prodControls[i].Visible = prodToggle;
                locControls[i].Visible = locToggle;
            }
        }

        public void changeLabels(string lbl1, string lbl2, string lbl3, string lbl4)
        {
            lbField1.Text = upLbl1.Text = lbl1;
            lbField2.Text = upLbl2.Text = lbl2;
            lbField3.Text = upLbl3.Text = lbl3;
            lbField4.Text = upLbl4.Text = lbl4;
        }
        public void ClearFields()
        {
            tbField1.Clear();
            tbField2.Clear();
            tbField3.Clear();
            tbField4.Clear();

            upTB1.Clear();
            upTB2.Clear();
            upTB3.Clear();
            upTB4.Clear();

            tbDelProd.Clear();
            tbDelLoc.Clear();
        }
       
        public bool CheckExistingProcess(TextBox prodTb, TextBox locTb)
        {
            if (string.IsNullOrWhiteSpace(prodTb.Text) && prodTb.Visible == true || (string.IsNullOrWhiteSpace(locTb.Text) && locTb.Visible == true))
            {
                MessageBox.Show("Enter ID", "Empty Field Warning");
                return false;
            }
            else
            {
                try
                {
                    if (prodTb.Visible == true)
                    {
                        prodID = Convert.ToInt32(prodTb.Text);
                    }

                    if (locTb.Visible == true)
                    {
                        locID = Convert.ToInt32(locTb.Text);
                    }

                    if ((prodID < 0 && prodTb.Visible == true) || (locID < 0 && locTb.Visible == true))
                    {
                        MessageBox.Show("ID must be a positive number", "Invalid Input");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("ID must be a whole number", "Invalid Input");
                    return false;
                }
            }

            bool exists = db.checkExisting(prodID, locID);

            if (exists)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Product or Location ID does not exist");
                return false;
            }
        }

        private void UpdateTab_Leave(object sender, EventArgs e)
        {
            upTB1.Enabled = true;
            upTB2.Enabled = true;
            btnUpdate.Enabled = false;
        }
    }
}

