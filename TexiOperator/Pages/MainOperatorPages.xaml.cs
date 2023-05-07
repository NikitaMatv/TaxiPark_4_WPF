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
using TexiOperator.Components;

namespace TexiOperator.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainOperatorPages.xaml
    /// </summary>
    public partial class MainOperatorPages : Page
    {
        public MainOperatorPages()
        {
            InitializeComponent();
            LvAccept.ItemsSource = App.DB.Order.Where(x => x.TaxistId == null).Where(x => x.IsAccept == null).ToList();
        }



        

        private void ProfilBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfelOperstor(App.LoggedEmployee));
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
            NavigationService.Navigate(new MainOperatorPages());
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
            NavigationService.Navigate(new MainOperatorPages());
        }
    }
}
