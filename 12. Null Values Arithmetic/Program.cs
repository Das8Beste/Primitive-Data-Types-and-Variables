using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
namespace _12.Null_Values_Arithmetic
{
    class Program
    {
        static void Main()
        {
            int? value = null;
            Console.WriteLine(value.HasValue);
            value = 1;
            Console.WriteLine(value.HasValue);
            Console.WriteLine(value.Value);
            Console.WriteLine(value);
            if (value == 1)
            {
                Console.WriteLine("True");
            }


            double? x;
            x = null;
            Console.WriteLine(x.HasValue);
            x = 5.6;
            Console.WriteLine(x.HasValue);
            Console.WriteLine(x.Value);
            if (value==5.6)
            {
                Console.WriteLine("True");              
            }
        }
    }
}
