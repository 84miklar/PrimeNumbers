﻿using System;

namespace PrimeNumbers.Controllers
{
    /// <summary>
    /// Class for handling help methods.
    /// </summary>
    public class ControlHelper
    {
        /// <summary>
        /// Method that takes input from user and tries to parse it to a number.
        /// </summary>
        /// <returns>parsed number. If input is not a number, or <1, value is 0.</returns>
        public static int TryParse()
        {
            int.TryParse(Console.ReadLine(), out int parsedValue);
            if (parsedValue <= 0)
            {
                Console.WriteLine("Invalid input. Input must be an integer more than 0.");
            }
            return parsedValue;
        }
        /// <summary>
        /// Sends a message to user to press enter button.
        /// </summary>
        public static void PressEnter()
        {
            Console.WriteLine("Please press enter to continue.");
            Console.ReadKey();
        }
    }
}