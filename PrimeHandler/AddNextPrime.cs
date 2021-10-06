using PrimeNumbers.PrimeHandler;
using System;
using System.Linq;

namespace PrimeNumbers.Controllers
{
    internal class AddNextPrime
    {
        internal static void AddPrime()
        {
            
            var test = new TestANumber();
            if (PrimeNumber.primeNumbers.Count > 0)
            {
                PrimeNumber.primeNumbers.Sort();
                var lastNum = PrimeNumber.primeNumbers.Last();
                var listLenght = PrimeNumber.primeNumbers.Count();
                for (int i = lastNum + 1; i < int.MaxValue; i++)
                {
                    test.PrimeCalculator(i);
                    if (PrimeNumber.primeNumbers.Count() == listLenght + 1)
                    {
                        break;
                    }
                }
            }
            else
            {
            Console.Clear();
            Console.WriteLine("No numbers in list...");
            ControlHelper.PressEnter();
            }
        }
    }
}