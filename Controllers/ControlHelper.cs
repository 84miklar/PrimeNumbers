using System;

namespace PrimeNumbers.Controllers
{
    public class ControlHelper
    {
        public static int TryParse()
        {
            int.TryParse(Console.ReadLine(), out int parsedValue);
            if (parsedValue == 0) Console.WriteLine("Wrong type of input");
            return parsedValue;
        }

       

    }
}