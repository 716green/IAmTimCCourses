using ConsoleMethodStandardLibrary; // THIS IS THE CLASS LIBRARY
using System;

namespace DotNetCoreConsoleClassLibHW
{
    class Program
    {
        /// <summary>
        /// The following was a homework project from IAmTimCorey's 'Project Type' paid series. Below is a fairly good example of how to pass data from Classes
        /// Within Class Libraries to the actual application. Everything here is coded in .NET Standard.
        /// </summary>
        /// <param name="args"></param>
        
        
        // This is the actual application

        static void Main(string[] args)
        {
            Console.WriteLine("Account Signup:\n\nPlease enter your Title (Mr/Ms/Dr/Etc):");
            string prefix = Console.ReadLine();
            Console.WriteLine("Please enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your Middle Name");
            string middleName = Console.ReadLine();
            Console.WriteLine("Please enter your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your Suffix (Jr/Sr/MD/Esq)");
            string suffix = Console.ReadLine();
            // The 'Replace' part of this line can (and should) be deleted
            // because it takes place in the 'MethodsClass' class in the ConsoleMethodStandardLibrary
            string fullName = ($"{ prefix } { firstName } { middleName } { lastName } { suffix }").Replace("  ", " "); 

            // INSTANTIATE A CLASS FROM THE CLASS LIBRARY
            new HWConsumerLoginClass // Instantiate Consumer Login Class
            {
                Prefix = prefix,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Suffix = suffix
            };

            Console.WriteLine("What are your favorite 2 numbers?");
            Console.Write("Number 1: ");
            string x = Console.ReadLine();
            Console.Write("Number 2: ");
            string y = Console.ReadLine();

            int intx = Convert.ToInt32(x);
            int inty = Convert.ToInt32(y);

            // INSTANTIATE THE CLASS FROM THE CLASS LIBRARY THAT HAS THE METHODS IN IT
            // Removes unnessecary spaces from the user-input strings.
            MethodsClass methodsClass = new MethodsClass { }; // Instantiate and name class

            Console.WriteLine($"Your full name is: {methodsClass.RemoveSpaces(fullName)}\n and " + // Calls MethodsClass method to remove spaces
                $"the sum of the numbers you entered is: {methodsClass.AddNumbers(intx, inty)}"); // Calls MethodsClass to add numbers
        }
    }
}
