using System;

namespace GitProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
            messages.FirstMessage();
            Console.ReadKey();
        }
    }
}
