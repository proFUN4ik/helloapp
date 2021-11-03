using System;

namespace ConsoleApp1
{
    class Program
    {
        static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }

        static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetWhite();
            GreetWhite();
            GreetWhite();
        }
    }
}