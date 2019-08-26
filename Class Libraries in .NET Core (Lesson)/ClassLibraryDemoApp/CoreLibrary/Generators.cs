using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary
{
    // .NET CORE
    public class Generators
    {
        // .NET CORE
        // COPIED AND PASTED FROM .NET FRAMEWORK Generators.cs to compare .NET Framework to .NET Core

        // Class libraries should not have UI code in them unless it is a UI specific Class Library
        // Ex. Don't use Console.WriteLine because not all apps are console apps

        // Variables need to be defined in each method

        public string WelcomeMessage(string prefix, string lastName) // Call Variables from PersonModel Class using all lowercase
        {
            // String Interpolation
            return $"Welcome to our demo application { prefix } { lastName }";
        }

        public string FarewellMessage(string prefix, string lastName)
        {
            return $"I hope you enjoyed your time with us { prefix } { lastName }. Please come back soon.";
        }

    }
}
