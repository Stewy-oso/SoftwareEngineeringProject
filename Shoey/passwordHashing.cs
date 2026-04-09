using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Shoey
{
    internal class passwordHashing
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach(byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();

                /*
                 Title:  SHA256 Class
                 Author: Microsoft
                 Website: https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256
                 Second Website: https://learn.microsoft.com/en-us/dotnet/standard/security/cryptographic-services
                 Reasons: Code "inspiration", implementation explanation, justifying use.
                 */

                /* 
                 Title: C# | SHA256 Hashing
                 Author: GeeksforGeeks
                 Website: https://www.geeksforgeeks.org/sha256-hash-in-c-sharp/
                 Reasons: Simpler breakdown
                 */
            }
        }
    }
}
