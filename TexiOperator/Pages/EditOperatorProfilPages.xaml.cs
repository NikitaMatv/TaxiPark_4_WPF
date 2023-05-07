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
using TexiOperator.Components;

namespace TexiOperator.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditOperatorProfilPages.xaml
    /// </summary>
    public partial class EditOperatorProfilPages : Page
    {
        Emplooy contextemploy;
        public EditOperatorProfilPages(Emplooy emplooy)
        {
            InitializeComponent();
            contextemploy = emplooy;
            DataContext = contextemploy;
        }


        private void MainClientBt_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Text.Trim().Length > 0 && NameTb.Text.Trim().Length > 0 &&  SurNameTb.Text.Trim().Length > 0)
            {
                if (contextemploy.Id == 0)
                {
                    App.DB.Emplooy.Add(contextemploy);
                }
                App.DB.SaveChanges();
                App.LoggedEmployee = contextemploy;
                NavigationService.Navigate(new ProfelOperstor(contextemploy));
            }
            else
            {
                MessageBox.Show("Заполните все поля верно");
            }

        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new ProfelOperstor(App.LoggedEmployee));
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
