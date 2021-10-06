using PrimeNumbers.PrimeHandler;
using PrimeNumbers.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.Controllers
{
    public class MenuViewController
    {
        public static void MenuController(int choice)
        {
            switch (choice)
            {
                case 1:
                    TestANumberView.PrimeView();
                    break;
                case 2:
                    ShowAddedNumbersView.ShowAddedNumbers();
                    break;
                case 3:
                    AddNextPrime();
                    break;
                case 4:
                    MenuView.keepGoing = false;
                    break;
                default:

                    break;

            }

        }

        private static void AddNextPrime()
        {
            Console.WriteLine("Add next prime");
        }

        private static void ShowAddedNumbers()
        {
            Console.WriteLine("Show added");
        }

       
    
}
}
