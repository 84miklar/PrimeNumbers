using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.Controllers
{
    public class ControlHelper
    {
        public static int TryParse()
            {
                int.TryParse(Console.ReadLine(), out int parsedValue);
                return parsedValue;
            }
        }
}
