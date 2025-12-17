using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Net;

namespace FINALPROJECT_inventory_
{
    internal class SqlActions
    {

        //private string connectionString = @"Data Source = BB21305\OOP_SQL_JM; Initial Catalog = LoginSystem; User ID = LibraryUser; Password = LibraryLab123!; TrustServerCertificate = True";
        private string connectionString = @"Data Source = localhost; Initial Catalog = GameShopDB; User ID = LibraryUser; Password = LibraryLab123!; TrustServerCertificate = True";


        #region Login

        private SqlConnection currConnection;
        private string sqlStatement ="";

        public bool checkExisting(string username)
        {
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            sqlStatement = "SELECT Username FROM Users WHERE Username = @Username";

            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
            myQuery.Parameters.AddWithValue("@Username", username);

            string usernameDB = (string)myQuery.ExecuteScalar();

            currConnection.Close();

            if (usernameDB == username)
            {
                return true; // User exists 
            }
            return false;
        }

        public bool checkPassword(string username, string password)
        {
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            sqlStatement = "SELECT Password FROM Users WHERE Username = @Username";

            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);

            myQuery.Parameters.AddWithValue("@Username", username);


            string passwordDB = (string)myQuery.ExecuteScalar();
            currConnection.Close();

            if (passwordDB == password)
            {
                return true;
            }
            return false;

        }
        #endregion

        #region Data - DataTable
        public DataTable GetProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT ProductID, Name, Description, Category, UnitPrice FROM Products;";

                using(SqlCommand cmd = new SqlCommand(sql, conn))
                using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetLocations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT LocationID, Name, Address, Type FROM Locations;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetStockOnHand()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT s.ProductID, p.Name AS ProductName,
                                      s.LocationID, l.Name AS LocationName,
                                      s.Quantity
                               FROM StockOnHand s
                               JOIN Products p ON p.ProductID = s.ProductID
                               JOIN Locations l ON l.LocationID = s.LocationID;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        #endregion

        #region Insert Sqls
        public void InsertProduct(string name, string desc, string category, decimal unitPrice)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Products(Name, Description, Category, UnitPrice)
                               VALUES (@Name, @Description, @Category, @UnitPrice);";

                using (SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", desc);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertLocation(string name, string address, string type)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Locations(Name, Address, Type)
                               VALUES (@Name, @Address, @Type);";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InsertStock(int productId, int locationId, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO StockOnHand(ProductID, LocationID, Quantity)
                               VALUES (@ProductID, @LocationID, @Quantity);";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@LocationID", locationId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion


        #region Delete Sqls
        //Delete For All Tables
        public void DeleteProduct(int productId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Products WHERE ProductID = @id;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();
                }

            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Products WHERE ProductID = @id;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();
                }

            }
        }
        public void DeleteLocation(int locationId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Locations WHERE LocationID = @id;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", locationId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStock(int productId, int locationId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM StockOnHand WHERE ProductID = @p AND LocationID = @l;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p", productId);
                    cmd.Parameters.AddWithValue("@l", locationId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        public bool checkExisting(int productID, int locationID)
        {
            //if one of the ID's == -1, it means it is not visbile on the form / not needed for an action
            bool prodExist = false;
            bool locExist = false;

            //checks if productID exists
            if (productID != -1)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT ProductID FROM Products WHERE ProductID = @productID;";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@productID", productID);
                        object prodID = cmd.ExecuteScalar();

                        if (prodID != null)
                        {
                            prodExist = true;
                        }
                    }
                }
            }

            if (locationID != -1)
            {
                //checks if locationID exists
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT LocationID FROM Locations WHERE LocationID = @locationID;";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@locationID", locationID);
                        object locID = cmd.ExecuteScalar();

                        if (locID != null)
                        {
                            locExist = true;
                        }
                    }
                }
            }

            //For Stock: check if both ID's exist in DB AND if they are both visible in form
            if (productID != -1 && locationID !=-1)
            {
                return (prodExist && locExist);               
            }

            //runs for others
            else if (prodExist || locExist)
            {
                return true;
            }
            return false;
        }

        #region Update Sqls
        public void UpdateProduct(string name, string desc, string category, decimal price, string prodID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE Products SET Name = @Name, Description = @Description, Category = @Category, UnitPrice = @UnitPrice WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", desc);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@UnitPrice", price);
                    cmd.Parameters.AddWithValue("@ProductID", prodID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateLocation(string name, string address, string type, string locID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE Locations SET Name = @Name, Address = @Address, Type = @Type WHERE LocationID = @LocationID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@LocationID", locID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStock(int prodID, int locID, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE StockOnHand SET Quantity = @Quantity WHERE ProductID = @prodID AND LocationID = @locID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@prodID", prodID);
                    cmd.Parameters.AddWithValue("@locID", locID);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Fill TextBoxes For Update
        public List<string> FillProductBoxes(int productID)
        {
            List<string> dataValues = new List <string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Name, Description, Category, UnitPrice FROM Products WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dataValues.Add(reader["Name"].ToString());
                            dataValues.Add(reader["Description"].ToString());
                            dataValues.Add(reader["Category"].ToString());
                            dataValues.Add(reader["UnitPrice"].ToString());
                        }
                        return dataValues;
                    }
                }
            }
        }
        public List<string> FillLocationBoxes(int locationID)
        {
            List<string> dataValues = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Name, Address, Type FROM Locations WHERE LocationID = @LocationID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@LocationID", locationID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dataValues.Add(reader["Name"].ToString());
                            dataValues.Add(reader["Address"].ToString());
                            dataValues.Add(reader["Type"].ToString());
                        }
                        return dataValues;
                    }
                }
            }
        }
        public List<string> FillStockBoxes(int productID, int locationID)
        {
            List<string> dataValues = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT p.Name AS ProductName,
                                      l.Name AS LocationName,
                                      s.Quantity
                               FROM StockOnHand s
                               JOIN Products p ON p.ProductID = s.ProductID
                               JOIN Locations l ON l.LocationID = s.LocationID
                               WHERE s.ProductID = @ProductID
                                   AND s.LocationID = @LocationID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@LocationID", locationID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dataValues.Add(reader["ProductName"].ToString());
                            dataValues.Add(reader["LocationName"].ToString());
                            dataValues.Add(reader["Quantity"].ToString());
                        }
                        
                    }
                }
                return dataValues;
            }
        }
        #endregion
    }
}