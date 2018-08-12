﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Web;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;

namespace ClearentUnitTest
{
    public class InterestCalculator
    {
        public static double CalculateTotalInterest(int timeInMonths, double cardBalance, string cardType)
        {
            double interestRate = 0;
            switch (cardType)
            {
                case "visa":
                    interestRate = 0.10;
                    break;
                case "mastercard":
                    interestRate = 0.05;
                    break;
                case "discover":
                    interestRate = 0.01;
                    break;
            }
            return timeInMonths * cardBalance * interestRate;
        }
    }
}
