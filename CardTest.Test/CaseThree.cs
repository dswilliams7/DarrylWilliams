using System;
using System.Linq;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CardTest.Test
{
    [TestClass]
    public class CaseThree
    {
        [TestMethod]
        public void TestMethod1()
        {
            //2 people have 1 wallet each,  person 1 has 1 wallet , with 2 cards MC and visa
            //person 2 has 1 wallet – 1 visa and 1 MC -
            //each card has $100 balance - calculate the total interest(simple interest) for each person and interest per wallet

            InterestCalculator c = new InterestCalculator();
            double interest = 0.00;
            double walletInterest = 0.00;
            double totalInterest = 0.00;
            double amount = 100.00;
            int time = 1;
            int NumberOfWallets = 2;
            int i = 0;
            string[][] person = new string[NumberOfWallets][];
            person[0] = new string[] { "visa", "visa", "mastercard", "mastercard" };
            person[1] = new string[] { "visa", "mastercard" };

            foreach (string[] wallet in person)
            {
                if (person[i] != null && i != 0)
                {
                    totalInterest = 0;
                }
                walletInterest = 0.00;
                foreach (string card in wallet)
                {
                    interest = c.CalculateTotalInterest(time, amount, card);
                    Console.WriteLine("Wallet #" + (i + 1) + "'s " + card + " = $" + interest);
                    walletInterest += interest;
                    totalInterest += interest;
                }
                i++;
                Console.WriteLine("Simple Interest for Wallet " + i + "  = $" + totalInterest);
                Console.WriteLine("Total Simple Interest for Person " + i + "  = $" + totalInterest + "\n");

            }
        }
    }
}

