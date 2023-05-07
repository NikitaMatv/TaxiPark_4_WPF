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
using TaxiAdminWpf.Components;

namespace TaxiAdminWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для BanListPages.xaml
    /// </summary>
    public partial class BanListPages : Page
    {
        public BanListPages()
        {
            InitializeComponent();
            LvAccept.ItemsSource = App.DB.Emplooy.ToList();
        }

        private void ListEmlooyBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainAdminPages());
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedEmployee = null;
            NavigationService.Navigate(new AutorPages());
        }

        private void AcceptBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvAccept.SelectedItem as Emplooy;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете аккаунт");
                return;
            }
            if (selectedclient.RoleId == 4)
            {
                MessageBox.Show("Админа нельзя заблокировать");
                return;
            }
            else
            {
                if (selectedclient.IsBan == 1)
                {
                    MessageBox.Show("Пользователь уже заблакирован");
                    return;
                }
                selectedclient.IsBan = 1;
            }


            App.DB.SaveChanges();
            NavigationService.Navigate(new BanListPages());
        }

        private void DellBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedclient = LvAccept.SelectedItem as Emplooy;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете аккаунт");
                return;
            }
            if (selectedclient.RoleId == 4)
            {
                MessageBox.Show("Админа нельзя заблокировать");
                return;
            }
            else
            {
                if (selectedclient.IsBan == 0)
                {
                    MessageBox.Show("Пользователь не заблакирован");
                    return;
                }
                selectedclient.IsBan = 0;
            }


            App.DB.SaveChanges();
            NavigationService.Navigate(new BanListPages());
        }
        private void BtAccept_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var selectedclient = (sender as TextBlock).DataContext as Emplooy;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете аккаунт");
                return;
            }
            if (selectedclient.RoleId == 4)
            {
                MessageBox.Show("Админа нельзя заблокировать");
                return;
            }
            else
            {
                if (selectedclient.IsBan == 1)
                {
                    MessageBox.Show("Пользователь уже заблакирован");
                    return;
                }
                selectedclient.IsBan = 1;
            }


            App.DB.SaveChanges();
            NavigationService.Navigate(new BanListPages());
        }

        private void BtCansel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var selectedclient = (sender as TextBlock).DataContext as Emplooy;
            if (selectedclient == null)
            {
                MessageBox.Show("Выберете аккаунт");
                return;
            }
            if (selectedclient.RoleId == 4)
            {
                MessageBox.Show("Админа нельзя заблокировать");
                return;
            }
            else
            {
                if (selectedclient.IsBan == 0)
                {
                    MessageBox.Show("Пользователь не заблакирован");
                    return;
                }
                selectedclient.IsBan = 0;
            }


            App.DB.SaveChanges();
            NavigationService.Navigate(new BanListPages());
        }
    }
}
