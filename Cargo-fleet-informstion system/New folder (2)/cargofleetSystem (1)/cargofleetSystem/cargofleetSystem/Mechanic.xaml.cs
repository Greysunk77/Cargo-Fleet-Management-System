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
    /// Interaction logic for Mechanic.xaml
    /// </summary>
    public partial class Mechanic : Window
    {
        public Mechanic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Succesfully Logged out");
            Login popup = new Login();
            popup.Show();
            this.Close();
            
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
            if (full_service.IsChecked is false || Truck_Inspection.IsChecked is false)
            {
                if (full_service.IsChecked is true)
                {
                    using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
                    {
                        //sqlc.Open();
                        //string inn = "INSERT INTO [dbo].[Service] VALUES(@Type_of_Service,@name,@MechanicID)";
                        //SqlCommand cmd = new SqlCommand(inn, sqlc);
                        //cmd.Parameters.AddWithValue("@Type_of_Service", full_service);
                        //cmd.Parameters.AddWithValue("@Type_of_Service", Truck_Inspection);
                        //cmd.Parameters.AddWithValue("@name", MName.Text.Trim());
                        //cmd.Parameters.AddWithValue("@MechanicID",MechanicID.Text.Trim() );
                        //cmd.CommandType = CommandType.Text;
                        //cmd.ExecuteNonQuery();
                        //sqlc.Close();
                        MessageBox.Show("Service Updated.");


                    }
                }
                if (Truck_Inspection.IsChecked is true)
                {
                    using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
                    {
                        //sqlc.Open();
                        //string inn = "INSERT INTO [dbo].[Service] VALUES(@Type_of_Service)";
                        //SqlCommand cmd = new SqlCommand(inn, sqlc);
                        //cmd.Parameters.AddWithValue("@Type_of_Service", Truck_Inspection);

                        //cmd.CommandType = CommandType.Text;
                        //cmd.ExecuteNonQuery();
                        //sqlc.Close();
                        MessageBox.Show("Service Updated.");


                    }
                }
            }
            else
            {
                MessageBox.Show("Fields Can't Be Empty.", "Error Encountered.");
            }

            
        }
    }
}
