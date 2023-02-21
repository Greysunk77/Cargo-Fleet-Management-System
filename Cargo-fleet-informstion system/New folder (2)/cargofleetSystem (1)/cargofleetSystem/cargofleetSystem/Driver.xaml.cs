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
using System.Configuration;

namespace cargofleetSystem
{
    /// <summary>
    /// Interaction logic for Driver.xaml
    /// </summary>
    public partial class Driver : Window
    {
        public Driver()
        {
            InitializeComponent();
            binddategrid();
        }

        private void binddategrid()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            //connection.ConnectionString = ConfigurationManager.ConnectionStrings["cargo"].ConnectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT*FROM [AssignmentTABLE]";
            cmd.Connection = connection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable("AssignmentTABLE");
            sqlDataAdapter.Fill(data);
            DriverView.ItemsSource = data.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login popup = new Login();
            popup.Show();
            this.Hide();
            MessageBox.Show("Successfully Logged out");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void view_Click(object sender, RoutedEventArgs e)
        {
            //view.DataSource = GetData();

        }
    }
}
