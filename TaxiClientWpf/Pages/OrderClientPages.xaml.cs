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
    /// Логика взаимодействия для OrderClientPages.xaml
    /// </summary>
    public partial class OrderClientPages : Page
    {
        Order contextorder;
        public OrderClientPages(Order order)
        {
            InitializeComponent();
            TypeCb.ItemsSource = App.DB.Type.ToList();
            TypePayCb.ItemsSource = App.DB.Payment.ToList();
            contextorder = order;
            DataContext = contextorder;
        }

        private void AutorBt_Click(object sender, RoutedEventArgs e)
        {
            if (AddresEndTb.Text.Trim().Length > 0 && AddresStartTb.Text.Trim().Length > 0 && TypeCb.SelectedItem != null)
            {

                if (TypeCb.SelectedIndex == 0)
                    contextorder.Price = 190;
                if (TypeCb.SelectedIndex == 1)
                    contextorder.Price = 210;
                if (TypeCb.SelectedIndex == 2)
                    contextorder.Price = 750;
                contextorder.ClientId = App.LoggedEmployee.Id;
                if (TypePayCb.SelectedIndex == 0)
                {
                    if (App.LoggedEmployee.Card == null)
                    {
                        MessageBox.Show("У вас не привязанна карта выберете другой способ оплаты");
                        return;
                    }
                }
                if (contextorder.Id == 0)
                {
                    App.DB.Order.Add(contextorder);
                }
                App.DB.SaveChanges();
                NavigationService.Navigate(new MainClientPages());
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void RegBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainClientPages());
        }

        private void AddresStartTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (AddresEndTb.Text.Trim().Length > 0 && AddresStartTb.Text.Trim().Length > 0)
            {
                if (TypeCb.SelectedIndex == 0)
                    Price.Text = "190";
                if (TypeCb.SelectedIndex == 1)
                    Price.Text = "210";
                if (TypeCb.SelectedIndex == 2)
                    Price.Text = "750";
            }
        }

        private void TypeCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AddresEndTb.Text.Trim().Length > 0 && AddresStartTb.Text.Trim().Length > 0)
            {
                if (TypeCb.SelectedIndex == 0)
                    Price.Text = "190";
                if (TypeCb.SelectedIndex == 1)
                    Price.Text = "210";
                if (TypeCb.SelectedIndex == 2)
                    Price.Text = "750";
            }
        }

        private void TypePayCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
