using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Demo_Serialisation
{
    public class WeatherForecast

    {
        public DateTimeOffset Date { get; set; }

        public int TemperatureCelsius { get; set; }

        public string Summary { get; set; }

    }
    public class program
    {

        static void Main(string[] args)
        {
            var WeatherForecast = new WeatherForecast

            {
                Date = DateTime.Parse("2021-09-01"),
                TemperatureCelsius = 29,
                Summary = " Delhi Weather is Extreme either too Much Hot or Cold"

            };

            string weatherString = JsonSerializer.Serialize(WeatherForecast);
            Console.WriteLine("My Json string is {0}", weatherString);
        }
    }
}

    
