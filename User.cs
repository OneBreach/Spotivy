namespace Spotivy;
public class User(string name, List<Playlist> playlists, List<User> friends)
{
    public string Name { get; set; } = name;
    private List<Playlist> Playlists { get; set; } = playlists;
    private List<User> Friends { get; set; } = friends;

    public void AddFriend(User friend)
    {
        Friends.Add(friend);
    }

    public void RemoveFriend(User friend)
    {
        Friends.Remove(friend);
    }

    public void AddPlaylist(Playlist playlist)
    {
        Playlists.Add(playlist);
    }

    public void RemovePlaylist(Playlist playlist)
    {
        Playlists.Remove(playlist);
    }

    public void AddSongToPlaylist(Song song, Playlist playlist)
    {
        playlist.AddSong(song);
    }

    public void RemoveSongFromPlaylist(Song song, Playlist playlist)
    {
        playlist.RemoveSong(song);
    }


}