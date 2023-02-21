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
    /// Interaction logic for Timesheetmanager.xaml
    /// </summary>
    public partial class Timesheetmanager : Window
    {
        public Timesheetmanager()
        {
            InitializeComponent();
        }

        


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow popup = new MainWindow();
            popup.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.Setting))
            {
                sqlc.Open();
                string inn = "INSERT INTO [dbo].[TimeSheetManagerCentre] VALUES(@Hours_Worked_M,@Hours_worked_D,@DriverID,@MechanicID)";
                SqlCommand cmd = new SqlCommand(inn, sqlc);
                cmd.Parameters.AddWithValue("@Hours_Worked_M", txtHours.Text.Trim() );
                cmd.Parameters.AddWithValue("@Hours_worked_D", txtDriverHours.Text.Trim());
                cmd.Parameters.AddWithValue("@DriverID", txtDriverID.Text.Trim());
                cmd.Parameters.AddWithValue("@MechanicID", txtMecID.Text.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                sqlc.Close();
                MessageBox.Show("Data Uploaded.");

                int di = Convert.ToInt32(txtDriverID.Text);
                //Listview.View = di;
            }
        }
        private void txtMecID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMecID_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
