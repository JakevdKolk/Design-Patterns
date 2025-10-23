using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithCdCommand : Command
    {
        Stereo stereo;
        StereoMode prevMode;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
           stereo.SetMode(StereoMode.CD);
            stereo.PrintStatus();

            stereo.On();
           prevMode = stereo.GetMode();

        }

        public void Undo()
        {
            stereo.Off();

        }


    }
}
