using System;
namespace app
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What's your name ?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);

            Console.ReadKey();
        }
    }

}

