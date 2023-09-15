using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwoPrimitiveTypesAndVariablee
{
    class StringClass
    {
        static void Main()
        {
            string firstName= "alamin";
            string lastName = "Sheikh";
            string fullName = firstName + "" + lastName;
            Console.WriteLine("Hello," + firstName + "!");
            Console.WriteLine("your fullName is" + fullName + "!");

        }
    }
}
// Console output:
// Hello, Alamin!
// Your full name is Alamin Sheikh.
