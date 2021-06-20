using System.Collections.Generic;
using ObservablePattern.Observer;

namespace ObservablePattern.Observable
{
    public class WeatherStation : IObservable, IWeatherStation
    {
        private readonly ICollection<IObserver> observers;
        private double temperature;

        public WeatherStation(double temperature)
        {
            this.observers = new List<IObserver>();   
            this.temperature = temperature;
        }

        public double GetTemperature() 
            => this.temperature;

        public void SetTemperature(double temperature) 
        {
            this.temperature = temperature;
            this.Notify();
        }

        public void Notify()
        {
            foreach(var observer in this.observers)
            {
                observer.Update();
            }
        }

        public void Subscribe(IObserver observer)
        {
            if(this.observers.Contains(observer) == false)
            {
                this.observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            if(this.observers.Contains(observer) == true)
            {
                this.observers.Remove(observer);
            }
        }
    }
}