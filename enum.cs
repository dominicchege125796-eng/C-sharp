using System;


namespace Enum
{
    internal class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
           Level tree = Level.High;
            switch (tree)
            {
                case Level.Low:
                    Console.WriteLine("low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }
           
        }
    }
}
