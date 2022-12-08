using System;

namespace DesignPatterns
{
  public class WeatherStation
  {

    public static void Main(string[] args)
    {
      WeatherData weatherData = new WeatherData();
      IObserver currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
      IObserver stupidDisplay = new StupidDisplay(weatherData);

      weatherData.setMeasurements(1.0f, 2.0f, 6.0f);
      weatherData.Remove(stupidDisplay);
      weatherData.setMeasurements(2.0f, 4.0f, 8.0f);
    }

  }
}