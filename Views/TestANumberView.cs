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
            Console.Write("Please enter number: ");
            var number = ControlHelper.TryParse();
            tester.PrimeTester(number);
        }
    }
}