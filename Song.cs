namespace Spotivy;

public class Song(string title, string[] artists, string genre)
{
    public string Title { get; set; } = title;
    public string[] Artists { get; set; } = artists;
    public string Genre { get; set; } = genre;

}