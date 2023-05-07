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
using TaxiPark.Components;
namespace TaxiPark.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfelClient.xaml
    /// </summary>
    public partial class ProfelClient : Page
    {
        Emplooy contextemploy;
        public ProfelClient(Emplooy emplooy)
        {
            InitializeComponent();
            contextemploy = emplooy;
            DataContext = contextemploy;
            if(App.LoggedEmployee.RoleId == 3)
            {
                PhoneTb.Visibility = Visibility.Collapsed;
                CartTb.Visibility = Visibility.Collapsed;
                Phone.Visibility = Visibility.Collapsed;
                Card.Visibility = Visibility.Collapsed;
                OrderDriverBt.Visibility = Visibility.Collapsed;
            }
            if (App.LoggedEmployee.RoleId == 2)
            {
                PhoneTb.Visibility = Visibility.Collapsed;
                CartTb.Visibility = Visibility.Collapsed;
                Phone.Visibility = Visibility.Collapsed;
                Card.Visibility = Visibility.Collapsed;
                OrderDriverBt.Visibility = Visibility.Hidden;
                EditBt.Visibility = Visibility.Hidden;
            }
        }

     

        private void MainClientBt_Click(object sender, RoutedEventArgs e)

        {
            if(App.LoggedEmployee.RoleId == 1)
            NavigationService.Navigate(new MainClient());
            if (App.LoggedEmployee.RoleId == 2)
                NavigationService.Navigate(new MainDriver());
            if (App.LoggedEmployee.RoleId == 3)
                NavigationService.Navigate(new MainOperatorPages());
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedEmployee = null;
            NavigationService.Navigate(new AutorPages());
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditClientProfilPages(App.LoggedEmployee));
        }

        private void OrderDriverBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersForDrivings(new OrderForDriver()));
        }
    }
}
