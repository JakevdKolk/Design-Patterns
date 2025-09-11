using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : AbstractDisplay
    {
        private float sumTemperature = 0;
        private float maxTemp;
        private float? minTemp = null;
        private int countUpdated = 0;

        private List<float> temperatures = new List<float>();
        public StatisticsDisplay (Subject wheaterData) : base(wheaterData)
        {

        }

        private void CalulateTempratureStats()
        {
            temperatures.Add(temperature);
            countUpdated++;
            if (temperature < minTemp || minTemp == null)
            {
                minTemp = temperature;
            }
            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }
            float tempTemperature = 0;
            foreach (float temperature in temperatures)
            {
                tempTemperature = tempTemperature + temperature;
            }
            sumTemperature = tempTemperature / countUpdated;

        }


        public override void Display()
        {
            CalulateTempratureStats();
            Console.WriteLine(
                $"max temp: {maxTemp} " +
                $"min temp: {minTemp} " +
                $"average temp: {sumTemperature}  "
            );
        }
    }
}
