namespace Spotivy;

public class Client(User mainUser )
{
    public User MainUser { get; private set; } = mainUser;
    public List<Song> Queues { get; set; } = [];



    public void AddSongToQueue(Song song)
    {
        Queues.Add(song);
    }

    public void RemoveSongFromQueue(Song song)
    {
        Queues.Remove(song);
    }

    public void PlaySong(Song song)
    {
        Console.WriteLine($"Playing {song.Title}");
    }

    public void PlayNextSong()
    {
        if (Queues.Count > 0)
        {
            PlaySong(Queues[0]);
            Queues.RemoveAt(0);
        }
    }


    public void AddSongToPlaylist(Song song, Playlist playlist)
    {
        playlist.AddSong(song);
    }

    public void RemoveSongFromPlaylist(Song song, Playlist playlist)
    {
        playlist.RemoveSong(song);
    }



    public void AddFriend(User friend)
    {
        MainUser.AddFriend(friend);
    }


    public void RemoveFriend(User friend)
    {
        MainUser.RemoveFriend(friend);
    }
}