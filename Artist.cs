namespace Spotivy;

public class Artist(string name)
{
    public string Name { get; set; } = name;
    public List<Album> Albums { get; set; } = [];
    public List<Song> Songs { get; set; } = [];

}