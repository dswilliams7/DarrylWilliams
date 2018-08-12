using System;
using System.Collections;
using System.Linq;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardTest.Test
{
    [TestClass]
    public class CaseTwo
    {
        [TestMethod]
        public void TestMethod1()
        {
            //1 person has 2 wallets Wallet 1 has a Visa and Discover , 
            //wallet 2 a MC -each card has $100 balance - 
            //calculate the total interest(simple interest) for this person and interest per wallet

            InterestCalculator c = new InterestCalculator();
            double interest = 0.00;
            double walletInterest = 0.00;
            double totalInterest = 0.00;
            double amount = 100.00;
            int time = 1;
            int NumberOfWallets = 2;
            int i = 0;
            string[][] person = new string[NumberOfWallets][];
            person[0] = new string[] { "visa", "discover" };
            person[1] = new string[] { "mastercard" };

            foreach (string[] wallet in person)
            {
                walletInterest = 0.00;
                foreach (string card in wallet)
                {
                    interest = c.CalculateTotalInterest(time, amount, card);
                    Console.WriteLine("Wallet #" + (i + 1) + "'s " + card + " = $" + interest);
                    walletInterest += interest;
                    totalInterest += interest;
                }
                i++;
                Console.WriteLine("Simple Interest for Wallet " + i + "  = $" + walletInterest + "\n");
            }
            Console.WriteLine("Total Simple Interest = $" + totalInterest);
        }
    }
}
