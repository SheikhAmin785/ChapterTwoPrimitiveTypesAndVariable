using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwoPrimitiveTypesAndVariablee
{
    class BooleanType
    {
      static void Main()
        {
            int a = 1;
            int b = 2;
            bool greaterAB = (a > b);
            bool EqualA1 = (a == 1);
            if (greaterAB)
            {
                Console.WriteLine("A>B");
            }
            else
            {
                Console.WriteLine("A<=B")
            }
            Console.WriteLine("greaterAb=" + greaterAB);
            Console.WriteLine("EqualA1" + EqualA1);
        }
    }
}
//Console output:
// A <= B
// greaterAB = False
// equalA1 = True
