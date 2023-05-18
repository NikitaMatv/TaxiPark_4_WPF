using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaxiAdminWpf.Components
{
    public partial class Emplooy
    {
        public string CollorBan
        {
            get
            {
                if(IsBan == 1)
                {
                    return "Red";
                }
                else
                {
                    return "";
                }
            }
        }
        public Visibility VisabilityBanAccept
        {
            get
            {
                if(IsBan == 1)
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Hidden;
                }
            }
        }
        public Visibility VisabilityBanNo
        {
            get
            {
                if (IsBan == 1)
                {
                    return Visibility.Hidden;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }
    }
}
