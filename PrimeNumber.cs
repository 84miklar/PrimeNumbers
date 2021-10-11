using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    /// <summary>
    /// Class that holds the public static list of prime numbers.
    /// </summary>
    public class PrimeNumber
    {
        public static SortedList<int, int> SortList { get; set; } = new();
    }
}
