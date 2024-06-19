namespace Spotivy;

public class Playlist(string name, List<Song> songs)
{
    public string Name { get; set; } = name;
    public List<Song> Songs { get; set; } = songs;
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