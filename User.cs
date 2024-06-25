using System;
using System.Collections.Generic;

namespace Spotivy
{
    public class User(string name, List<Playlist> playlists, List<User> friends)
    {
        public User(string name) : this(name, [], [])
        {
            Name = name;
        }

        public string Name { get; set; } = name;
        public List<Playlist> Playlists { get; set; } = playlists;
        public List<User> Friends { get; set; } = friends;


        public void ShowPlaylists()
        {
            Console.WriteLine("Playlists:");

            var playlistNames = Playlists.Select(p => p.Name).ToList();
            playlistNames.Insert(playlistNames.Count, "Exit");

            var selectedPlaylistName = Utility.SelectFromList(playlistNames);

            if (selectedPlaylistName == "Exit")
            {
                return;
            }

            var selectedPlaylist = Playlists.Find(p => p.Name == selectedPlaylistName);

            if (selectedPlaylist != null)
            {
                selectedPlaylist.Songs.ForEach(s =>
                    Console.WriteLine($"- {s.Title} by {string.Join(", ", s.Artists)}"));
            }
            else
            {
                Console.WriteLine($"Playlist '{selectedPlaylistName}' not found.");
            }


            Utility.PressAnyKeyToContinue();
        }


        public void AddSongToPlaylist()
        {
            Console.Clear();
            Console.WriteLine("Select a playlist:");
            var playlists = Playlists.Select(p => p.Name).ToList();
            var playlistSelectedName = Utility.SelectFromList(playlists);

            var playlist = Playlists.Find(p => p.Name == playlistSelectedName);

            if (playlist == null)
            {
                Console.WriteLine($"Playlist '{playlistSelectedName}' not found.");
                return;
            }


            while (true)
            {
                Console.WriteLine("Search for a song:");
                Console.WriteLine("To leave type 'exit'.");
                var searchQuery = Console.ReadLine();

                if (searchQuery == "exit")
                {
                    break;
                }

                if (searchQuery == "")
                {
                    Console.WriteLine("Please enter a search query.");
                    continue;
                }

                var searchResult = Database.GetSongs()
                    .FindAll(s => s.Title.Contains(searchQuery) || s.Artists.Contains(searchQuery));


                if (searchResult.Count != 0)
                {
                    var selectedSongsNames = Utility.SelectMultipleFromList(searchResult.Select(s => s.Title).ToList());
                    var selectedSongs = searchResult.Where(s => selectedSongsNames.Contains(s.Title)).ToList();
                    Console.WriteLine(selectedSongs);

                    foreach (var song in selectedSongs)
                    {
                        playlist.Songs.Add(song);
                        Console.WriteLine($"Song '{song.Title}' added to playlist '{playlist.Name}'.");
                    }
                }
                else
                {
                    Console.WriteLine($"Song '{searchQuery}' not found.");
                }
            }

            Utility.PressAnyKeyToContinue();
        }

        public void CreatePlaylist()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Enter the name of the new playlist:");
                var name = Console.ReadLine();
                if (Playlists.Any(p => p.Name == name) || name == "")
                {
                    Console.WriteLine($"Playlist '{name}' already exists or name is not valid.");
                    continue;
                }

                if (name != null)
                {
                    Playlists.Add(new Playlist(name, []));
                    Console.WriteLine($"Playlist '{name}' created.");
                }

                break;
            }

            Utility.PressAnyKeyToContinue();
        }

        public void RemovePlaylist()
        {
            Console.Clear();
            Console.WriteLine("Select a playlist to remove:");
            var playlistNames = Playlists.Select(p => p.Name).ToList();
            var playlistName = Utility.SelectFromList(playlistNames);
            var playlist = Playlists.Find(p => p.Name == playlistName);

            if (playlist != null)
            {
                Playlists.Remove(playlist);
                Console.WriteLine($"Playlist '{playlistName}' removed.");
            }
            else
            {
                Console.WriteLine($"Playlist '{playlistName}' not found.");
            }

            Utility.PressAnyKeyToContinue();
        }

        public void ViewFriends()
        {
            Console.WriteLine("Friends:");
            foreach (var friend in Friends)
            {
                Console.WriteLine($"- {friend.Name}");
            }

            Utility.PressAnyKeyToContinue();
        }

        public void AddFriend()
        {
            Console.Clear();
            Console.WriteLine("Select a friend to add");
            var friends = Database.GetPeople().Select(u => u.Name).ToList().Except(Friends.Select(f => f.Name))
                .ToList();
            var friendName = Utility.SelectFromList(friends);
            var friend = Database.GetPeople().Find(u => u.Name == friendName);


            if (friend != null)
            {
                Friends.Add(friend);
                Console.WriteLine($"Friend '{friendName}' added.");
            }
            else
            {
                Console.WriteLine($"User '{friendName}' not found.");
            }

            Utility.PressAnyKeyToContinue();
        }

        public void RemoveFriend()
        {
            Console.Clear();
            Console.WriteLine("Select a friend to remove:");
            var friends = Friends.Select(f => f.Name).ToList();
            var friendName = Utility.SelectFromList(friends);
            var friend = Friends.Find(f => f.Name == friendName);

            if (friend != null)
            {
                Friends.Remove(friend);
                Console.WriteLine($"Friend '{friendName}' removed.");
            }
            else
            {
                Console.WriteLine($"Friend '{friendName}' not found.");
            }

            Utility.PressAnyKeyToContinue();
        }

        public void ViewFriendPlaylists()
        {
            Console.Clear();
            Console.WriteLine("Select a friend:");
            var friends = Friends.Select(f => f.Name).ToList();
            var friendName = Utility.SelectFromList(friends);
            var friend = Friends.Find(f => f.Name == friendName);


            if (friend != null && friend.Playlists.Count != 0)
            {
                Console.WriteLine($"{friend.Name}'s Playlists:");
                var selectedPlaylistName = Utility.SelectFromList(friend.Playlists.Select(p => p.Name).ToList());
                var selectedPlaylist = friend.Playlists.Find(p => p.Name == selectedPlaylistName);

                if (selectedPlaylist != null)
                {
                    selectedPlaylist.Songs.ForEach(s =>
                        Console.WriteLine($"- {s.Title} by {string.Join(", ", s.Artists)}"));
                }
                else
                {
                    Console.WriteLine($"Playlist '{selectedPlaylistName}' not found.");
                }
            }
            else
            {
                Console.WriteLine($"{friend?.Name} has no playlists.");
            }

            Utility.PressAnyKeyToContinue();
        }
    }
}