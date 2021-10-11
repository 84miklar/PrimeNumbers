using PrimeNumbers.Controllers;
using PrimeNumbers.PrimeHandler;
using System;

namespace PrimeNumbers.Views
{
    /// <summary>
    /// Handles the UI for TestANumber class.
    /// </summary>
    internal class TestANumberView
    {
        /// <summary>
        /// Handles the UI for PrimeCalculator method.
        /// Checks if input is a correct number.
        /// </summary>
        public static void PrimeCalculatorView()
        {
            var tester = new TestANumber();
            Console.Clear();
            Console.Write("Please enter number: ");
            var number = ControlHelper.TryParse();
            if (!tester.PrimeCalculator(number) && number != 0)
            {
                Console.WriteLine("\nThis was not a prime number");
            }
        }

        /// <summary>
        /// Adds a prime number to the list of prime numbers.
        /// Presents a positive result of the tested number.
        /// </summary>
        /// <param name="numberToTest"></param>
        public static void AddPrimeToList(int numberToTest)
        {
            Console.WriteLine($"\n------{numberToTest} was added to the list of prime numbers------");
        }

        /// <summary>
        /// Presents a negative result of the tested number.
        /// </summary>
        /// <param name="numberToTest"></param>
        public static void DoNotAddPrimeToList(int numberToTest)
        {
            Console.WriteLine($"\n{numberToTest} was already in the list of prime numbers");
        }
    }
}