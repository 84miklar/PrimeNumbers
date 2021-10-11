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
            if (PrimeNumber.SortList?.Count == 0) { Console.WriteLine("No numbers added..."); }
            else
            {
                foreach (var number in PrimeNumber.SortList)
                {
                    Console.WriteLine(number.Value);
                }
            }
        }
    }
}
