using PrimeNumbers.Controllers;
using PrimeNumbers.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.PrimeHandler
{
    /// <summary>
    /// Class that tests if a number is a prime number.
    /// </summary>
    public class TestANumber
    {
        /// <summary>
        /// Checks if input is a prime number. Number must be more than 1, wich is not a prime number.
        /// </summary>
        /// <param name="numberToTest"></param>
        /// <returns>true if number is prime, false if not</returns>
        public bool PrimeCalculator(int numberToTest)
        {
            if (numberToTest > 1)
            {
                for (int i = 2; i < numberToTest; i++)
                {
                    if (i != numberToTest && numberToTest % i == 0) return false;
                }
                if (!PrimeNumber.PrimeNumbers.Contains(numberToTest))
                  TestANumberView.AddPrimeToList(numberToTest);
                else TestANumberView.DoNotAddPrimeToList(numberToTest);
                return true;
            }
            return false;
        }
    }
}
