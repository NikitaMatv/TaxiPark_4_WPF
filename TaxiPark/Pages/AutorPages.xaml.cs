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
    /// Логика взаимодействия для AutorPages.xaml
    /// </summary>
    public partial class AutorPages : Page
    {
        public AutorPages()
        {
            InitializeComponent();
        }

        private void AutorBt_Click(object sender, RoutedEventArgs e)
        {
            var employee = App.DB.Emplooy.FirstOrDefault(emp => emp.Login == LoginTb.Text);
            if (employee == null)
            {
                MessageBox.Show("Логин неверный");
                return;
            }
            if (employee.Password != PasswordTb.Password)
            {
                MessageBox.Show("Пароль неверный");
                return;
            }
            if(employee.IsBan == 1)
            {
                MessageBox.Show("Пользователь  заблокирован");
                return;
            }
            App.LoggedEmployee = employee;
            
            if(employee.RoleId == 1)
            {
                NavigationService.Navigate(new MainClient());
            }
            if (employee.RoleId == 2)
            {
                if (App.DB.Order.FirstOrDefault(x => x.TaxistId == App.LoggedEmployee.Id && x.IsAccept == 2) != null)
                {
                    NavigationService.Navigate(new OrderDriverPages());
                }
                else
                {
                    NavigationService.Navigate(new MainDriver());
                }
            
            }
            if (employee.RoleId == 3)
            {
                NavigationService.Navigate(new MainOperatorPages());
            }
            if (employee.RoleId == 4)
            {
                NavigationService.Navigate(new MainAdminPages());
            }
        }

        private void RegBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPages(new Emplooy()));
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InformationPages());
        }
    }
}
