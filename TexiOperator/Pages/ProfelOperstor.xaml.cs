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
    /// Логика взаимодействия для ProfelOperstor.xaml
    /// </summary>
    public partial class ProfelOperstor : Page
    {
        Emplooy contextemploy;
        public ProfelOperstor(Emplooy emplooy)
        {
            InitializeComponent();
            contextemploy = emplooy;
            DataContext = contextemploy;
         
          
        }



        private void MainClientBt_Click(object sender, RoutedEventArgs e)

        {     
                NavigationService.Navigate(new MainOperatorPages());
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedEmployee = null;
            NavigationService.Navigate(new AutorPages());
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditOperatorProfilPages(App.LoggedEmployee));
        }

      
    }
}
