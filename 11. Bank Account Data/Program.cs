using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
namespace _11.Bank_Account_Data
{
    class Program
    {
        static void Main()
        {
            string firstName = "Natali";
            string middleName = "Angelova";
            string lastName = "Petkova";
            decimal balance = 19000M;
            string bankName = "Raifaissen";
            string iBan = "BG90IF 12345546654456654455454 RBB";
            int creditCard1 = 1234567891;
            int creditCard2 = 1234567891;
            int creditCard3 = 1234567891;

            Console.WriteLine("Full name: {0} {1} {2}, \n Ballance in account: {3},\n at {4}\n iBan: {5},\n Your cards are ending on: {6}, \n{7}\n{8}", firstName,middleName,lastName,balance,bankName,iBan, creditCard1,creditCard2,creditCard3);
        }
    }
}
