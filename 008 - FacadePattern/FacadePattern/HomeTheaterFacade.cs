using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
	internal class HomeTheaterFacade
	{
		private Tuner _tuner;
		private Screen _screen;
		private PopcornPopper _popcornPopper;
		private TheaterLights _theatherLights;
		private Amplifier _amplifier;
		private CdPlayer _cdPlayer;
		private DvdPlayer _dvdPlayer;
		private Projector _projector;

		public HomeTheaterFacade(Tuner tuner, Screen screen, PopcornPopper popcornPopper, TheaterLights theaterLight, Amplifier amplifier, CdPlayer cdPlayer, DvdPlayer dvdPlayer, Projector projector)
        {
            this._tuner = tuner;
            this._screen = screen;
            this._popcornPopper = popcornPopper;
            this._theatherLights = theaterLight;
            this._amplifier = amplifier;
            this._cdPlayer = cdPlayer;
            this._dvdPlayer = dvdPlayer;
            this._projector = projector;
        }

        public void WatchMovie(string movie)
		{
			_popcornPopper.On();
			_popcornPopper.Pop();
			Console.WriteLine("Popcorn has popped");

			_theatherLights.Dim(10);
			Console.WriteLine("Theaterlights have dimmed");



			_screen.Down();
			Console.WriteLine("The screen has gone down");


			_projector.On();
			_projector.SetInput(_dvdPlayer);
			_projector.WideScreenMode();
			Console.WriteLine("The projector turned on");


			_amplifier.On();
			_amplifier.SetDvd(_dvdPlayer);
			_amplifier.SetSurroundSound();
			_amplifier.SetVolume(5);
			Console.WriteLine("Let's break this down!");



			_dvdPlayer.On();
			_dvdPlayer.Play(movie);
			Console.WriteLine("Have fun watching: " + movie);


		}

		public void EndMovie()
		{
			_popcornPopper.Off();
			Console.WriteLine("The popcorn poper has been turned off D:");


			_theatherLights.Off();
			Console.WriteLine("The lights have been turned off");


			_screen.Up();
			Console.WriteLine("The screen has gone up");


			_projector.Off();
			Console.WriteLine("The projector has been turned off");


			_amplifier.Off();
			Console.WriteLine("Vamos esculachar!");


			_dvdPlayer.Off();
			Console.WriteLine("Your movie has finished D:");


		}

		public void ListenToCd()
		{


			_amplifier.On();
			_amplifier.SetCd(_cdPlayer);
			_amplifier.SetStereoSound();
			_amplifier.SetVolume(5);
			Console.WriteLine("Let's break this down!");

			_cdPlayer.On();


			_cdPlayer.Play();
			Console.WriteLine("A cd has been played. If only there was a way to know which cd you were playing D:");



		}

		public void EndCd()
		{

			_cdPlayer.Eject();
			_cdPlayer.Off();
			_amplifier.Off();
			Console.WriteLine("God is disapointed in your horrible music taste so he ended your cd");


		}

		public void ListenToRadio()
		{
			_tuner.On();
			_tuner.setFrequency();

			_amplifier.On();
			_amplifier.SetTuner(_tuner);
			Console.WriteLine("De leeuw gaat er van uit dat de tuner van een radio is");
			_amplifier.SetStereoSound();
			_amplifier.SetVolume(5);
			Console.WriteLine("Welkom bij DJ Sjaak hier is een onbekend nummer");




		}

		public void EndRadio()
		{
			_tuner.Off();
			_amplifier.Off();
			Console.WriteLine("De leeuw verwacht hiermee geen revisie");

		}
	

	}
}
