using System;


//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.
//namespace _2.Float_or_Double

class Program
{
    static void Main()
    {
        float numF = 12.345F;
        double numF2 = 3456.091;
        double numD = 8923.1234857;
        double numD2 = 34.567839023;

        Console.WriteLine("We are floats: \n {0} \n and \n{1} \n hmm We are doublesss: \n {2} \n and \n {3}", numF,numF2,numD,numD2);


    }
}

