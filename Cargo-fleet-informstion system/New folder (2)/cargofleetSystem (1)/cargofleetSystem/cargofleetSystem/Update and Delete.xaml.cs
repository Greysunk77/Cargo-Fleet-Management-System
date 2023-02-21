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
    /// Interaction logic for Update_and_Delete.xaml
    /// </summary>
    public partial class Update_and_Delete : Window
    {
        SqlCommand cmd;
        SqlDataReader reader;
        public Update_and_Delete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UpdateD_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            try
            {
                string Query = "Update Drivertbl Set Name='" +UDName.Text + "', Surname='" + UDSurname.Text + "'";

                connection.Open();

                cmd = new SqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information is succesfully Update", "Updated");


                connection.Close();
            }
            catch(Exception ex)
            {

            }
        }

        private void DeleteD_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            string Query = "delete from Drivertbl where Name='" + UDName.Text+ "', Surname='" + UDSurname.Text + "'";

            try
            {

                connection.Open();
                cmd = new SqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is being Deleted", "Succesfully Deleted");
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Something is Wrong");
            }
        }

        private void DeleteM_Copy_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            string Query = "delete from Mechanic where Name='" + UDName1.Text + "', Surname='" + UDSurname1.Text + "'";

            try
            {

                connection.Open();
                cmd = new SqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is being Deleted", "Succesfully Deleted");
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Something is Wrong");
            }
        }

        private void UpdateM_Copy_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            try
            {
                string Query = "Update Mechanic Set Name='" + UDName1.Text + "', Surname='" + UDSurname1.Text + "'";

                connection.Open();

                cmd = new SqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information is succesfully Update", "Updated");


                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void office_Click(object sender, RoutedEventArgs e)
        {
            Officemanager officemanager = new Officemanager();
            officemanager.Show();
            this.Close();
        }
    }
}
