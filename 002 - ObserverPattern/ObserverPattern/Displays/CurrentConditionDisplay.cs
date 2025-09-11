// CurrentConditionDisplay.cs
using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : AbstractDisplay
    {
        public CurrentConditionDisplay(Subject weatherData) : base(weatherData)
        {
       
        }

        public override void Display()
        {
            Console.WriteLine(
                $"Here are the stats: " +
                $"temperature: {temperature}, " +
                $"pressure: {pressure}, " +
                $"humidity: {humidity}"
            );
        }
    }
}
