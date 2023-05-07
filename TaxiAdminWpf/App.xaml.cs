using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TaxiAdminWpf.Components;

namespace TaxiAdminWpf
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TaxiDBEntities DB = new TaxiDBEntities();
        public static Emplooy LoggedEmployee;
        public static bool IsAutorizate = false;
    }
}
