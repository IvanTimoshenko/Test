using System;

namespace GitProject
{
    class Program
    {
        Messages messages = new Messages();
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            Console.WriteLine(Messages.FirstMessage());
        }
    }
}
