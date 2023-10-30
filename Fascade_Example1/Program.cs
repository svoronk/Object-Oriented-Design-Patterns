using System;

// Subsystem: DVD Player
class DVDPlayer
{
    public void Play()
    {
        Console.WriteLine("DVD Player is playing.");
    }
}

// Subsystem: Projector
class Projector
{
    public void TurnOn()
    {
        Console.WriteLine("Projector is on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Projector is off.");
    }
}

// Subsystem: Sound System
class SoundSystem
{
    public void Start()
    {
        Console.WriteLine("Sound System is started.");
    }

    public void Stop()
    {
        Console.WriteLine("Sound System is stopped.");
    }
}

// Facade
class MultimediaFacade
{
    private DVDPlayer dvdPlayer;
    private Projector projector;
    private SoundSystem soundSystem;

    public MultimediaFacade()
    {
        dvdPlayer = new DVDPlayer();
        projector = new Projector();
        soundSystem = new SoundSystem();
    }

    public void WatchMovie()
    {
        Console.WriteLine("Get ready to watch a movie!");
        projector.TurnOn();
        soundSystem.Start();
        dvdPlayer.Play();
    }

    public void EndMovie()
    {
        Console.WriteLine("Movie is over.");
        dvdPlayer.Play(); // Stop DVD
        soundSystem.Stop();
        projector.TurnOff();
    }
}

class Program
{
    static void Main()
    {
        MultimediaFacade multimediaSystem = new MultimediaFacade();

        // Start a movie
        multimediaSystem.WatchMovie();

        Console.WriteLine("\nEnjoying the movie...\n");

        // End the movie
        multimediaSystem.EndMovie();
    }
}
