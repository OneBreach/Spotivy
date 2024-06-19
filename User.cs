using System;
using System.Collections.Generic;

namespace Spotivy
{
    public class User(string name)
    {
        public string Name { get; set; } = name;
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
        public List<User> Friends { get; set; } = new List<User>();

        public void CreatePlaylist(string name)
        {
            Playlists.Add(new Playlist(name));
        }

        public void AddSongToPlaylist(string playlistName, Song song)
        {
            var playlist = Playlists.Find(p => p.Name == playlistName);
            if (playlist != null)
            {
                playlist.AddSong(song);
            }
            else
            {
                Console.WriteLine($"Playlist '{playlistName}' not found.");
            }
        }

        public void PlayPlaylist(string playlistName)
        {
            var playlist = Playlists.Find(p => p.Name == playlistName);
            if (playlist != null)
            {
                playlist.Play();
            }
            else
            {
                Console.WriteLine($"Playlist '{playlistName}' not found.");
            }
        }

        public void ViewFriends()
        {
            Console.WriteLine("Friends:");
            foreach (var friend in Friends)
            {
                Console.WriteLine($"- {friend.Name}");
            }
        }

        public void AddFriend(User friend)
        {
            if (!Friends.Contains(friend))
            {
                Friends.Add(friend);
            }
            else
            {
                Console.WriteLine($"{friend.Name} is already a friend.");
            }
        }

        public void RemoveFriend(User friend)
        {
            if (!Friends.Remove(friend))
            {
                Console.WriteLine($"{friend.Name} is not a friend.");
            }
        }

        public void ViewFriendPlaylists(User friend)
        {
            if (Friends.Contains(friend))
            {
                Console.WriteLine($"{friend.Name}'s Playlists:");
                foreach (var playlist in friend.Playlists)
                {
                    Console.WriteLine($"- {playlist.Name}");
                }
            }
            else
            {
                Console.WriteLine($"{friend.Name} is not a friend.");
            }
        }
    }
}