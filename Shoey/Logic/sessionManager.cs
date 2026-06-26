using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoey.Logic
{
    public class sessionManager
    {
        public static int CustomerID { get; set; }

        public static bool IsLoggedIn()
        {
            if (CustomerID > 0)
                return true;
            else
                return false;
        }

        public static void LogOut()
        {
            CustomerID = 0;
        }
    }

}
