using System;

namespace DesignPatterns
{
  public class StupidDisplay : IObserver, IDisplayElement
  {

    private float temperature;
    private float humidity;
    private ISubject weatherData;

    public StupidDisplay(ISubject weatherData)
    {
      this.weatherData = weatherData;
      this.weatherData.Register(this);
    }

    public void Display()
    {
      Console.WriteLine($"Stupid display {temperature.ToString()} F degress and {humidity.ToString()}% humidity");
    }

    public void Update(float temperature, float humidity, float pressure)
    {
      this.temperature = temperature * 5;
      this.humidity = humidity * 6;
      Display();
    }
  }
}