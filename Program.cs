namespace Spotivy;

internal static class Program
{
    public static Database Database { get; private set; } = new Database();
    public static Client Client { get; private set; } = null!;

    public static void Main(string[] args)
    {
        Client = StartClient();
        while (true)
        {
            MainMenu();
        }
    }


    private static Client StartClient()
    {
        Console.WriteLine("Welcome to Spotivy!");
        Console.WriteLine("Select your user:");
        Utility.PressAnyKeyToContinue();
        var userData = Database.GetPeople();
        var userNames = userData.Select(u => u.Name).ToList();
        var selectedUserName = Utility.SelectFromList(userNames);
        var selectedUser = userData.Find(u => u.Name == selectedUserName);


        if (selectedUser != null)
        {
            Console.WriteLine($"Welcome, {selectedUserName}!");
            Utility.PressAnyKeyToContinue();
            return new Client(selectedUser);
        }

        Console.WriteLine("User not found.");
        Environment.Exit(1);

        return new Client(selectedUser);
    }

    private static void MainMenu()
    {


        var selectedMenu = Utility.SelectFromList(["Playlist Menu", "Friend Menu", "Queue Menu", "Exit"]);

        Console.Clear();
        switch (selectedMenu)
        {
            case "Playlist Menu":
                PlaylistMenu();
                break;
            case "Friend Menu":
                FriendMenu();
                break;
            case "Queue Menu":
                QueueMenu();
                break;
            case "Exit":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input try again.");
                break;
        }
    }

    private static void PlaylistMenu()
    {

        var selectedOption = Utility.SelectFromList([
            "Create Playlist", "Add Song to Playlist", "Show Playlists","Remove Playlist", "Back to Main Menu"
        ]);

        Console.Clear();
        switch (selectedOption)
        {
            case "Create Playlist":
                Client.MainUser.CreatePlaylist();
                break;

            case "Add Song to Playlist":
                Client.MainUser.AddSongToPlaylist();
                break;

            case "Show Playlists":
                Client.MainUser.ShowPlaylists();
                break;

            case "Remove Playlist":
                Client.MainUser.RemovePlaylist();
                break;

            case "Back to Main Menu":
                MainMenu();
                break;

            default:
                Console.WriteLine("Invalid input try again.");
                break;
        }
    }

    private static void FriendMenu()
    {

        var selectedOption = Utility.SelectFromList([
            "View Friends", "Add Friend", "Remove Friend", "View Friend Playlists", "Back to Main Menu"
        ]);

        Console.Clear();
        switch (selectedOption)
        {
            case "View Friends":
                Client.MainUser.ViewFriends();
                break;

            case "Add Friend":
                Client.MainUser.AddFriend();
                break;

            case "Remove Friend":
                Client.MainUser.RemoveFriend();
                break;

            case "View Friend Playlists":
                Client.MainUser.ViewFriendPlaylists();
                break;

            case "Back to Main Menu":
                MainMenu();
                break;

            default:
                Console.WriteLine("Invalid input try again.");
                break;
        }
    }
    private static void QueueMenu()
    {

        var selectedOption = Utility.SelectFromList(["Show Queue","Skip song",
            "Add Song to Queue", "Remove Song from Queue", "Play Queue", "Add Playlist to Queue","Back to Main Menu"
        ]);

        Console.Clear();
        switch (selectedOption)
        {
            case "Show Queue":
                Client.ShowQueue();
                break;

            case "Skip song":
                Client.SkipSong();
                break;

            case "Add Song to Queue":
                Client.AddSongToQueue();
                break;

            case "Remove Song from Queue":
                Client.RemoveFromQueue();
                break;

            case "Play Queue":
                Client.PlayQueue();
                break;

            case "Add Playlist to Queue":
                Client.AddPlaylistToQueue();
                break;

            case "Back to Main Menu":
                MainMenu();
                break;

            default:
                Console.WriteLine("Invalid input try again.");
                break;
        }
    }









}