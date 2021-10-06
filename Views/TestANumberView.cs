using PrimeNumbers.Controllers;
using PrimeNumbers.PrimeHandler;
using System;

namespace PrimeNumbers.Views
{
    internal class TestANumberView
    {
        public static void PrimeView()
        {
            var tester = new TestANumber();
            Console.Clear();
            Console.Write("Please enter number: ");
            var number = ControlHelper.TryParse();
            if (!tester.PrimeCalculator(number))
            {
                Console.WriteLine("\nThis was not a prime number");
                ControlHelper.PressEnter();
            }
        }
    }
}