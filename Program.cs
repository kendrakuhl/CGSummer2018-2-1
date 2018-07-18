using System;

namespace CGSummer2018_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their name:
            Console.Write("I'm hello world. What is your name? ");
            // Get the username from the console and put it into a variable named userName
            var userName = Console.ReadLine();
            // Write Hello userName to the console. String.Format is a nice way to concatenate strings 
            // without having a bunch of + signs everywhere
            Console.WriteLine(string.Format("Hello {0}!", userName));
            Console.Read();
        }
    }
}
