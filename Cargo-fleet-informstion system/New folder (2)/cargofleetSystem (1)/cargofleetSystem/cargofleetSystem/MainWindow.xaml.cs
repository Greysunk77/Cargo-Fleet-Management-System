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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cargofleetSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {  
            this.Hide();
            Update_and_Delete popup = new Update_and_Delete();
            popup.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Hide();
            Mechanic popup = new Mechanic();
            popup.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            this.Hide();
            Driver popup = new Driver();
            popup.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            this.Hide();
            Servicemanager popup = new Servicemanager();
            popup.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Timesheetmanager popup = new Timesheetmanager();
            popup.Show();
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            this.Hide();
            TripUsagemanager popup = new TripUsagemanager();
            popup.Show();
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void office_Click(object sender, RoutedEventArgs e)
        {
            Officemanager officemanager = new Officemanager();
            officemanager.Show();
            this.Close();
        }
    }
}
