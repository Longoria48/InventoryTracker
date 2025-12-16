using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace FINALPROJECT_inventory_
{
    public partial class Form1 : Form
    {
        private int selectedProductId = -1;
        private int selectedLocationId = -1;

        //Create SQLActions object
        private readonly SqlActions db = new SqlActions();
        public Form1()
        {
            InitializeComponent();
            rbProducts.Checked = true;
            InterfaceMapping();
            RefreshGrid();
        }

        //Refresh Grid based on selected radiobtn
        private void RefreshGrid()
        {
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
           // dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           // dgvResults.MultiSelect = false;
            dgvResults.AllowUserToAddRows = false;
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
            else if (rbStock.Checked)
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
        public void ClearFields()
        {
            tbField1.Clear();
            tbField2.Clear();
            tbField3.Clear();
            tbField4.Clear();
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
                    db.InsertProduct(v.name, tbField2.Text.Trim(), tbField3.Text.Trim(), Convert.ToDecimal(tbField4.Text));
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
                    db.InsertLocation(tbField1.Text.Trim(), tbField2.Text.Trim(), tbField3.Text.Trim());
                    RefreshGrid();
                }
                else if (rbStock.Checked)
                {
                    if (!int.TryParse(tbField1.Text.Trim(), out int productId))
                    {
                        MessageBox.Show("ProductID must be a whole number.");
                        return;
                    }

                    if (!int.TryParse(tbField2.Text.Trim(), out int locationId))
                    {
                        MessageBox.Show("LocationID must be a whole number.");
                        return;
                    }

                    if (!int.TryParse(tbField3.Text.Trim(), out int qty))
                    {
                        MessageBox.Show("Quantity must be a whole number.");
                        return;
                    }

                    Validation v = new Validation(qty);
                    string msg = v.checkValues();
                    if (msg != "")
                    {
                        MessageBox.Show(msg);
                        return;
                    }
                    db.InsertStock(productId, locationId, qty);
                    RefreshGrid();
                }
                ClearFields();
                RefreshGrid();
                selectedProductId = -1;
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
            try
            {
                if (rbProducts.Checked)
                {
                    if (selectedProductId < 0)
                    {
                        MessageBox.Show("Click a product row to select it first.");
                        return;
                    }

                    db.DeleteProduct(selectedProductId);
                }
                else if (rbLocations.Checked)
                {
                    if (selectedLocationId < 0)
                    {
                        MessageBox.Show("Click a location row to select it first.");
                        return;
                    }

                    db.DeleteLocation(selectedLocationId);
                }
                else if (rbStock.Checked)
                {
                    if (selectedProductId < 0 || selectedLocationId < 0)
                    {
                        MessageBox.Show("Click a stock row to select it first.");
                        return;
                    }

                    db.DeleteStock(selectedProductId, selectedLocationId);
                }
                //Reset selected ids
                selectedProductId = -1;
                selectedLocationId = -1;

                RefreshGrid();
                ClearFields();
                tbField1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Click Event for dgv (Autofill fields & allow for click delete)
        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // clicked header
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvResults.Rows[e.RowIndex];

            if (rbProducts.Checked)
            {
                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);

                tbField1.Text = row.Cells["Name"].Value?.ToString();
                tbField2.Text = row.Cells["Description"].Value?.ToString();
                tbField3.Text = row.Cells["Category"].Value?.ToString();
                tbField4.Text = row.Cells["UnitPrice"].Value?.ToString();
            }
            else if (rbLocations.Checked)
            {
                selectedLocationId = Convert.ToInt32(row.Cells["LocationID"].Value);

                tbField1.Text = row.Cells["Name"].Value?.ToString();
                tbField2.Text = row.Cells["Address"].Value?.ToString();
                tbField3.Text = row.Cells["Type"].Value?.ToString();
                tbField4.Clear();
            }
            else if (rbStock.Checked)
            {
                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
                selectedLocationId = Convert.ToInt32(row.Cells["LocationID"].Value);

                //Stock grid includes ProductID, ProductName, LocationID, LocationName, Quantity
                tbField1.Text = row.Cells["ProductID"].Value?.ToString();
                tbField2.Text = row.Cells["LocationID"].Value?.ToString();
                tbField3.Text = row.Cells["Quantity"].Value?.ToString();
                tbField4.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}

