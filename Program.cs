using System;

namespace GitProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            Console.WriteLine("Hi");
            Console.WriteLine(messages.FirstMessage());
        }
    }
}
