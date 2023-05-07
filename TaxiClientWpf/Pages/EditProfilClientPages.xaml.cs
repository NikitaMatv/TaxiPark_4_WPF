using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для EditProfilClientPages.xaml
    /// </summary>
    public partial class EditProfilClientPages : Page
    {
        Emplooy contextEmplooy;
        public EditProfilClientPages(Emplooy emplooy)
        {
            InitializeComponent();
            contextEmplooy = emplooy;
            DataContext = contextEmplooy;
        }


        private void MainClientBt_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Text.Trim().Length > 0 && NameTb.Text.Trim().Length > 0 && SurNameTb.Text.Trim().Length > 0)
            {
                if (contextEmplooy.Id == 0)
                {
                    App.DB.Emplooy.Add(contextEmplooy);
                }
                App.DB.SaveChanges();
                App.LoggedEmployee = contextEmplooy;
                NavigationService.Navigate(new ProfilClietnPages(contextEmplooy));
            }
            else
            {
                MessageBox.Show("Заполните все поля верно");
            }

        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new ProfilClietnPages(App.LoggedEmployee));
        }
        private void NameTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Regex.IsMatch(e.Text, @"[А-я]") == false)
            {
                e.Handled = true;
            }
        }

        private void LoginTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Regex.IsMatch(e.Text, @"[A-z0-9]") == false)
            {
                e.Handled = true;
            }
        }

        private void PhoneTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Regex.IsMatch(e.Text, @"[0-9]") == false)
            {
                e.Handled = true;
            }
        }
    }
}
