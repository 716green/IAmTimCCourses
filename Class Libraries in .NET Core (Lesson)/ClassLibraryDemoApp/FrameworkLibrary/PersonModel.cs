using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLibrary
{
    // .NET FRAMEWORK
    public class PersonModel
    {
        // Make Class Public
        // Deleted Class1, added new class to Class Library named PersonModel
        // 'prop' + tab x2 is auto-property. Creates default 'Properties'
        // Properties are variables in PascalCase with  { get; set; }

        public string Prefix { get; set; } // Mr Ms Dr
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
