using System;

// Target Interface
interface IMusicPlayer
{
    void PlayMusic(string musicType, string fileName);
}

// Adaptee (Old CD Player)
class OldMusicPlayer
{
    public void PlayCD(string cdTitle)
    {
        Console.WriteLine("Playing CD: " + cdTitle);
    }
}

// Adapter
class CDPlayerAdapter : IMusicPlayer
{
    private OldMusicPlayer cdPlayer;

    public CDPlayerAdapter(OldMusicPlayer player)
    {
        cdPlayer = player;
    }

    public void PlayMusic(string musicType, string fileName)
    {
        if (musicType == "CD")
        {
            cdPlayer.PlayCD(fileName);
        }
        else
        {
            Console.WriteLine("Unsupported music type: " + musicType);
        }
    }
}

class Program
{
    static void Main()
    {
        IMusicPlayer player = new CDPlayerAdapter(new OldMusicPlayer());
        player.PlayMusic("CD", "Classic Hits");
        player.PlayMusic("MP3", "Rock Anthems"); // Adapter handles MP3 format gracefully
    }
}
