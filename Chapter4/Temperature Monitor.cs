using System;

namespace TemperatureMonitor
{
    
    public delegate void TemperatureAlert(string message);

    
    class Thermometer
    {
        public void CheckTemperature(int temp, TemperatureAlert alert)
        {
            Console.WriteLine("Checking Temperature...");

            if (temp > 40)
            {
                alert("Warning! High Temperature Detected.");
            }
            else
            {
                Console.WriteLine("Temperature is Normal.");
            }
        }
    }

    
    class ThermometerManager
    {
        
        public static void DisplayAlert(string message)
        {
            Console.WriteLine(message);
        }

        
        static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer();

            
            TemperatureAlert alert = DisplayAlert;

            
            thermometer.CheckTemperature(45, alert);

            Console.ReadLine();
        }
    }
}