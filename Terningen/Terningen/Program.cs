using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we change the foreground and background color.
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            //Generate a random object to generate something random
            Random random = new Random();
            // Integer to create a variable called dice.
            int dice;
            // While loop set to true, so it always will run. It's also so we can start the program over again.
            while (true)
            {
                // Clearing the console for a cleaner view
                Console.Clear();
                // Assigning a random.Next from the number 1-6 to the integer "dice".
                dice = random.Next(1, 7);
                // Setting cursor a little longer out in the console field. (just for looks)
                Console.SetCursorPosition(4,2);

                // If random number is == the random number chosen by the object, then execute a writeline.
                if (dice == 1)
                {
                    Console.WriteLine("Du slog en etter");
                }
                else if (dice == 2)
                {
                    Console.WriteLine("Du slog en to'er");
                }
                else if (dice == 3)
                {
                    Console.WriteLine("Du slog en tre'er");
                }
                else if (dice == 4)
                {
                    Console.WriteLine("Du slog en fire");
                }
                else if (dice == 5)
                {
                    Console.WriteLine("Du slog en fem'er");
                }
                else
                {
                    Console.WriteLine("Du slog en seks'er");
                }

                // Switch for closing and re-rolling.
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.Enter:
                        continue;
                }
            }
        }
    }
}
