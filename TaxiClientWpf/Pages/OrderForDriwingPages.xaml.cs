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
    /// Логика взаимодействия для OrderForDriwingPages.xaml
    /// </summary>
    public partial class OrderForDriwingPages : Page
    {
        OrderForDriver contextemploy;
        public OrderForDriwingPages(OrderForDriver order)
        {
            InitializeComponent();
            contextemploy = order;
            DataContext = contextemploy;

        }

        private void MainClientBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainClientPages());
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            var error = "";
            if (LoginTb.Text.Trim() == "")
            {
                error += "Заполните поле возраста \n";
            }
            else
            {
                if (int.Parse(LoginTb.Text) - int.Parse(PasswordTb.Text) < 18)
                {
                    error += "Некоректный возраст или стаж вождения \n";
                }
                else
                {
                    if (int.Parse(LoginTb.Text) < 18)
                    {
                        error += "Некоректный возраст \n";
                    }
                }
            }
            
            if (PasswordTb.Text.Trim() == "")
            {
                error += "Заполните стаж \n";
            }
            else
            {
                if (int.Parse(PasswordTb.Text) <3)
                {
                    error += "Cтаж меньше 3 лет\n";
                }
            }
           
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }
            else
            {

                contextemploy.IdEmpooy = App.LoggedEmployee.Id;
                App.DB.OrderForDriver.Add(contextemploy);

                App.DB.SaveChanges();

                NavigationService.Navigate(new MainClientPages());
            }
        }
    }
}
