﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

namespace _9.Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a={0}\nb={1}",a,b);

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a={0}\nb={1}", a, b);

        }
    }
}
