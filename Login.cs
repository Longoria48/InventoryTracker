using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FINALPROJECT_inventory_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            string username = usernameTB.Text.Trim();
            string password = passwordTB.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                msgLabel.Text = "Please enter all fields.";
                return;
            }

            password = encryptPassword(password);

            SqlActions userLogin = new SqlActions();

            //check if user exists
            if (userLogin.checkExisting(username))  //does exist
            {
                //check if password matches DB password
                bool pwrdMatch = userLogin.checkPassword(username, password);

                if (pwrdMatch)
                {
                    //closes form1 (login form)
                    this.Hide();

                    //creates form2 obj
                    Form1 crudForm = new Form1();
                    //opens form2
                    crudForm.Show();

                    return;
                }
                msgLabel.Text = "Incorrect Password. Try again.";
            }
            else
            {
                msgLabel.Text = "User does not exist. Try again.";
            }
        }

        public string encryptPassword(string password)
        {
            //using discards obj after use
            //creates hashing obj
            using (SHA256 sha = SHA256.Create())
            {
                //converts each char to its utf code / num
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                //calls the hashing method 
                byte[] hash = sha.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }

        #region Create Admin
        private void create_Click(object sender, EventArgs e)
        {

            string password = encryptPassword(passwordTB.Text.Trim());


            string connectionString = @"Data Source = localhost; Initial Catalog = GameShopDB; User ID = LibraryUser; Password = LibraryLab123!; TrustServerCertificate = True";


            SqlConnection currConnection = new SqlConnection(connectionString);
            currConnection.Open();


            string sqlStatement = "INSERT INTO Users(Username, Password) VALUES (@Username, @Password)";

            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);

            myQuery.Parameters.AddWithValue("@Username", usernameTB.Text.Trim());
            myQuery.Parameters.AddWithValue("@Password", password);

            myQuery.ExecuteNonQuery();

            currConnection.Close();

        }
        #endregion


        //Remove Before Submitting
        private void quickLogin_Click(object sender, EventArgs e)
        {
            //closes form1 (login form)
            this.Hide();

            //creates form2 obj
            Form1 crudForm = new Form1();
            //opens form2
            crudForm.Show();
        }
    }
}
