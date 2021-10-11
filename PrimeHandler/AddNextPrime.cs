using PrimeNumbers.PrimeHandler;
using System;
using System.Linq;

namespace PrimeNumbers.Controllers
{
    /// <summary>
    /// Class that finds the next prime number.
    /// </summary>
    internal class AddNextPrime
    {
        /// <summary>
        /// Add the next prime number to the list. List of prime numbers can not be empty or null.
        /// Sorts list and sends next number to prime calculator.
        /// If a prime is added to list, the loop breaks.
        /// </summary>
        internal static void AddPrime()
        {
            var testNumber = new TestANumber();
            if (PrimeNumber.PrimeNumbers.Count > 0 || PrimeNumber.PrimeNumbers == null)
            {
                PrimeNumber.PrimeNumbers.Sort();
                var lastNumber = PrimeNumber.PrimeNumbers.Last();
                var listLenght = PrimeNumber.PrimeNumbers.Count();
                for (int i = lastNumber + 1; i < int.MaxValue; i++)
                {
                    testNumber.PrimeCalculator(i);
                    if (PrimeNumber.PrimeNumbers.Count() == listLenght + 1)
                    {
                        break;
                    }
                }
            }
            else
            {
            Console.Clear();
            Console.WriteLine("No numbers in list...");
            }
        }
    }
}