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
    /// Логика взаимодействия для OrdersForDrivings.xaml
    /// </summary>
    public partial class OrdersForDrivings : Page
    {
       
        OrderForDriver contextemploy;
        public OrdersForDrivings(OrderForDriver order)
        {
            InitializeComponent();
            contextemploy = order;
            DataContext = contextemploy;
   
        }

        private void MainClientBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfelClient(App.LoggedEmployee));
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            var error = "";
            if(LoginTb.Text.Trim() == "")
            {
                error += "Заполните поле возраста \n";
            }
            if (PasswordTb.Text.Trim() == "")
            {
                error += "Заполните стаж \n";
            }
            if(error != "")
            {
                MessageBox.Show(error);
            }
            else
            {

                contextemploy.IdEmpooy = App.LoggedEmployee.Id;
                App.DB.OrderForDriver.Add(contextemploy);

                App.DB.SaveChanges();

                NavigationService.Navigate(new ProfelClient(App.LoggedEmployee));
            }
        }
    }
}
