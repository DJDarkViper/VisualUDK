using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace VisualUDK
{
    class Crypto
    {
        public static String getRandomHash()
        {
            Random random = new Random();
            return Crypto.getMD5(random.Next().ToString());
        }

        public static String getMD5(String input)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash( Encoding.UTF8.GetBytes(input) );
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                build.Append(data[i].ToString("x2"));

            return build.ToString();
        }
    }
}
