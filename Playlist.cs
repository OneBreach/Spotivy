namespace Spotivy;

public class Playlist(string name, List<Song> songs)
{
    public string Name { get; set; } = name;
    public List<Song> Songs { get; set; } = songs;


}