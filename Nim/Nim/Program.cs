using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int totalMatches = 7;
                string visualizeMatches = " |";
                int randomMatches;

                int pcHand = 3;
                int userInput;

                Random random = new Random();

                Console.WriteLine("A game of matches! Are you ready? (Press any button to succeed.)");
                Console.ReadLine();

                for (int i = 0; i < 7; i++)
                {
                    Console.Clear();
                    for (int j = 0; j < totalMatches; j++)
                    {
                        Console.Write(visualizeMatches);

                    }
                    
                    Console.WriteLine("\r\nHow many would you like to pick?");

                    userInput = Convert.ToInt16(Console.ReadLine());

                    if (userInput <= 3 && userInput > 0)
                    {
                        totalMatches = totalMatches - userInput;
                        Console.WriteLine(visualizeMatches);
                    }
                    else
                    {
                        continue;
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Computers turn. Wait.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (totalMatches > 3)
                    {
                        else if (totalMatches == 2)
                        {
                            Console.WriteLine("The computer chose to pick: 1");
                            totalMatches--;
                        }
                        randomMatches = random.Next(1, 4);
                        Console.WriteLine("The computer chose to pick: " + totalMatches);
                    }


                }

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
