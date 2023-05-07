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
using TaxiClientWpf.Components;

namespace TaxiClientWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainClientPages.xaml
    /// </summary>
    public partial class MainClientPages : Page
    {
        public MainClientPages()
        {
            InitializeComponent();
            LvAccept.ItemsSource = App.DB.Order.Where(x => x.ClientId == App.LoggedEmployee.Id && x.IsAccept > 0 && x.IsAccept !=3).ToList();
        }





        private void ProfilBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfilClietnPages(App.LoggedEmployee));
        }

        private void BtAccept_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var selectedclient = (sender as TextBlock).DataContext as Order;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете закакз");
                return;
            }
            selectedclient.IsAccept = 1;
            App.DB.SaveChanges();
            NavigationService.Navigate(new MainClientPages());
        }

        private void BtCansel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var selectedclient = (sender as TextBlock).DataContext as Order;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете закакз");
                return;
            }
            selectedclient.IsAccept = 3;
            App.DB.SaveChanges();
            NavigationService.Navigate(new MainClientPages());
        }
    }
}
