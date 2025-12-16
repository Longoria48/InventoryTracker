using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace FINALPROJECT_inventory_
{
    internal class SqlActions
    {

        //private string connectionString = @"Data Source = BB21305\OOP_SQL_JM; Initial Catalog = LoginSystem; User ID = LibraryUser; Password = LibraryLab123!; TrustServerCertificate = True";
        private string connectionString = @"Data Source = BB21305\OOP_SQL_JM; Initial Catalog = GameShopDB; User ID = LibraryUser; Password = classOOP123!; TrustServerCertificate = True";


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


        //Update For (?) -- NEEDS FINISHED
        public void update()
        {
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();
        }
    }
}
