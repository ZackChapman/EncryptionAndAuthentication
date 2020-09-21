using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace EncryptionAndAuthentication
{
    class Menu
    {
     bool quit = false;
     public void Run()  
        {
            do
            {
                Console.Clear();
                //DispayMainMenu();
                quit = UserInput();
            }
            while (!quit);
        }

        //  Main menu options
        void DispayMainMenu()
        {
            Console.WriteLine(" _______________________________________________\n" +
                              "| Password Encryption and Authentication System|\n" +
                              "|                                              |\n" +
                              "| Please select an option:                     |\n" +
                              "|                                              |\n" +
                              "| 1.) Create an account                        |\n" +
                              "| 2.) Login to your account                    |\n" +
                              "| 3.) Exit                                     |\n" +
                              "|______________________________________________|");
        }
        // Handles main navigation from the user
        bool UserInput()
        {
            bool quit = false;
            bool isValid = false;

            //Main menu options;
            do
            {
                try
                {
                    Console.Clear();
                    DispayMainMenu();
                    Console.Write("Please select an option: ");

                    int selection = int.Parse(Console.ReadLine());

                    Console.Clear();

                        isValid = true;

                        switch (selection)
                        {
                            case 1:
                                CreateAccount.GetNameAndPass();
                                break;

                            case 2:
                                Login authPass = new Login();
                                authPass.CheckUserPass();
                                break;

                            case 3:
                                Console.WriteLine("Exit");
                                quit = true;
                                break;

                            default:
                                isValid = false;
                                Console.WriteLine("Invalid selection please choose [1] , [2] , or [3]");
                                Console.WriteLine("Press Enter to Return to Main Menu");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                }
                catch (FormatException)
                {
                    isValid = false;
                }
            }
            while (!quit && !isValid);

            return quit;
        }
    }
}
