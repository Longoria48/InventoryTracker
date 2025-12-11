using System;
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

        //Create Products
        public void insertProduct(string name, string desc, string category, double price)
        {
            currConnection = new SqlConnection(connectionString);

            currConnection.Open();

            sqlStatement = "INSERT INTO Products (Name, Description, Category, Price) VALUES (@Name, @Description, @Category, @Price)";

            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);

            myQuery.Parameters.AddWithValue("@Name", name);
            myQuery.Parameters.AddWithValue("@Description", desc);
            myQuery.Parameters.AddWithValue("@Category", category);
            myQuery.Parameters.AddWithValue("@Price", price);

            myQuery.ExecuteNonQuery();

            currConnection.Close();
        }




        //Create Locations
        public void insertLocation()
        {

        }

        //Create Stock(?)
        public void insertStock()
        {

        }



        //Read For All Tables
        public void readTable(string table)
        {
            currConnection = new SqlConnection(connectionString);

            currConnection.Open();

            sqlStatement = "SELECT * FROM @Table";

            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);

            myQuery.Parameters.AddWithValue("@Table", table);
            myQuery.ExecuteNonQuery();

            currConnection.Close();
        }


        //Delete For All Tables
        public void deleteData(string table, string field, string condition)
        {
            currConnection = new SqlConnection(connectionString);

            currConnection.Open();

            sqlStatement = "DELETE FROM @Table WHERE @Field = @Condition";

            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);

            myQuery.Parameters.AddWithValue("@Table", table);
            myQuery.Parameters.AddWithValue("@Field", field);
            myQuery.Parameters.AddWithValue("@Condition", condition);
            myQuery.ExecuteNonQuery();

            currConnection.Close();
        }


        //Update For (?) -- NEEDS FINISHED
        public void update()
        {
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();
        }
    }
}
