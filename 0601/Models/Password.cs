using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace _0601.Models
{
    public class Password
    {
        public static string SHA512(string originText)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(originText);
                SHA512 sha512 = new SHA512CryptoServiceProvider();
                byte[] result = sha512.ComputeHash(data);

                return Convert.ToBase64String(result);
            }
            catch
            {
                return "ErrorPassword";
            }
        }
    }
}