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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try 
                {
                    SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting);
                    sqlc.Open();
                    string query = "Select * From Managertbl Where UserName ='" + TXTusername.Text.Trim() + "' And Password ='" + TXTpassword.Text.Trim() + "'";
                    var da = new SqlDataAdapter(query, sqlc);
                    var dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Manager Successfully  Logged In.");
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        //System.Windows.MessageBox.Show("Something Went Wrong - Please Try Again.");
                        //TXTusername.Clear();
                        //TXTpassword.Clear();
                    }
                }
                catch(Exception ex)
                {
                    //stay
                }
                try
                {
                    SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting);
                    sqlc.Open();
                    string query = "Select * From Admint Where UserName ='" + TXTusername.Text.Trim() + "' And Password ='" + TXTpassword.Text.Trim() + "'";
                    var da = new SqlDataAdapter(query, sqlc);


                    var dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Admin Successfully  Logged In.");
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        //System.Windows.MessageBox.Show("Something Went Wrong - Please Try Again.");

                        //TXTusername.Clear();
                        //TXTpassword.Clear();
                    }
                }
                catch(Exception ex)
                {

                }
                try
                {
                    SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting);
                    sqlc.Open();
                    string query = "Select * From Mechanic Where UserName ='" + TXTusername.Text.Trim() + "' And Password ='" + TXTpassword.Text.Trim() + "'";
                    var da = new SqlDataAdapter(query, sqlc);


                    var dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Mechanic Successfully  Logged In.");
                        Mechanic mechanic = new Mechanic();
                        mechanic.Show();
                        this.Close();
                    }
                    else
                    {
                        //System.Windows.MessageBox.Show("Something Went Wrong - Please Try Again.");

                        //TXTusername.Clear();
                        //TXTpassword.Clear();
                    }
                }
                catch(Exception ex)
                {

                }
                try
                {
                    SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting);
                  
                    sqlc.Open();
                    string query = "Select * From Drivertbl Where UserName ='" + TXTusername.Text.Trim() + "' And Password ='" + TXTpassword.Text.Trim() + "'";
                    var da = new SqlDataAdapter(query, sqlc);


                    var dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Driver Successfully  Logged In.");
                        Driver driver = new Driver();
                        driver.Show();
                        this.Close();
                    }
                    else
                    {
                        //System.Windows.MessageBox.Show("Something Went Wrong - Please Try Again.");

                        //TXTusername.Clear();
                        //TXTpassword.Clear();
                    }
                }
                catch(Exception ex)
                {

                }
                

            }
            catch (ArgumentNullException) { System.Windows.MessageBox.Show("Did Not Receive Values."); }
            catch (Exception)
            {
                MessageBox.Show("Check Connection.");
                TXTusername.Clear();
                TXTpassword.Clear();
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Registration popup = new Registration();
            popup.Show();
        }

        private void TXTusername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TXTpassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
