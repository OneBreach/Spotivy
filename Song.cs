namespace Spotivy;

public class Song(string title, string[] artists, string genre, int duration)
{
    public string Title { get; set; } = title;
    public string[] Artists { get; set; } = artists;
    public string Genre { get; set; } = genre;
    public int Duration { get; set; } = duration;



    public Song GetSong()
    {
        return this;
    }

}