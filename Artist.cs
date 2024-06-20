namespace Spotivy;

public class Artist(string name)
{
    public string Name { get; set; } = name;
    public List<Album> Albums { get; set; } = [];
    public List<Song> Songs { get; set; } = [];

    public Artist(string name, List<Album> albums, List<Song> songs)
    {
        Name = name;
        Albums = albums;
        Songs = songs;
    }

    public void ViewWorks()
    {
        Console.WriteLine($"Artist: {Name}");
        Console.WriteLine("Albums:");
        foreach (var album in Albums)
        {
            Console.WriteLine($"- {album.Title}");
        }
        Console.WriteLine("Songs:");
        foreach (var song in Songs)
        {
            Console.WriteLine($"- {song.Title}");
        }
    }
}