using ObservablePattern.Observable;
using ObservablePattern.Observer;

namespace ObservablePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var initialTemperature = 10.0;
            var weatherStation = new WeatherStation(initialTemperature);

            var phoneDisplay = new PhoneDisplay(weatherStation);
            weatherStation.Subscribe(phoneDisplay);

            var monitorDisplay = new MonitorDisplay(weatherStation);
            weatherStation.Subscribe(monitorDisplay);

            weatherStation.SetTemperature(15.0);
        }
    }
}
