using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    class MethodCollection
    {
        public static  void Printext()
        {
            Console.WriteLine("Action Delegate PrintMeassage");
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
     class DelegateTypes
    {
        static void Main(string[] args)
        {
            Action PrintTEXT = new Action(MethodCollection.Printext);
            Func<int, int, int> add = new Func<int, int, int>(
                MethodCollection.Addition);
            PrintTEXT();
            
        }
        
    }
}
