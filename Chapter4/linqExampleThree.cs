using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter4
{
    class LinqExampleThree
    {
        public static void Main()
        {
            List<string> str1 = new List<string>
            {
                "apple", "banana", "cherry", "date", "elderberry"
            };

            List<string> str2 = new List<string>
            {
                "One", "Two", "Three", "Four", "Five"
            };

            var innerJoinResult = str1.Join(
                str2,
                s1 => s1.Length,
                s2 => s2.Length,
                (s1, s2) => new { Str1 = s1, Str2 = s2 }
            );

            Console.WriteLine("Inner Join Result:");

            foreach (var item in innerJoinResult)
            {
                Console.WriteLine($"Str1: {item.Str1}, Str2: {item.Str2}");
            }

            var unionResult = str1.Union(str2);

            Console.WriteLine("\nUnion Result:");

            foreach (var value in unionResult)
            {
                Console.WriteLine(value);
            }

            List<string> marks = new List<string>
            {
                "100", "90", "80", "70", "60"
            };

            List<string> marks2 = new List<string>
            {
                "85", "75", "65", "55", "45"
            };

            int maxValue = marks.Max(m => int.Parse(m));
            int minValue = marks.Min(m => int.Parse(m));
            int sumValue = marks.Sum(m => int.Parse(m));
            double avgValue = marks.Average(m => int.Parse(m));

            Console.WriteLine("\nStatistics of Marks:");
            Console.WriteLine("Maximum = " + maxValue);
            Console.WriteLine("Minimum = " + minValue);
            Console.WriteLine("Sum = " + sumValue);
            Console.WriteLine("Average = " + avgValue);
        }
    }
}