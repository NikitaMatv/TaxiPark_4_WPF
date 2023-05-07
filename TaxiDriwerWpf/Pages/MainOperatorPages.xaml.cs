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
using TaxiDriwerWpf.Components;

namespace TaxiDriwerWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainOperatorPages.xaml
    /// </summary>
    public partial class MainOperatorPages : Page
    {
        public MainOperatorPages()
        {
            InitializeComponent();
            LvOrders.ItemsSource = App.DB.Order.Where(x => x.TaxistId == App.LoggedEmployee.Id && x.IsAccept == 2).ToList();
        }

        private void ZakazBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvOrders.SelectedItem as Order;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете закакз");
                return;
            }
            selectedclient.IsAccept = 3;
            App.DB.SaveChanges();
            NavigationService.Navigate(new OrderDriwerPages());
        }
    }
}
