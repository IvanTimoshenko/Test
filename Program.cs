﻿using System;

namespace GitProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            int a = 0;
            messages.FirstMessage();
            Console.WriteLine("Greetings complete");
            Console.ReadKey();
        }
    }
}
