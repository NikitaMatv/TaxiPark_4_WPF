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
    /// Логика взаимодействия для ProfilPages.xaml
    /// </summary>
    public partial class ProfilPages : Page
    {
        Emplooy contextemplooy;
        public ProfilPages(Emplooy emplooy)
        {
            InitializeComponent();
            contextemplooy = emplooy;
            DataContext = contextemplooy;


        }



        private void MainClientBt_Click(object sender, RoutedEventArgs e)

        {
            NavigationService.Navigate(new MainAdminPages());
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedEmployee = null;
            NavigationService.Navigate(new AutorPages());
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditProfelPages(App.LoggedEmployee));
        }

    }
}
