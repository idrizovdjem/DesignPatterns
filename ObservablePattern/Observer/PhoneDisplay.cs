using System;
using ObservablePattern.Observable;

namespace ObservablePattern.Observer
{
    public class PhoneDisplay : IDisplay, IObserver
    {
        private readonly WeatherStation weatherStation;

        public PhoneDisplay(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public string Display()
        {
            return $"Temp from displayed from phone: {this.weatherStation.GetTemperature()}";
        }

        public void Update()
        {
            Console.WriteLine(this.Display());
        }
    }
}