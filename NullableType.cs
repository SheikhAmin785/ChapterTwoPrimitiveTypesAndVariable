using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwoPrimitiveTypesAndVariablee
{
    class NullableType
    {
        static void Main()
        {
            Nullable<int> I1 = null;
            int? I2 = I1;

            int i = 5;
            int? ni = i; //Reference type

            Console.WriteLine(ni);
            int? age = null;


        }
    }
}

Nullable is int double bool
nullable is Reference type
a variable is container of information.
Primitive data type(int ,char,bool)
reference type(string object array)
<Data type >< identifier >[= Initialization];
string name;
int age;
bool result = true;
char ch = 'A';
byte[] bytes={ 1,2,3};
-\

