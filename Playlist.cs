namespace Spotivy;

public class Playlist(string name)
{
    public string Name { get; set; } = name;
    private List<Song> Songs { get; set; } = [];

}