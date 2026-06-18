using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    internal class Oddnumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int[]numbers=Enumerable.Range(1,30).ToArray();
            var result = from n in numbers
                         where n % 2 != 0 && n % 3 == 0
                         select n;
            Console.WriteLine("Odd numbers that are divisible by 3:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
