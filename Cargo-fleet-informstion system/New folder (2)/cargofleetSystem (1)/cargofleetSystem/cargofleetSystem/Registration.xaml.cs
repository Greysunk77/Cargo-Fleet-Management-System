using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace cargofleetSystem
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!(txtName1.Text.Trim() == "" || txtSurname1.Text.Trim() == "" || txtUsername1.Text.Trim() == "" || txtPassword1.Text.Trim() == ""))
            {
                //using (SqlConnection sqlc = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cargo_Fleet_Database;Integrated Security=True"))
                //{
                //sqlc.Open();
                //SqlCommand sqlcom = new SqlCommand(@"INSERT INTO [dbo].[UserRegistration]
                //([UserRegistrationID],[Name],[Surname],[UserName],[Password]) VALUES ('"
                //+ txtName1.Text.Trim() + "','" + txtSurname1.Text.Trim() + "','" + txtUsername1.Text.Trim() + "','" + txtPassword1.Text.Trim() + "')", sqlc);
                //sqlcom.CommandType = CommandType.Text;
                //sqlc.Close();
                //MessageBox.Show("Data Registred.");
                //}
                if (ManagerRadio.IsChecked is true)
                {
                    using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
                    {
                        sqlc.Open();
                        string inn = "INSERT INTO [dbo].[Managertbl] VALUES(@Name,@Surname,@UserName,@Password)";
                        SqlCommand cmd = new SqlCommand(inn, sqlc);
                        cmd.Parameters.AddWithValue("@Name", txtName1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Surname", txtSurname1.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtUsername1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword1.Text.Trim());
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        sqlc.Close();
                        MessageBox.Show("Manager Data Registred.");
                        txtName1.Clear();
                        txtSurname1.Clear();
                        txtUsername1.Clear();
                        txtPassword1.Clear();
                    }
                }

                if (AdminRadio.IsChecked is true)
                {
                    using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
                    {
                        sqlc.Open();
                        string inn = "INSERT INTO [dbo].[Admint] VALUES(@Name,@Surname,@UserName,@Password)";
                        SqlCommand cmd = new SqlCommand(inn, sqlc);
                        cmd.Parameters.AddWithValue("@Name", txtName1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Surname", txtSurname1.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtUsername1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword1.Text.Trim());
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        sqlc.Close();
                        MessageBox.Show("Admin Data Registred.");
                        txtName1.Clear();
                        txtSurname1.Clear();
                        txtUsername1.Clear();
                        txtPassword1.Clear();
                    }

                }
                if (DriverRadio.IsChecked is true)
                {
                    using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
                    {
                        sqlc.Open();
                        string inn = "INSERT INTO [dbo].[Drivertbl] VALUES(@Name,@Surname,@UserName,@Password)";
                        SqlCommand cmd = new SqlCommand(inn, sqlc);
                        cmd.Parameters.AddWithValue("@Name", txtName1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Surname", txtSurname1.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtUsername1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword1.Text.Trim());
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        sqlc.Close();
                        MessageBox.Show("Driver Data Registred.");
                        txtName1.Clear();
                        txtSurname1.Clear();
                        txtUsername1.Clear();
                        txtPassword1.Clear();
                    }
                }
                if (MachanicRadio.IsChecked is true)
                {
                    using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
                    {
                        sqlc.Open();
                        string inn = "INSERT INTO [dbo].[Mechanic] VALUES(@Name,@Surname,@UserName,@Password)";
                        SqlCommand cmd = new SqlCommand(inn, sqlc);
                        cmd.Parameters.AddWithValue("@Name", txtName1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Surname", txtSurname1.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtUsername1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword1.Text.Trim());
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        sqlc.Close();
                        MessageBox.Show("Mechanic Data Registred.");
                        txtName1.Clear();
                        txtSurname1.Clear();
                        txtUsername1.Clear();
                        txtPassword1.Clear();
                    }
                }
            }
            else { 
                MessageBox.Show("Fields Can't Be Empty.", "Error Encountered."); }


            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Login popup = new Login();
            popup.Show();
        }

        private void txtName1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
