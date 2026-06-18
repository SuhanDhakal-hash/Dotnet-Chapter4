using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    class Lanmbdaexpression
    {
        public int SquareMethod(int x)
        {
            return x * x;
        }
    }
    class lambda2
    {
        static void Main()
        {
            var square =(int number) => number * number;
            Console.WriteLine(square(5));

            var ResultingSum=(int a, int b) => a + b;
            
            Console.WriteLine(ResultingSum(3, 4));

            int[] number ={2,4,13,15,20
            };
        int  totalCount =number.Count(x=> x > 10);
            Console.WriteLine("Total Count of numbers greater than 10: " + totalCount);
        }
    }
}
