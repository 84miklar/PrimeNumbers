using PrimeNumbers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.PrimeHandler
{
    public class TestANumber
    {
        /// <summary>
        /// Checks if input is a prime number.
        /// </summary>
        /// <param name="numberToTest"></param>
        /// <returns>true if number is prime, false if not</returns>
        public bool PrimeCalculator(int numberToTest)
        {
            if (numberToTest > 0)
            {
                for (int i = 2; i < numberToTest; i++)
                {
                    if (i != numberToTest && numberToTest % i == 0)
                    {

                        return false;
                    }

                }
                if(!PrimeNumber.primeNumbers.Contains(numberToTest))
                {
                    PrimeNumber.primeNumbers.Add(numberToTest);
                    Console.WriteLine($"\n------{numberToTest} was added to the list of prime numbers------");
                }
                else Console.WriteLine($"\n{numberToTest} was already in the list of prime numbers");
                ControlHelper.PressEnter();
                return true;
           
            }
            
            return false;
        }
    }
}
