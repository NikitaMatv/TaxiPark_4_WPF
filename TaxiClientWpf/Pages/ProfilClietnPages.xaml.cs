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
    /// Логика взаимодействия для ProfilClietnPages.xaml
    /// </summary>
    public partial class ProfilClietnPages : Page
    {
        Emplooy contextEmplooy;
        public ProfilClietnPages(Emplooy emplooy)
        {
            InitializeComponent();
            contextEmplooy = emplooy;
            DataContext = contextEmplooy;


        }



        private void MainClientBt_Click(object sender, RoutedEventArgs e)

        {
            NavigationService.Navigate(new MainClientPages());
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedEmployee = null;
            NavigationService.Navigate(new AutorPages());
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditProfilClientPages(App.LoggedEmployee));
        }
    }
}
