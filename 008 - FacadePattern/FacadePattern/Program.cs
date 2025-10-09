namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            HomeTheaterFacade facade = new HomeTheaterFacade(tuner, screen, popcornPopper, lights, amp, cdPlayer, dvdPlayer, projector);

            facade.WatchMovie("Die Hard");
            facade.EndMovie();
            facade.ListenToCd();
            facade.EndCd();
            facade.ListenToRadio();
            facade.EndRadio();

        }

        //static void oldMain(string[] args)
        //{
        //    Amplifier amp = new Amplifier();
        //    CdPlayer cdPlayer = new CdPlayer(amp);
        //    DvdPlayer dvdPlayer = new DvdPlayer(amp);
        //    PopcornPopper popcornPopper = new PopcornPopper();
        //    Projector projector = new Projector();
        //    Screen screen = new Screen();
        //    TheaterLights lights = new TheaterLights();
        //    Tuner tuner = new Tuner(amp);


        //    popcornPopper.On();
        //    popcornPopper.Pop();

        //    lights.Dim(10);

        //    screen.Down();

        //    projector.On();
        //    projector.SetInput(dvdPlayer);
        //    projector.WideScreenMode();

        //    amp.On();
        //    amp.SetDvd(dvdPlayer);
        //    amp.SetSurroundSound();
        //    amp.SetVolume(5);

        //    dvdPlayer.On();
        //    dvdPlayer.Play("Die Hard");
        //}
    }
}