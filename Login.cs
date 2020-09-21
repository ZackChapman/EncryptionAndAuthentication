using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;


namespace EncryptionAndAuthentication
{
    class Login
    {
        public void CheckUserPass()
        {
            Console.WriteLine("Enter your User Name to login: ");
            string userAuth = Console.ReadLine();

            Console.WriteLine("Enter Password to be login: ");
            string passAuth = Console.ReadLine();
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(passAuth));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            passAuth = hash.ToString();


            if (CreateAccount.uNamePW.ContainsKey(userAuth) && CreateAccount.uNamePW.ContainsValue(passAuth))
            {

                Console.WriteLine("Successful Login");
                Console.WriteLine("Press Enter to Return to Main Menu");
            }
            else
            {
                Console.WriteLine("Not Authorized you User Name or Password is incorrect");
                Console.WriteLine("Press Enter to Return to Main Menu");
            }
            
            Console.ReadLine();
        }
    }
}
