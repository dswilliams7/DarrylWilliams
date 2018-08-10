using System;
using System.Linq;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardTest.Test
{
    [TestClass]
    public class CaseOne
    {
        [TestMethod]
        public void TestMethod1()
        {
            //•	1 person has 1 wallet and 3 cards (1 Visa, 1 MC 1 Discover)
            //– Each Card has a balance of $100
            //– calculate the total interest (simple interest) for this person and per card.
             
            string[] wallet = { "visa", "mastercard", "discover" };
            double interest = 0.00;
            double totalInterest = 0.00;
            double amount = 100.00;
            int time = 1;
            int i = 0;
            foreach (string card in wallet)
            {
                interest = ClearentUnitTest.InterestCalculator.CalculateTotalInterest(time, amount, card);
                Console.WriteLine("Wallet #1's " + wallet[i] + " = $" + interest);
                totalInterest += interest;
                i++;
            }
            Console.WriteLine("Total Simple Interest = $" + totalInterest);
            Xunit.Assert.Equal(16,totalInterest);
        }
    }
}
