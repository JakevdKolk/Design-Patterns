using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOffCommand : Command
    {
        Stereo stereo;
        StereoMode prevMode;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.Off();
            stereo.PrintStatus();

            prevMode = stereo.GetMode();
        }
        public void Undo()
        {
            stereo.On();
            stereo.SetMode(prevMode);
            stereo.PrintStatus();

        }
    }
}
