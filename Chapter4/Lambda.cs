using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    public delegate void Prindel(int value);
    class AnoymousExample
    {
        public static void ExampleMethod(int val)
        {
            Console.WriteLine("INSIDE EXAMPLE METHOD: " + val);
        }
    }
    class Lambda
    {
        static void Main()
        {
            Prindel del = delegate (int x)
            {
                Console.WriteLine("INSIDE ANONYMOUS METHOD: " + x);
            };
            del(10);
            
        }
    }
}
