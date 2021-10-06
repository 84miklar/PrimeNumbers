using PrimeNumbers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.Views
{
    internal class MenuView
    {
        public static bool keepGoing = true;

        public static void OpenMenu()
        {
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("Welcome");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Test a number\n " +
                    "2. Show added numbers\n" +
                    "3. Add next prime number to the list\n" +
                    "4. Exit");
                var choice = ControlHelper.TryParse();
                MenuViewController.MenuController(choice);
            }
        }
    }
}
