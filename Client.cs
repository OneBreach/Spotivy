using System;
using System.Collections.Generic;

namespace Spotivy
{
    public class Client(User mainUser)
    {
        public User MainUser { get; private set; } = mainUser;

        public void CreatePlaylist(string name)
        {
            MainUser.CreatePlaylist(name);
        }

        public void AddSongToPlaylist(string playlistName, Song song)
        {
            MainUser.AddSongToPlaylist(playlistName, song);
        }

        public void PlayPlaylist(string playlistName)
        {
            MainUser.PlayPlaylist(playlistName);
        }

        public void ViewFriends()
        {
            MainUser.ViewFriends();
        }

        public void AddFriend(User friend)
        {
            MainUser.AddFriend(friend);
        }

        public void RemoveFriend(User friend)
        {
            MainUser.RemoveFriend(friend);
        }

        public void ViewFriendPlaylists(User friend)
        {
            MainUser.ViewFriendPlaylists(friend);
        }

        public void ViewAlbums()
        {
            var albums = GetAlbums();
            Console.WriteLine("Albums:");
            foreach (var album in albums)
            {
                Console.WriteLine($"- {album.Title}");
            }
        }

        public void ViewArtists()
        {
            var artists = GetArtists();
            Console.WriteLine("Artists:");
            foreach (var artist in artists)
            {
                Console.WriteLine($"- {artist.Name}");
            }
        }

        private List<Album> GetAlbums()
        {
            return
            [
                new Album("Album1", [], []),
                new Album("Album2", [], [])
            ];
        }

        private List<Artist> GetArtists()
        {
            return
            [
                new Artist("Killer Kamal"),
                new Artist("Pietje Bel")
            ];
        }
    }
}