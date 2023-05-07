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
    /// Логика взаимодействия для MainClient.xaml
    /// </summary>
    public partial class MainClient : Page
    {
        public MainClient()
        {
            InitializeComponent();
            LvOrders.ItemsSource = App.DB.Order.Where(x => x.ClientId == App.LoggedEmployee.Id).Where(x => x.IsAccept != 3).ToList();
            if (LvOrders.Items.Count > 0)
            {
                ZakazBt.Visibility = Visibility.Collapsed;
                ZakaDellzBt.Visibility = Visibility.Visible;
            }
        }

        private void ZakazBt_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new OrderTaxiPages(new Order()));
        }

        private void ProfilBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfelClient(App.LoggedEmployee));
        }

        private void ZakaDellzBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvOrders.SelectedItem as Order;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете заказ");
                return;
            }
           
                selectedclient.IsAccept = 3;


            App.DB.SaveChanges();
            NavigationService.Navigate(new MainClient());
        }
    }
}
