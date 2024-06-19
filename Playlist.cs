namespace Spotivy;

public class Playlist(string name, List<Song> songs)
{
    public string Name { get; set; } = name;
    private List<Song> Songs { get; set; } = songs;

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public void RemoveSong(Song song)
    {
        Songs.Remove(song);
    }


}