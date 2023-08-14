using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HeldOgLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Changes color.
                Console.ForegroundColor = ConsoleColor.Green;
                // ASCII art. Just for looks
                Console.WriteLine("  ____\r\n /\\' .\\    _____\r\n/: \\___\\  / .  /\\\r\n\\' / . / /____/..\\\r\n \\/___/  \\'  '\\  /\r\n          \\'__'\\/");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" _       ___   ______  ______   ___  \r\n| |     /   \\ |      ||      | /   \\ \r\n| |    |     ||      ||      ||     |\r\n| |___ |  O  ||_|  |_||_|  |_||  O  |\r\n|     ||     |  |  |    |  |  |     |\r\n|     ||     |  |  |    |  |  |     |\r\n|_____| \\___/   |__|    |__|   \\___/ \r\n------------------------------------------------------\r\n\r\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press 'ENTER' to roll weekly lotto numbers.");
                Console.ReadLine();

                // Random object to randomize a number.
                Random random = new Random();

                // Array to capture 8 values. 0-7
                int[] lottoNumbers = new int[8];

                // For loop that runs 8 times for the numbers to be randomized. While! While it checks for containing values.
                for (int i = 0; i < 8; i++)
                {
                    int tempLottoNumbers = random.Next(1, 37);

                    while (lottoNumbers.Contains(tempLottoNumbers))
                    {
                        tempLottoNumbers = random.Next(1, 37);
                    }

                    lottoNumbers[i] = tempLottoNumbers;
                }

                // Array sort to sort from low numbers to high numbers.
                Array.Sort(lottoNumbers);

                // For loop that runs 8 times, to print out every array no.
                for (int i = 0; i < 8; i++)
                {
                    Thread.Sleep(2000);
                    if (i == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(lottoNumbers[i] + " ");
                    }
                    else
                    {
                        Console.Write(lottoNumbers[i] + " ");
                    }
                }


                // Switch to go return with escape or every other button.
                switch (Console.ReadKey().Key)
                {
                    default:
                        return;
                }
            }
        }
    }
}
