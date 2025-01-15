// Maak een weather station (Subject)
using ObserverPattern.Business;
using ObserverPattern.Observers;

var weatherStation = new WeatherStation();
var display1 = new WeatherDisplay("Buiten");
var display2 = new WeatherDisplay("Binnen");

weatherStation.Attach(display1);
weatherStation.Attach(display2);

// Update verschillende properties
weatherStation.CurrentWeather = "Zonnig";
weatherStation.Temperature = 23.5;
weatherStation.Humidity = 65;

// Later een andere update
weatherStation.Temperature = 24.2;

// Verwijder één display
weatherStation.Detach(display2);

// Nog een update
weatherStation.CurrentWeather = "Licht bewolkt";
