using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : AbstractDisplay
    {

        public ForecastDisplay(Subject wheaterData) : base(wheaterData)
        {

        }

       

        public override void Display()
        {
            switch (temperature)
            {
                case <= 0:
                    Console.WriteLine("It is time to put on a scarf!");
                    break;
                case > 0 and <= 10:
                    Console.WriteLine("It might be sweater weather");
                    break;
                case > 10 and < 20:
                    Console.WriteLine("It might still be sweater weather");
                    break;
                case > 20 and < 29:
                    Console.WriteLine("T-shirt weather it is");
                    break;
                default:
                    Console.WriteLine("Shaw");
                    break;
            }
        }
    }
}
