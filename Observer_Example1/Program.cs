namespace Observer_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            TemperatureDisplay display1 = new TemperatureDisplay();
            MobileAppDisplay display2 = new MobileAppDisplay();

            weatherStation.RegisterObserver(display1);
            weatherStation.RegisterObserver(display2);

            weatherStation.Temperature = 25.5; // Updates both displays
            weatherStation.Temperature = 30.0; // Updates both displays
        }
    }
    public interface IWeatherStation
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
    public class WeatherStation : IWeatherStation
    {
        private double temperature;
        private List<IObserver> observers = new List<IObserver>();
        public double Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                NotifyObservers();
            }
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }

    public interface IObserver
    {
        void Update(double Temperature);
    }
    public class TemperatureDisplay : IObserver
    {
        public void Update(double Temperature)
        {
            Console.WriteLine($"Temperature display {Temperature}");
        }
    }
    public class MobileAppDisplay : IObserver
    {
        public void Update(double Temperature)
        {
            Console.WriteLine($"Mobile App display {Temperature}");
        }
    }
}