using ObserverPattern.Business;

namespace ObserverPattern.Observers
{
    public class WeatherDisplay : IObserver
    {
        private string _name;
        private Dictionary<string, string> _lastValues = new Dictionary<string, string>();

        public WeatherDisplay(string name)
        {
            _name = name;
        }

        public void Update(string propertyName, string value)
        {
            _lastValues[propertyName] = value;
            DisplayCurrentInfo();
        }

        private void DisplayCurrentInfo()
        {
            Console.WriteLine($"\nDisplay {_name} - Status Update:");
            foreach (var item in _lastValues)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
