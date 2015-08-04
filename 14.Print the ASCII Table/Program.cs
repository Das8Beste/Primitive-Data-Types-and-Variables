using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

//Note: You may need to use for-loops (learn in Internet how).
namespace _14.Print_the_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i <= 255; i++)
            {
                System.Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }
}
