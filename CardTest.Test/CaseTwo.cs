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

            string[] walletOne = { "visa", "mastercard","" };
            string[] walletTwo = { "mastercard" };
            double amount = 100.00;
            int time = 1;
            walletTwo.CopyTo(walletOne, 2);
            double interest = 0.00;
            double totalInterest = 0.00;
            int i = 0;

            foreach (string card in walletOne)
            {
                interest = ClearentUnitTest.InterestCalculator.CalculateTotalInterest(time, amount, card);
                totalInterest += interest;
                if (i == 1)
                    Console.WriteLine("Simple Interest for Wallet 1 = $" + totalInterest);
                if (i == 2)
                    Console.WriteLine("Simple Interest for Wallet 2 = $" + interest);
                i++;
            }
            Console.WriteLine("Total Simple Interest = $" + totalInterest);
            Xunit.Assert.Equal(20, totalInterest);
        }
    }
}
