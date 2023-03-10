using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace HERP.Origin.App.Helpers
{
    public class Commons
    {
        public static string ConnString { get; set; }
        public static string RegUserId { get; set; }
        public static string Version { get; set; }
        public static string Domain { get; set; }

        public static readonly NLog.Logger NLogger = NLog.LogManager.GetCurrentClassLogger();

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes 
            // and create a string. 
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
    }

    public static class CurrentUser
    {
        public static string UserId { get; set; }
        public static string Name { get; set; }
        public static int Levels { get; set; }
        public static DateTime LoginDt { get; set; }

        public static void SignIn(string userId, string name, int levels)
        {
            UserId = userId;
            Name = name;
            Levels = levels;
        }

        public static void SignOff()
        {
            UserId = string.Empty;
            Name = string.Empty;
            Levels = 0;
        }

    }
}
