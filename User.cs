namespace Spotivy;

public class User(string name, List<Playlist> playlists, List<User> friends)
{
    public string Name { get; set; } = name;
    private List<Playlist> Playlists { get; set; } = playlists;
    private List<User> Friends { get; set; } = friends;

}