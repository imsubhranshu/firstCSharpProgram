using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
            Console.WriteLine("Taking Input");
            string data = Console.ReadLine();
            Console.Write("The value entered is:\n" + data);
        }
    }
}
