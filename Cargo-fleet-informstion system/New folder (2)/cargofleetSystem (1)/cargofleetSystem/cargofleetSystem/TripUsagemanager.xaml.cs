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
    /// Interaction logic for TripUsagemanager.xaml
    /// </summary>
    public partial class TripUsagemanager : Window
    {
        public TripUsagemanager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow popup = new MainWindow();
            popup.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
             using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
            {
                sqlc.Open();
                string sqlcom = "INSERT INTO[dbo].[Vehicle_Trip]VALUES(@Schedule,@Fuel_Usage,@Incidents,@Distance)";
                SqlCommand cmd = new SqlCommand(sqlcom, sqlc);
                cmd.Parameters.AddWithValue("@Schedule", Schedule.Text.Trim());
                cmd.Parameters.AddWithValue("@Fuel_Usage", Fuel.Text.Trim());
                cmd.Parameters.AddWithValue("@Incidents", Incident.Text.Trim());
                cmd.Parameters.AddWithValue("@Distance", KM.Text.Trim());

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                sqlc.Close();
                MessageBox.Show("Data saved .");
            }

             
                
            
        }
    }
}
