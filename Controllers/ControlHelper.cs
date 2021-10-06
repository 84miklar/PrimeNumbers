using System;

namespace PrimeNumbers.Controllers
{
    public class ControlHelper
    {
        public static int TryParse()
        {
            int.TryParse(Console.ReadLine(), out int parsedValue);
            if (parsedValue == 0)
            {
                Console.WriteLine("Invalid input. Input must be an integer more than 0.");
                PressEnter();
            }
            return parsedValue;
        }
        public static void PressEnter()
        {
            Console.WriteLine("Please press enter to continue.");
            Console.ReadKey();
        }

       

    }
}