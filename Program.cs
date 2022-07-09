using System;
namespace app
{
    class program
    {
        static void Main(string[] args)
        {
            // Declaring variables for age and name
            int age;
            string name;

            Console.WriteLine("Hello, World!");
            Console.WriteLine("What's your name ?");

            name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name + " My name is c#");
            Console.WriteLine("How old are you ?");

            age = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Wow, You are " + age + " Years old");

          

// ReadKey function makes app wait before it closes after its done running
            Console.ReadKey();
        }
    }

}

