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
        public bool PrimeTester(int numberToTest)
        {
            var listOfNumbers = new List<int>();
            if (numberToTest > 0)
            {
                for (int i = 2; i < numberToTest; i++)
                {
                    listOfNumbers.Add(i);
                }
                listOfNumbers.Remove(numberToTest);

                foreach (var num in listOfNumbers)
                {
                    if (numberToTest % num == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }
    }
}
