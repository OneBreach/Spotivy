namespace Spotivy;

public class Album(string title, List<Song> songs, List<Artist> artists)
{
    public Album(string title, List<Song> songs)
    {
        Title = title;
        Songs = songs;
    }
    public string Title { get; set; } = title;
    public List<Song> Songs { get; set; } = songs;
    public List<Artist> Artists { get; set; } = artists;

}