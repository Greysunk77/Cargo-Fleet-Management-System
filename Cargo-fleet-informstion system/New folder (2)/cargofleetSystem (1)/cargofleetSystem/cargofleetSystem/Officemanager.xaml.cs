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
    /// Interaction logic for Officemanager.xaml
    /// </summary>
    public partial class Officemanager : Window
    {
        public Officemanager()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
            {
                //sqlc.Open();
                //string sqlcom = "INSERT INTO [dbo].[AssignmentTABLE] VALUES(@DriverID,@VehicleID,@Vehicle_Registration,@Site,@Destination,@Date,@Time)" ;
                //SqlCommand cmd = new SqlCommand(sqlcom, sqlc);
                //cmd.Parameters.AddWithValue("@DriverID", DriverID.Text.Trim());
                //cmd.Parameters.AddWithValue("@VehicleID", vehicleID.Text.Trim());
                //cmd.Parameters.AddWithValue("@Vehicle_Registration", Vregistration.Text.Trim());
                //cmd.Parameters.AddWithValue("@Site", Site.Text.Trim());
                //cmd.Parameters.AddWithValue("@Destination", Destination.Text.Trim());
                //cmd.Parameters.AddWithValue("@Date", Date.SelectedDate);
                //cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(Time.Text.Trim()));
                ////DateTime time = Convert.ToDateTime(Time.Text.Trim());
                ////cmd.Parameters.AddWithValue("@Time", time);
                
                //cmd.CommandType = CommandType.Text;
                //cmd.ExecuteNonQuery();
                //sqlc.Close();
                MessageBox.Show("Assigned to Driver.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
