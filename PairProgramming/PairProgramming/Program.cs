using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Please enter a students name\n");
                string userInput = Console.ReadLine();

                names.Add(userInput);

                Console.WriteLine("Would you like to add another name?");
                ConsoleKey userContinue = Console.ReadKey(true).Key;

                switch (userContinue)
                {
                    case ConsoleKey.Y:
                        break;
                    case ConsoleKey.N:
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Input not recognized");
                        break;
                }
            }


            //Display list of names in groups of 2, if there is an odd number of students then have 1 group of three
            //for (int i = 0; i < names.Count; i+=2)
            //{

            //}




            //if (names.Count > 2)
            //{
            //    Console.WriteLine($"Pair: {names}, {names[i + 1]}");
            //}
            //else if (names.Count <= 2)
            //{

            //}
            for (int i = 0; i < names.Count; i += 2)
            {

                Console.WriteLine($"Pair: {names[i]}, {names[i + 1]}");
                int count = names.Count - 2;
                if (count % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Pair: {names[i]}, {names[i + 1]}, {names[i + 2]}");
                }

            }




        }
    }
}
