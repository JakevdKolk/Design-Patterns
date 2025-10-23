using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{

    public enum StereoMode
    {
        Off,
        CD,
        DVD,
        Radio
    }   

    internal class Stereo
    {
        StereoMode StereoMode;
       
        public Stereo()
        {
            StereoMode = StereoMode.Off;
        }   

        public void On()
        {
            Console.WriteLine("Stereo was turned on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo was turned off");
        }


        public void SetVolume(int volume)
        {
            Console.WriteLine("Stereo volume set to" + volume);
        }

        public void PrintStatus()
        {
            Console.WriteLine("Stereo is currently in " + StereoMode + " mode.");
        }

        public StereoMode GetMode()
        {
            return StereoMode;
        }

        public void SetMode(StereoMode mode)
        {
            StereoMode = mode;
        }
    }
}
