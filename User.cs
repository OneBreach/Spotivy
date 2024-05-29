namespace Spotivy;

public class User(string name)
{
    public string Name { get; set; } = name;
    private List<Playlist> Playlists { get; set; } = [];
    private List<User> Friends { get; set; } = [];

}