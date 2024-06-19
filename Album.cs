namespace Spotivy;

public class Album(string title, List<Song> songs, List<Artist> artists)
{
    public string Title { get; set; } = title;
    public List<Song> Songs { get; set; } = songs;
    public List<Artist> Artists { get; set; } = artists;

}