using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentUnitTest
{
    public class InterestPerWallet
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
