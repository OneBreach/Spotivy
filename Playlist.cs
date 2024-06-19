namespace Spotivy;

public class Playlist(string name)
{
    public string Name { get; set; } = name;
    private List<Song> Songs { get; set; } = [];

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public void RemoveSong(Song song)
    {
        Songs.Remove(song);
    }

    public void Play()
    {
        Console.WriteLine($"Playing playlist '{Name}':");
        foreach (var song in Songs)
        {
            Console.WriteLine($"- {song.Title}");
        }
    }



}