using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    public delegate void ClickEventHandler(object sender, EventArgs e);

    public class Button
    {
        public event ClickEventHandler Click;

        
        public void OnClick()
        {
            Console.WriteLine("Button has been clicked");

            
            if (Click != null)
            {
            }
        }
    }

    class EventExampleTwo
    {
        public static void Main(string[] args)
        {
            Button button = new Button();
     
            button.OnClick();
    }

        public static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button was clicked!");
        }
    }
}