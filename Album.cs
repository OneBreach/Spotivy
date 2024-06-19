namespace Spotivy;

public class Album(string title, List<Song> songs)
{
    public string Title { get; set; } = title;
    public List<Song> Songs { get; set; } = songs;


}