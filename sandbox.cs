using System;

namespace my_sandbox
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("What is your name?");

                string userName = Console.ReadLine();

                Console.WriteLine("Hello " + userName + ", nice to meet you.")

                Console.ReadKey();
            }
    }
}
