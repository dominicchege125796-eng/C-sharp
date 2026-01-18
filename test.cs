using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            int health = 10;
            int gold = 0;
            Console.WriteLine("Hello adventurer  and welcome to my game");
            while ( play == true)
            {
                Console.WriteLine("Do your wish to start the game (yes ,no )");
                Console.WriteLine("Quit the game (quit)");
                Console.WriteLine("View Game status (stats)");
                string choice = Convert.ToString(Console.ReadLine());
                if (choice == "yes")
                {
                    Console.WriteLine("Hello adventurer welcome to Our game");
                    Console.WriteLine("Please enter your name ");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Thats nice " + name + " you have earned 10 gold coins");
                    gold += 10;
                    
                }
                else if (choice == "no")
                {
                    Console.WriteLine("Yhank you, see you soon");
                }
                else if (choice == "stats")
                {
                    Console.WriteLine("your gold balance = " + gold);
                    Console.WriteLine("your gold health status = " + health);
                }

                else if (choice == "quit")
                {
                    play = false;
                    Console.WriteLine("Thaks for your participation ,  but your adventure has come to an end");
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
           
        }
    }
}
