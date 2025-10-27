using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;

        }

        public void Execute()
        {
            ceilingFan.prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
        }

        public void Undo()
        {
            ceilingFan.SetSpeed(ceilingFan.prevSpeed);
            Console.WriteLine(ceilingFan.location + " is on: " + ceilingFan.GetSpeed());

        }
    }
}
