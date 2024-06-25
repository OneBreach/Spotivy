using System.Diagnostics;
namespace Spotivy
{
    public class Client(User mainUser)
    {
        public User MainUser { get; set; } = mainUser;

        private List<Song> Queue { get; set; } = [];


        // Show the Queue List
        public void ShowQueue()
        {
            if (Queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                Utility.PressAnyKeyToContinue();
                return;
            }

            Console.WriteLine("Queue:");
            for (var i = 0; i < Queue.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Queue[i].Title} by {string.Join(", ", Queue[i].Artists)}");
            }

            Utility.PressAnyKeyToContinue();
        }

        public void SkipSong()
        {
            if (Queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                Utility.PressAnyKeyToContinue();
                return;
            }

            var songToSkip = Queue[0];
            Console.WriteLine($"Skipping '{songToSkip.Title}' by {string.Join(", ", songToSkip.Artists)}.");
            Queue.RemoveAt(0);
            Utility.PressAnyKeyToContinue();
        }

        // Add a song to the Queue
        public void AddSongToQueue()
        {
            Console.WriteLine("Select a song to add to the queue:");
            var song = Utility.SelectFromList(MainUser.Playlists.SelectMany(p => p.Songs)
                .Select(s => s.Title).ToList());
            var songToAdd = MainUser.Playlists.SelectMany(p => p.Songs).ToList().Find(s => s.Title == song);

            if (songToAdd == null)
            {
                Console.WriteLine($"Song '{song}' not found.");
                Utility.PressAnyKeyToContinue();

                return;
            }

            Console.WriteLine($"Adding '{songToAdd.Title}' to the queue.");
            Queue.Add(songToAdd);
            Utility.PressAnyKeyToContinue();
        }

        // Remove songs from the Queue
        public void RemoveFromQueue()
        {
            var songToRemove = Utility.SelectMultipleFromList(Queue.Select(s => s.Title).ToList());
            var songToRemoveFromQueue = Queue.Find(s => songToRemove.Contains(s.Title));


            if (songToRemoveFromQueue == null)
            {
                Console.WriteLine($"Song '{songToRemove}' not found.");
                Utility.PressAnyKeyToContinue();
                return;
            }

            Console.WriteLine($"Removing '{songToRemoveFromQueue.Title}' from the queue.");
            Queue.Remove(songToRemoveFromQueue);
            Utility.PressAnyKeyToContinue();
        }

        // Play the Queue
        public void PlayQueue()
        {
            Console.WriteLine("Playing queue:");
            if (Queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                Utility.PressAnyKeyToContinue();
                return;
            }

            foreach (var song in Queue)
            {
                Console.WriteLine($"- {song.Title} by {string.Join(", ", song.Artists)}");
            }

            Utility.PressAnyKeyToContinue();

        }

        public void AddPlaylistToQueue()
        {
            Console.WriteLine("Select a playlist to add to the queue:");
            var playlist = Utility.SelectFromList(MainUser.Playlists.Select(p => p.Name).ToList());
            var playlistToAdd = MainUser.Playlists.Find(p => p.Name == playlist);

            if (playlistToAdd == null)
            {
                Console.WriteLine($"Playlist '{playlist}' not found.");
                Utility.PressAnyKeyToContinue();
                return;
            }


            Console.WriteLine("Playlist added to the queue.");
            Console.WriteLine($"Playing playlist '{playlistToAdd.Name}':");
            foreach (var song in playlistToAdd.Songs)
            {
                Console.WriteLine($"- {song.Title} by {string.Join(", ", song.Artists)}");
                Queue.Add(song);
            }

            Utility.PressAnyKeyToContinue();
        }


    }
}