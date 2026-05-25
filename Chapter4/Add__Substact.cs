using System;

namespace Chapter4
{
    
    public delegate int Operation(int a, int b);

    class Add_And_Subtract
    {
        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            
            Operation add = Add;
            Operation subtract = Subtract;

            int a = 10;
            int b = 5;

            
            int sum = add(a, b);
            int difference = subtract(a, b);

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Difference = " + difference);

            Console.ReadLine();
        }
    }
}