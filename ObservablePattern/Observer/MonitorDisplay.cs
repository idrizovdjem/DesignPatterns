using System;
using ObservablePattern.Observable;

namespace ObservablePattern.Observer
{
    public class MonitorDisplay : IDisplay, IObserver
    {
        private readonly WeatherStation weatherStation;

        public MonitorDisplay(WeatherStation weatherStation)
        {
           this.weatherStation = weatherStation; 
        }

        public string Display()
        {
            return $"Temp from monitor display: {this.weatherStation.GetTemperature()}";
        }

        public void Update()
        {
            Console.WriteLine(this.Display());
        }
    }
}