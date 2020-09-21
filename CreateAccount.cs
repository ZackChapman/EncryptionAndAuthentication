using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace EncryptionAndAuthentication
{
    static class CreateAccount
    {
        public static SortedList<string, string> uNamePW = new SortedList<string, string>();

        public static void GetNameAndPass()
        {
            //Collect User Name
            Console.WriteLine("Type in a User Name");
            string userName = Console.ReadLine();
            Console.Clear();

            //Collect and encrypt Password
            Console.WriteLine("Type in a Password");
            string password = Console.ReadLine();
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(password));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            password = hash.ToString();
            //Console.WriteLine(password);
            Console.Clear();

            uNamePW.Add(userName, password);
            //foreach (KeyValuePair<string, string> element in uNamePW)
            //{
            //    Console.WriteLine("this is my " + element);
            //}      
            Console.WriteLine("Press enter to return to main menu.");
            Console.Read();

        }
    }
}
