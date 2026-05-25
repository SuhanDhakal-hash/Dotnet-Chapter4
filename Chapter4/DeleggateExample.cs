using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    public delegate void DisplayMessage(string message);
    class DeleggateExample
    {
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int MyMethod(int a)
        {
            return a * a; ;
        }
        public static void Main(string[] args)
        {
            DisplayMessage display = ShowMessage;
            display("Hello, World! from DelegateExample");
            Func<int, int> square = MyMethod;
            int result = square(10);
            Console.WriteLine($"The square of 10 is: {result}");
        }
    }
}
