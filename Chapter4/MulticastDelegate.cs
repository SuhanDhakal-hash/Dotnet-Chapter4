using System;

namespace Chapter4
{
    
    delegate int NumberChanges(int x);

    class MultiDelegate
    {
        static int num = 10;

        
        public static int AddNum(int x)
        {
            num += x;
            return num;
        }

        
        public static int MulNum(int x)
        {
            num *= x;
            return num;
        }

        
        public static int GetNum()
        {
            return num;
        }
    }

    internal class MulticastDelegate
    {
        static void Main(string[] args)
        {
           
            NumberChanges nc;

            nc = new NumberChanges(MultiDelegate.AddNum);
            nc += new NumberChanges(MultiDelegate.MulNum);

            int result = nc(5);

            Console.WriteLine("Result: " + result);
            Console.WriteLine("Final Value of num: " + MultiDelegate.GetNum());

            
        }
    }
}