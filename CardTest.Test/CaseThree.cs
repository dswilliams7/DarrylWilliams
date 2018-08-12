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

            string[] walletOne = { "visa", "visa", "mastercard", "mastercard"};
            string[] walletTwo = { "visa", "mastercard"};
            double interestOne = 0.00;
            double interestTwo = 0.00;
            double totalInterestOne = 0.00;
            double totalInterestTwo = 0.00;
            double amount = 100.00;
            int time = 1;
            int i = 0;
            int j = 0;

            foreach (string card in walletOne)
            { 
                interestOne = ClearentUnitTest.InterestCalculator.CalculateTotalInterest(time, amount, card);
                Console.WriteLine("Person #1's "+ walletOne[i] + " = $" + interestOne);
                totalInterestOne += interestOne;
                i++;
            }
            foreach (string card in walletTwo)
            {
                interestTwo = ClearentUnitTest.InterestCalculator.CalculateTotalInterest(time, amount, card);
                Console.WriteLine("Person #2's " + walletTwo[j] + " = $" + interestTwo);
                totalInterestTwo += interestTwo;
                j++;
            }
            Console.WriteLine("Total Simple Interest for Person #1 = $" + totalInterestOne);
            Console.WriteLine("Total Simple Interest = for Person #2 $" + totalInterestTwo);
            Console.WriteLine("Total Simple Interest for Wallet #1 = $" + totalInterestOne);
            Console.WriteLine("Total Simple Interest = for Wallet #2 $" + totalInterestTwo);
            Xunit.Assert.Equal(30, totalInterestOne);
            Xunit.Assert.Equal(15, totalInterestTwo);

        }
    }
}
