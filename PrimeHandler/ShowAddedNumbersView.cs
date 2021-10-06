using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.PrimeHandler
{
    public class ShowAddedNumbersView
    {
        internal static void ShowAddedNumbers()
        {
            Console.Clear();
            Console.WriteLine("All prime numbers in list:\n");
            if (PrimeNumber.primeNumbers.Count == 0)
            {
                Console.WriteLine("No numbers added...");
            }
            else
            {
                PrimeNumber.primeNumbers.Sort();
                foreach (var number in PrimeNumber.primeNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine("\nPlease press enter to continue.");
            Console.ReadKey();
        }
    }
}
