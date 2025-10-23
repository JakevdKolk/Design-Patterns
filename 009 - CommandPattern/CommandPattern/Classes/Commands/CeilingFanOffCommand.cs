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
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;

        }

        public void Execute()
        {
            ceilingFan.Off();
            prevSpeed = ceilingFan.GetSpeed();
        }

        public void Undo()
        {
            ceilingFan.SetSpeed(prevSpeed);
            Console.WriteLine(ceilingFan.location + " is on: " + ceilingFan.GetSpeed());

        }
    }
}
