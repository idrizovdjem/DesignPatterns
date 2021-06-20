namespace ObservablePattern.Observable
{
    public interface IWeatherStation
    {
        double GetTemperature();

        void SetTemperature(double temperature);
    }
}