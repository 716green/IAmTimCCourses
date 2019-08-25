using ConsoleMethodStandardLibrary;
using System;

namespace DotNetCoreConsoleClassLibHW
{
    class Program
    {
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
            string fullName = $"{ prefix } { firstName } { middleName } { lastName } { suffix }".Replace("  ", " ");

            HWConsumerLoginClass loginClass = new HWConsumerLoginClass
            {
                Prefix = prefix,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Suffix = suffix
            };

            /*
            MethodsClass fullName = new MethodsClass
            {
                CleanName = cleanName
            };
            */
            Console.WriteLine($"Your full name is: {fullName}\n");
        }
    }
}
