using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

namespace _10.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Natali";
            string lastName = "Petkova";
            int age = 26;
            string gender = "female";
            int personalID = 1267894555;
            int uniqueEmployeeNum = 27569999;

            Console.WriteLine("My name is {0} {1},\nI am {2} years old.\nI am {3}.\nPersonal ID {4}.\nUnique Employee Number {5}",
                firstName,lastName,age, gender, personalID,uniqueEmployeeNum);


        }
    }
}
