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
    /// Логика взаимодействия для MainAdminPages.xaml
    /// </summary>
    public partial class MainAdminPages : Page
    {
        public MainAdminPages()
        {
            InitializeComponent();
            LvAccept.ItemsSource = App.DB.OrderForDriver.Where(x => x.Status == null).ToList();
          
   
           
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedEmployee = null;
            NavigationService.Navigate(new AutorPages());
        }

        private void ListEmlooyBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminListPages());
        }

        private void LvAccept_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void AcceptBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvAccept.SelectedItem as OrderForDriver;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете закакз");
                return;
            }
            selectedclient.Status = 1;
            int id = (int)selectedclient.IdEmpooy;

            if (selectedclient != null)
            {
                var selctempl = App.DB.Emplooy.FirstOrDefault(x => x.Id == id)  as Emplooy;

                selctempl.RoleId = 2;
            }
            App.DB.SaveChanges();
            NavigationService.Navigate(new MainAdminPages());
        }

        private void DellBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvAccept.SelectedItem as OrderForDriver;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете закакз");
                return;
            }
            selectedclient.Status = 3;         
            App.DB.SaveChanges();
            NavigationService.Navigate(new MainAdminPages());
        }
    }
}
