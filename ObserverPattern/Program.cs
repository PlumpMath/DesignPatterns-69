using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentDisply = new CurrentConditionDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);
            var forecast = new ForecastDisplay(weatherData);

            weatherData.Temperature = 80;

            Console.WriteLine("------------------------------------------");

            weatherData.Humidity = 65;

            Console.WriteLine("------------------------------------------");

            weatherData.Pressure = 30.4f;

            Console.WriteLine("------------------------------------------");


            weatherData.SetMeasurements(82, 70, 29.2f);

            Input(weatherData);
        }

        static void Input(WeatherData weatherData)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("To update weather measurements please enter the following format temperature,humidity,pressure (ex. 80,65,30.4)");
            var input = Console.ReadLine(); // Get string from user
            if (input != null)
            {
                var inputs = input.Split(',');
                weatherData.SetMeasurements(
                    Convert.ToSingle(inputs[0]), 
                    Convert.ToSingle(inputs[1]), 
                    Convert.ToSingle(inputs[2])
                );
            }

            Input(weatherData);
        }
    }
}
