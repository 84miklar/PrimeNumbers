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
                    TestANumberView.PrimeCalculatorView();
                    break;
                case 2:
                    ShowAddedNumbersView.ShowAddedNumbers();
                    break;
                case 3:
                    AddNextPrime.AddPrime();
                    break;
                case 4:
                    MenuView.keepGoing = false;
                    break;
                default:
                    if (choice > 4)
                        MenuView.DefaultView();
                    break;
            }
        }
     }
}
