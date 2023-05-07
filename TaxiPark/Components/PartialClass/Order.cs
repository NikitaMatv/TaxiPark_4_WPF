using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaxiPark.Components
{
    public partial class Order
    {
        public Visibility VisibilityBt
        {
            get
            {
                if (IsAccept != 3)
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Hidden;
                }
            }
        }
    }
}
