using System.Collections.Generic;

namespace DesignPatterns
{
  public class WeatherData : ISubject
  {

    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
      this.observers = new List<IObserver>();
    }

    public void Register(IObserver o)
    {
      this.observers.Add(o);
    }

    public void Remove(IObserver o)
    {
      int i = observers.IndexOf(o);
      if (i >= 0)
      {
        observers.RemoveAt(i);
      }
    }

    public void Notify()
    {
      foreach (var ob in observers)
      {
        ob.Update(temperature, humidity, pressure);
      }
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
      this.temperature = temperature;
      this.humidity = humidity;
      this.pressure = pressure;
      this.Notify();
    }




  }
}