using System;

namespace DesignPatterns
{
  public class CurrentConditionsDisplay : IObserver, IDisplayElement
  {

    private float temperature;
    private float humidity;
    private ISubject weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
      this.weatherData = weatherData;
      this.weatherData.Register(this);
    }

    public void Display()
    {
      Console.WriteLine($"Current coditions {temperature.ToString()} F degress and {humidity.ToString()}% humidity");
    }

    public void Update(float temperature, float humidity, float pressure)
    {
      this.temperature = temperature;
      this.humidity = humidity;
      Display();
    }
  }
}