using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Controller();
        }

        #region Model
        #endregion

        #region View
        static void WritePasswordRules()
        {
            Console.Clear();
            Console.Write("You will now make a password. Your password need to have some rules to be perfect.\r\n\r\nRules for password to be: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STRONG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Password has to be inbetween 12-64 characters.\r\n- There has to be at least 1 upper and lower case character.\r\n- Password has to unclude numbers.\r\n- Include a special character.\r\n\r\nRules for password to be: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- If the password has 4 characters of the same in a row.\r\n- The password can't include number rows like: 1234 or 3456.\r\n\r\nRules for password to be: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("NOT VALID");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- If the rules above doesn't include your password is not valid.\r\n\r\nWrite your password:");
        }
        static void WritePasswordValid()
        {
            Console.Clear();
            Console.Write("Your password is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STRONG");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("We recommend you to use that password! Press 'ENTER' button to close.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        static void WritePasswordWeak()
        {
            Console.Clear();
            Console.Write("Your password is: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAK");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Try again in 3 seconds.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 2 seconds.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 1 seconds.");
            Thread.Sleep(1000);
            Program.WritePasswordRules();
        }
        static void WritePasswordNotValid()
        {
            Console.Clear();
            Console.Write("Your password is: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("NOT VALID");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Try again in 3 seconds.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 2 seconds.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 1 seconds.");
            Thread.Sleep(1000);
            Program.WritePasswordRules();
        }
        #endregion

        #region Controller
        static void Controller()
        {
            while (true)
            {
                Program.WritePasswordRules();

                string userInput = Console.ReadLine();
                int getLengthUserInput = userInput.Length;
                string specialCharacterList = @"!#$%&'()*+,-./:;<=>?@[\]^_`{|}~"; // 31 // 0-30 possible characters.
                bool userInputContainsSpecialCharacter = false;
                bool userInputConsecutive = false;

                /* For loop to check for special characters.
                Take the length of the special characters (31) and loop through the whole string
                until something is found in the userInput and make userInputContainsSpecialCharacter true. */
                /*for (int i = 0; i < specialCharacterList.Length; i++)
                {
                    char c = specialCharacterList[i];
                    if (userInput.Contains(c))
                    {
                        userInputContainsSpecialCharacter = true;
                    }
                }

                if (getLengthUserInput > 11 && getLengthUserInput < 65)
                {
                    if (userInput.Any(char.IsUpper) && userInput.Any(char.IsLower) && userInput.Any(char.IsDigit))
                    {
                        if (userInputContainsSpecialCharacter = true)
                        {

                        }
                    }
                    else
                    {
                        Program.WritePasswordNotValid();
                    }
                }
                else
                {
                     Program.WritePasswordNotValid();
                }*/
            }
        }
        #endregion
    }
}
