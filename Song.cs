namespace Spotivy;

public class Song(string title, string[] artists, string genre, int duration)
{
    public string Title { get; set; } = title;
    public string[] Artists { get; set; } = artists;
    public string Genre { get; set; } = genre;
    public int Duration { get; set; } = duration;
    
    public Song(string title, string[] artists, string genre)
    {
        Title = title;
        Artists = artists;
        Genre = genre;
    }

    public void Play()
    {
        Console.WriteLine($"Playing song '{Title}' by {string.Join(", ", Artists)}.");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping song '{Title}'.");
    }

    public void Skip()
    {
        Console.WriteLine($"Skipping song '{Title}'.");
    }


    /*    public Song GetSong()
        {
            return this;
        }*/

}