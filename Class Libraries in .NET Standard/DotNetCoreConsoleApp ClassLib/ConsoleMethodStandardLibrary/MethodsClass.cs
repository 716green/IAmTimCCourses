using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMethodStandardLibrary
{
    public class MethodsClass
    {
        public int AddNumbers(int x, int y)
        {
            return x + y;
        }

        public string RemoveSpaces(string x)
        {
            while (x.Contains("  "))
            {
                x = x.Replace("  ", " ");
            }
            if (x.StartsWith(" "))
            {
                x = x.Trim();
            }
            return x;
        }
    }
}
