using PrimeNumbers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.Views
{
    /// <summary>
    /// Handles the main menu.
    /// </summary>
    internal static class MenuView
    {
        public static bool keepGoing = true;

        /// <summary>
        /// Shows the main menu to user. Sends input choice to menu controller.
        /// </summary>
        public static void OpenMenu()
        {
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("\t***********");
                Console.WriteLine("\t* Welcome *");
                Console.WriteLine("\t***********");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Test a number\n" +
                    "2. Show added numbers\n" +
                    "3. Add next prime number to the list\n" +
                    "4. Exit");
                var choice = ControlHelper.TryParse();
                MenuViewController.MenuController(choice);
                if(choice != 4) ControlHelper.PressEnter();
            }
        }
    }
}
