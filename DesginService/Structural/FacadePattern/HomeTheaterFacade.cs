using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignService.Structural.FacadePattern
{
    class Projector
    {
        public void On() { Console.WriteLine("Projector is ON"); }
        public void Off() => Console.WriteLine("Projector is OFF");
    }

    class Amplifier
    {
        public void On() => Console.WriteLine("Amplifier is ON");
        public void Off() => Console.WriteLine("Amplifier is OFF");
    }

    class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player is ON");
        public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
        public void Off() => Console.WriteLine("DVD Player is OFF");
    }

    class Speakers
    {
        public void On() => Console.WriteLine("Speakers are ON");
        public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
        public void Off() => Console.WriteLine("Speakers are OFF");
    }

    class HomeTheaterFacade
    {
        private readonly Projector _projector;
        private readonly Amplifier _amplifier;
        private readonly DVDPlayer _dvdPlayer;
        private readonly Speakers _speakers;

        public HomeTheaterFacade(Projector projector, Amplifier amplifier, DVDPlayer dvdPlayer, Speakers speakers)
        {
            _projector = projector;
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _speakers = speakers;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("\nStarting the home theater...");
            _projector.On();
            _amplifier.On();
            _speakers.On();
            _speakers.SetVolume(10);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
            Console.WriteLine("Enjoy your movie!\n");
        }

        public void EndMovie()
        {
            Console.WriteLine("\nShutting down the home theater...");
            _dvdPlayer.Off();
            _speakers.Off();
            _amplifier.Off();
            _projector.Off();
            Console.WriteLine("Goodbye!\n");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create subsystem components
            Projector projector = new Projector();
            Amplifier amplifier = new Amplifier();
            DVDPlayer dvdPlayer = new DVDPlayer();
            Speakers speakers = new Speakers();

            // Create the facade
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(projector, amplifier, dvdPlayer, speakers);

            // Use the facade to simplify operations
            homeTheater.WatchMovie("Inception");
            homeTheater.EndMovie();
        }
    }


}
