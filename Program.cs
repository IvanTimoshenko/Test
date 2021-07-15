using System;

namespace GitProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            Console.WriteLine("Hello there");
            Console.WriteLine(messages.FirstMessage());
            Console.WriteLine("Greetings complete");
            Console.ReadKey();
        }
    }
}
