using System;
//using FrameworkLibrary; // Class Library using .NET Framework Library
//using CoreLibrary; // Class Library using .NET Core Library
using StandardLibrary; // Class Library using .NET Standard Library

// Ideally, use the .NET Standard library type so that your code can work across any platform
// .NET Standard Class Libraries will work with .NET Core and .NET Framework


namespace ConsoleUI
{
    class Program
    {
        // Made a reference to the .NET Framework library in the .NET Core application
        // (right clicking on dependancies and adding FrameworkLibrary Class Library
        static void Main(string[] args)
        {
            // 2 Ways to instantiate classes
            Generators generators = new Generators();

            // Instantiate second class in class library but call values right away
            // (curly braces instead of parens)
            PersonModel person = new PersonModel
            {
                Prefix = "Mr.",
                LastName = "Bass"
            };

            // Call in variables
            string welcomeMessage = generators.WelcomeMessage(person.Prefix, person.LastName);
            string farewellMessage = generators.FarewellMessage(person.Prefix, person.LastName);

            Console.WriteLine(welcomeMessage);
            Console.ReadKey();
            Console.WriteLine(farewellMessage);

            // Prevent console app from closing automatically
            Console.ReadLine();
        }
    }
}
