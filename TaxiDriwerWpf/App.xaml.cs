using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TaxiDriwerWpf.Components;

namespace TaxiDriwerWpf
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TaxiDBEntities1 DB = new TaxiDBEntities1();
        public static Emplooy LoggedEmployee;
        public static bool IsAutorizate = false;
    }
}
