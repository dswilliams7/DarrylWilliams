using System;
using System.Linq;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClearentUnitTest;
using System.Collections.Generic;
using System.Net.Mail;
using System.Web;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Text;
using System.Security.Cryptography;


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

            InterestCalculator c = new InterestCalculator();
            double interest = 0.00;
            double walletInterest = 0.00;
            double totalInterest = 0.00;
            double amount = 100.00;
            int time = 1;
            int NumberOfWallets = 1;
            int i = 0;
            string[][] person = new string[NumberOfWallets][];
            person[0] = new string[] { "visa", "mastercard", "discover" };
            foreach (string[] wallet in person)
            {
                walletInterest = 0.00;
                foreach (string card in wallet)
                {
                    interest = c.CalculateTotalInterest(time, amount, card);
                    Console.WriteLine("Wallet #"+ (i + 1) +"'s "  + card + " = $" + interest);
                    walletInterest += interest;
                    totalInterest += interest;    
                }
                i++;
                Console.WriteLine("Simple Interest for Wallet " + i + "  = $" + totalInterest + "\n");
            }
            Console.WriteLine("Total Simple Interest = $" + totalInterest);
            }
        }
    }

