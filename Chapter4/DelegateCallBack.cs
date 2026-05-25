using System;

namespace Chapter4
{
    public delegate void CallBack(string name);

    class DelegateExampleClass
    {
        public static void LogMessage(CallBack callback)
        {
            Console.WriteLine("Hello from LogMessage Method");

            callback("Student");
        }

        public static void CallbackMethodOne(string value)
        {
            Console.WriteLine($"Hello, {value} from Callback Method One");
        }

        public static void CallbackMethodTwo(string value)
        {
            Console.WriteLine($"Hello, {value} from Callback Method Two");
        }

        static void Main(string[] args)
        {
            
            DelegateExampleClass.LogMessage(CallbackMethodOne);
            DelegateExampleClass.LogMessage(CallbackMethodTwo);

        }
    }
}