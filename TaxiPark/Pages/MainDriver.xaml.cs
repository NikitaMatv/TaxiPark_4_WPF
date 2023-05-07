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
    /// Логика взаимодействия для MainDriver.xaml
    /// </summary>
    public partial class MainDriver : Page
    {
        public MainDriver()
        {
            InitializeComponent();
           

             LvAccept.ItemsSource = App.DB.Order.Where(x => x.TaxistId == null && x.IsAccept == 1).ToList();
        }

        private void AcceptBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvAccept.SelectedItem as Order;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете закакз");
                return;
            }
            selectedclient.IsAccept = 2;
            selectedclient.TaxistId = App.LoggedEmployee.Id;
            App.DB.SaveChanges();
            NavigationService.Navigate(new OrderDriverPages());
        }
        private void Profil_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfelClient(App.LoggedEmployee));
        }

       
    }
}
