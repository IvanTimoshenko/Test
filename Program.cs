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
            string mes = messages.FirstMessage();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mes);
            Console.ReadKey();
        }
    }
}
