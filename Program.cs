namespace Spotivy;


internal static  class Program
{
    public static Database Database { get; private set; } = new Database();
    public static Client Client { get; private set; } = (StartClient());

    public static void Main(string[] args)
    {



        Client.PlayPlaylist("My Playlist");

        Client.ViewFriends();

        var friend = Database.GetPeople().First(p => p.Name != Client.MainUser.Name);

        Client.AddFriend(friend);

        Client.ViewFriends();

        Client.ViewFriendPlaylists(friend);

        Client.ViewAlbums();

        Client.ViewArtists();

    }

    private static Client StartClient()
    {
        var userData = Database.GetPeople();
        var currentIndex = 0;
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Welcome to Spotivy!");
            Console.WriteLine("Select your user:");

            for (var i = 0; i < userData.Count; i++)
            {
                if (i == currentIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"- {userData[i].Name}");

                Console.ResetColor();
            }

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    currentIndex = (currentIndex - 1 + userData.Count) % userData.Count;
                    break;
                case ConsoleKey.DownArrow:
                    currentIndex = (currentIndex + 1) % userData.Count;
                    break;
                case ConsoleKey.Enter:
                    Console.WriteLine($"Welcome, {userData[currentIndex].Name}!");
                    break;
            }

           return new Client(userData[currentIndex]);
        }

    }

    private static void MainMenu()
    {
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Create Playlist");
        Console.WriteLine("2. Add Song to Playlist");
        Console.WriteLine("3. Play Playlist");
        Console.WriteLine("4. View Friends");
        Console.WriteLine("5. Add Friend");
        Console.WriteLine("6. Remove Friend");
        Console.WriteLine("7. View Friend Playlists");
        Console.WriteLine("8. View Albums");
        Console.WriteLine("9. View Artists");
        Console.WriteLine("0. Exit");

        var key = Console.ReadKey(true).Key;
        /*
        switch (key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                CreatePlaylist();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                AddSongToPlaylist();
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                PlayPlaylist();
                break;
            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                ViewFriends();
                break;
            case ConsoleKey.D5:
            case ConsoleKey.NumPad5:
                AddFriend();
                break;
            case ConsoleKey.D6:
            case ConsoleKey.NumPad6:
                RemoveFriend();
                break;
            case ConsoleKey.D7:
            case ConsoleKey.NumPad7:
                ViewFriendPlaylists();
                break;
            case ConsoleKey.D8:
            case ConsoleKey.NumPad8:
                ViewAlbums();
                break;
            case ConsoleKey.D9:
            case ConsoleKey.NumPad9:
                ViewArtist();
                break;
            case ConsoleKey.D0:
            case ConsoleKey.NumPad0:
                Console.WriteLine("Exiting...");
                *//*exiting*//*
                break;
            default:
                Console.WriteLine("Invalid input try again.");
                break;
        }
        */
    }
}