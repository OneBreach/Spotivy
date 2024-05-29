namespace Spotivy;

public class Client(User mainUser )
{
    public User MainUser { get; private set; } = mainUser;
    public List<Song> Queues { get; set; } = [];

}