namespace Spotivy;

public  class Database
{
    public static List<User> GetPeople()
    {
        return
        [
            new User(name: "John",
                playlists:
                [
                    new Playlist(name: "John's Playlist",
                        songs:
                        [
                            new Song(title: "The Less I Know The Better",
                                artists: ["Tame Impala"],
                                genre: "Psychedelic Rock",
                                duration: 134),

                            new Song(title: "The Less I Know The Better",
                                artists: ["Tame Impala"],
                                genre: "Psychedelic Rock",
                                duration: 150)
                        ])
                ],
                friends:
                [
                    new User(name: "Jane"),
                    new User(name: "Jake"),
                    new User(name: "Jill")
                ]),


            new User(name: "Jane",
                playlists:
                [
                    new Playlist(name: "Jane's Playlist",
                        songs:
                        [
                            new Song(title: "The Less I Know The Better",
                                artists: ["Tame Impala"],
                                genre: "Psychedelic Rock",
                                duration: 242),

                            new Song(title: "Blinding Lights",
                                artists: ["The Weeknd"],
                                genre: "Synthwave",
                                duration: 424),

                            new Song(title: "Watermelon Sugar",
                                artists: ["Harry Styles"],
                                genre: "Pop Rock",
                                duration: 111)
                        ])
                ],
                friends: new List<User>
                {
                    Capacity = 0
                }),


            new User(name: "Jake",
                playlists:
                [
                    new Playlist(name: "Jake's Playlist",
                        songs:
                        [
                            new Song(title: "Space Oddity",
                                artists: ["David Bowie"],
                                genre: "Rock",
                                duration: 318),

                            new Song(title: "Electric Feel",
                                artists: ["MGMT"],
                                genre: "Indie Rock",
                                duration: 229),

                            new Song(title: "Summertime Sadness",
                                artists: ["Lana Del Rey"],
                                genre: "Indie Pop",
                                duration: 265)
                        ])
                ],
                friends: [new User(name: "Jane")]
            ),


            new User(name: "Jill",
                playlists:
                [
                    new Playlist(name: "Jill's Playlist",
                        songs:
                        [
                            new Song(title: "Dreams",
                                artists: ["Fleetwood Mac"],
                                genre: "Soft Rock",
                                duration: 257),

                            new Song(title: "Bad Guy",
                                artists: ["Billie Eilish"],
                                genre: "Electropop",
                                duration: 194),

                            new Song(title: "Take On Me",
                                artists: ["a-ha"],
                                genre: "Synthpop",
                                duration: 225)
                        ])
                ],
                friends: new List<User> { new User(name: "Jane") }
            )
        ];
    }

    public static List<Song> GetSongs()
    {
        return new List<Song>
        {
            new Song(title: "The Less I Know The Better",
                artists: [ "Tame Impala" ],
                genre: "Psychedelic Rock",
                duration: 134),

            new Song(title: "Blinding Lights",
                artists:[ "The Weeknd" ],
                genre: "Synthwave",
                duration: 424),

            new Song(title: "Watermelon Sugar",
                artists:[ "Harry Styles"],
                genre: "Pop Rock",
                duration: 111),

            new Song(title: "Space Oddity",
                artists:[ "David Bowie" ],
                genre: "Rock",
                duration: 318),

            new Song(title: "Electric Feel",
                artists:[ "MGMT" ],
                genre: "Indie Rock",
                duration: 229),

            new Song(title: "Summertime Sadness",
                artists:[ "Lana Del Rey"],
                genre: "Indie Pop",
                duration: 265),

            new Song(title: "Dreams",
                artists:[ "Fleetwood Mac" ],
                genre: "Soft Rock",
                duration: 257),

            new Song(title: "Bad Guy",
                artists:[ "Billie Eilish"],
                genre: "Electropop",
                duration: 194),

            new Song(title: "Take On Me",
                artists:[ "a-ha" ],
                genre: "Synthpop",
                duration: 225)
        };
    }
    public static List<Album> GetAlbums()
    {
        return
        [
            new Album(title: "The Dark Side of the Moon",
                songs:
                [
                    new Song(title: "Speak to Me",
                        duration: 343,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Breathe",
                        duration: 433,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "On the Run",
                        duration: 422,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Time",
                        duration: 234,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "The Great Gig in the Sky",
                        duration: 134,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Money",
                        duration: 422,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Us and Them",
                        duration: 212,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Any Colour You Like",
                        duration: 213,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Brain Damage",
                        duration: 312,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Eclipse",
                        duration: 231,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock")
                ]),

            new Album(title: "The Dark Side of the Moon",
                songs:
                [
                    new Song(title: "In the Flesh?",
                        duration: 422,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "The Thin Ice",
                        duration: 123,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Another Brick in the Wall, Part 1",
                        duration: 426,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "The Happiest Days of Our Lives",
                        duration: 123,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Another Brick in the Wall, Part 2",
                        duration: 231,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock"),

                    new Song(title: "Mother",
                        duration: 421,
                        artists: ["Pink Floyd"],
                        genre: "Progressive Rock")
                ]
            )
        ];
    }
}