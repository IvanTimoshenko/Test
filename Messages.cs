using System;
namespace GitProject
{
    public class Messages
    {
        public string FirstMessage(){
            Console.WriteLine("put your message here:");
            return Console.ReadLine();
        }
    }
}