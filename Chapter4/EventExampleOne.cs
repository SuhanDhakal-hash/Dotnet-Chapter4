using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    
    public delegate void DelventHandler(string message);

    public class EventExampleOne
    {
       
        public static event DelventHandler add;

        
        static void USA(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("USA is the best country in the world");
        }

        static void Nepal(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Country: Nepal");
        }

        static void Japan(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Country: Japan");
        }

        static void Main()
        {
            
            add += USA;
            add += Nepal;
            add += Japan;


            add("Event triggered");
        }
    }
}