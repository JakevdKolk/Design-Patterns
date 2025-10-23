using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.Medium();
            ceilingFan.SetSpeed(prevSpeed);
        }

        public void Undo()
        {
            ceilingFan.SetSpeed(prevSpeed);
            Console.WriteLine(ceilingFan.location + " is on: " + ceilingFan.GetSpeed());

        }
    }
}
