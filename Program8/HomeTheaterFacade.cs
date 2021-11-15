using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    public class HomeTheaterFacade
    {
        public Amplifier Amplifier { get; set; }
        public Tuner Tuner { get; set; }
        public DvdPlayer DvdPlayer { get; set; }
        public CdPlayer CdPlayer { get; set; }
        public Projector Projector { get; set; }
        public TheaterLights TheaterLights { get; set; }
        public Screen Screen { get; set; }
        public PopcornPopper PopcornPopper { get; set; }

        public HomeTheaterFacade(Amplifier Amplifier, Tuner Tuner, CdPlayer CdPlayer,
            DvdPlayer DvdPlayer, Projector Projector, TheaterLights TheaterLights,
            Screen Screen, PopcornPopper PopcornPopper)
        {
            this.Amplifier = Amplifier;
            this.Tuner = Tuner;
            this.DvdPlayer = DvdPlayer;
            this.CdPlayer = CdPlayer;
            this.Projector = Projector;
            this.TheaterLights = TheaterLights;
            this.Screen = Screen;
            this.PopcornPopper = PopcornPopper;
        }

        public void WatchMovie(string movie)
        {
            PopcornPopper.On();
            PopcornPopper.Pop();
            TheaterLights.Dim(40);
            Screen.Down();
            Projector.On();
            Projector.WideScreenMode();
            Amplifier.On();
            Amplifier.SetDVD();
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(25);
            DvdPlayer.On();
            DvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            PopcornPopper.Off();
            TheaterLights.On();
            Screen.Up();
            Projector.Off();
            Amplifier.Off();
            DvdPlayer.Stop();
            DvdPlayer.Eject();
            DvdPlayer.Off();
        }

        public void ListenToCd(string name)
        {
            PopcornPopper.On();
            PopcornPopper.Pop();
            TheaterLights.Dim(40);
            Amplifier.On();
            Amplifier.SetCD();
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(25);
            CdPlayer.On();
            CdPlayer.Play(name);
        }

        public void EndCd()
        {
            PopcornPopper.Off();
            TheaterLights.On();
            Amplifier.Off();
            CdPlayer.Stop();
            CdPlayer.Eject();
            CdPlayer.Off();
        }

        public void ListenToRadio(int frequency)
        {
            PopcornPopper.On();
            PopcornPopper.Pop();
            TheaterLights.Dim(40);
            Amplifier.On();
            Amplifier.SetTuner();
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(25);
            Tuner.On();
            Tuner.SetFm();
            Tuner.SetFrequency(frequency);
        }

        public void EndRadio()
        {
            PopcornPopper.Off();
            TheaterLights.On();
            Amplifier.Off();
            Tuner.Off();
        }
    }
}
