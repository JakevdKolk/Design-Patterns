// ConcreteDisplay.cs
using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    public abstract class AbstractDisplay : DisplayElement, Observer
    {
        protected float temperature;
        protected float humidity;
        protected float pressure;
        protected Subject weatherData;

        protected AbstractDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
           
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public abstract void Display();
    }
}
