namespace Spotivy;

public class Album(string title, List<Song> songs)
{
    public string Title { get; set; } = title;
    public List<Song> Songs { get; set; } = songs;
    public List<Artist> Artists { get; set; }
    
    public Album(string title, List<Song> songs, List<Artist> artists)
    {
        Title = title;
        Songs = songs;
        Artists = artists;
    }

    public void Play()
    {
        Console.WriteLine($"Playing album '{Title}':");
        foreach (var song in Songs)
        {
            song.Play();
        }
    }
}