using System;

namespace DatingApp.API.Models
{
    public class Weather
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}