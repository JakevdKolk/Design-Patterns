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
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.SetSpeed(ceilingFan.prevSpeed);
            ceilingFan.Medium();
        }

        public void Undo()
        {
            ceilingFan.SetSpeed(ceilingFan.prevSpeed);
            Console.WriteLine(ceilingFan.location + " is on: " + ceilingFan.GetSpeed());

        }
    }
}
