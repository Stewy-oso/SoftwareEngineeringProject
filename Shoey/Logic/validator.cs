using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoey
{
    internal class validator
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static int IsValidPhone(string phone)
        {
            const int Valid = 0;
            const int Empty = 1;
            const int InvalidLen = 2;
            const int InvalidChars = 3;

          
            if (string.IsNullOrEmpty(phone))
            {
                return Empty;
            }

            if (phone.StartsWith("+"))
            {
                if( phone.Length != 13)
                {
                    return InvalidLen;
                }
                if(!phone.Substring(1).All(char.IsDigit))
                {
                    return InvalidChars;
                }
            }

            else
            {
                if(phone.Length != 10)
                {
                    return InvalidLen;
                }
                if(!phone.All(char.IsDigit))
                {
                    return InvalidChars;
                }
            }

            return Valid;
        }

        // Maybe I should keep the const ints public or outside the functions so I can use them in all instances
        public static int IsValidName(string name)
        {
            const int Valid = 0;
            const int Empty = 1;
            const int InvalidLen = 2;
            const int InvalidChars = 3;

            if(string.IsNullOrEmpty(name))
            {
                return Empty;
            }
            if(name.Length > 35)
            {
                return InvalidLen;
            }
            if(!name.All(char.IsLetter))
            {
                return InvalidChars;
            }
            
            return Valid;
        }


    
    }
}
