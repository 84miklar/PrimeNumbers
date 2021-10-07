using PrimeNumbers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.PrimeHandler
{
    /// <summary>
    /// Handles the presentation of the list of prime numbers.
    /// </summary>
    public static class ShowAddedNumbersView
    {
        /// <summary>
        /// Presents all the numbers in the list of prime numbers.
        /// List must contain more than 0 or not be null.
        /// </summary>
        internal static void ShowAddedNumbers()
        {
            Console.Clear();
            Console.WriteLine("All prime numbers in list:\n");
            if (PrimeNumber.primeNumbers?.Count == 0) Console.WriteLine("No numbers added...");
            else
            {
                PrimeNumber.primeNumbers.Sort();
                foreach (var number in PrimeNumber.primeNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            ControlHelper.PressEnter();
        }
    }
}
