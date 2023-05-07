using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
