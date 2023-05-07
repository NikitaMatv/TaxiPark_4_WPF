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
using TexiOperator.Pages;
namespace TexiOperator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new AutorPages());
        }

        private void BtExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtMin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtSinout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (App.LoggedEmployee != null)
            {
                App.LoggedEmployee = null;
                MainFrame.NavigationService.Navigate(new AutorPages());
            }
            else
            {
                MessageBox.Show("Нужно войти в аккаунт");
            }
        }

        private void BtSender_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MainFrame.NavigationService.Navigate(new AutorPages());
        }

        private void BtOrder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (App.LoggedEmployee != null)
            {
               
                MainFrame.NavigationService.Navigate(new MainOperatorPages());
            }
            else
            {
                MessageBox.Show("Нужно войти в аккаунт");
            }
         
        }

        private void Polygon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
          
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (App.LoggedEmployee != null)
            {
                MainFrame.NavigationService.Navigate(new ProfelOperstor(App.LoggedEmployee));
            }
            else
            {
                MessageBox.Show("Нужно войти в аккаунт");
            }
           
        }

        private void BtInform_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new InformPages());
        }

       
    }
}
