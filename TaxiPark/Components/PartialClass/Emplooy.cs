using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaxiPark.Components
{
    public partial class Emplooy
    {
        public Visibility VisibilityBt
        {
            get
            {
                if (IsBan != 1)
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }
        public Visibility VisibilityBt2
        {
            get
            {
                if (IsBan == 1)
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }
    }
}
