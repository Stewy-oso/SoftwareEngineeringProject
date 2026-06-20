using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoey
{
    internal class validator
    {
        public static int IsValidEmail(string email)
        {
            const int Valid = 0;
            const int Empty = 1;
            const int InvalidLen = 2;
            const int InvalidDomain = 3;
            const int NoAtSign = 4;

            string[] allowedDomains =
                {
                    "@gmail.com",
                    "@outlook.com",
                    "@yahoo.com",
                    "@ittralee.ie",
                    "@mymtu.ie",
                    "@mtu.ie",
                };

            foreach (string domain in allowedDomains)
            {
                if (email.ToLower().EndsWith(domain))
                {
                    return Valid;
                }
                else return InvalidDomain;
            }
           

            if(string.IsNullOrWhiteSpace(email))
            {
                return Empty;
            }

            if(email.Length > 50)
            {
                return InvalidLen;
            }

            if (!email.Contains("@"))
            {
                return NoAtSign;
            }
            else return Valid;
            
        }

        public static int IsValidPassword(string password)
        {
            const int Valid = 0;
            const int Empty = 1;
            const int NoLower = 2;
            const int NoUpper = 3;
            const int noDigit = 4;
            const int NoSpecial = 5;
            const int InvalidLen = 6;

            if (password.Length < 8) return InvalidLen;
            if (!password.Any(char.IsUpper)) return NoUpper;
            if (!password.Any(char.IsLower)) return NoLower;
            if (!password.Any(char.IsDigit)) return noDigit;
            if (!password.Any(char.IsPunctuation)) return NoSpecial;
            if (string.IsNullOrEmpty(password)) return Empty;

            return Valid;

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
