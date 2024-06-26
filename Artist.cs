namespace Spotivy;

public abstract class Artist(string name)
{
    private string Name { get; set; } = name;
    private List<Album> Albums { get; set; } = [];
    private List<Song> Songs { get; set; } = [];



}