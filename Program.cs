using System;

namespace CGSummer2018_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their name:
            Console.Write("I'm hello world. What is your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine(string.Format("Hello {0}!", userName));
            Console.Read();
        }
    }
}
