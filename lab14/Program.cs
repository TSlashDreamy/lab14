using lab14;

// variant 8
var tracks = new List<MusicTrack>
{
    /////////////////
    // Two creation options
    /////////////////
    // new MusicTrack { Title = "Title", Artist = "Artist", Album = "Album", Genre = "Genre", Duration = 0 } - more descriptive
    // or
    // new MusicTrack("Title", "Artist", "Album", "Genre", 0) - shorter
    ////////////////

    new MusicTrack { Title = "Bohemian Rhapsody", Artist = "Queen", Album = "A Night at the Opera", Genre = "Rock", Duration = 367 },
    new MusicTrack { Title = "Stairway to Heaven", Artist = "Led Zeppelin", Album = "Led Zeppelin IV", Genre = "Rock", Duration = 482 },
    new MusicTrack { Title = "Purple Haze", Artist = "Jimi Hendrix", Album = "Are You Experienced", Genre = "Rock", Duration = 174 },
    new MusicTrack { Title = "Billie Jean", Artist = "Michael Jackson", Album = "Thriller", Genre = "Pop", Duration = 295 },
    new MusicTrack { Title = "Smooth Criminal", Artist = "Michael Jackson", Album = "Bad", Genre = "Pop", Duration = 258 },
    new MusicTrack { Title = "Take Five", Artist = "Dave Brubeck", Album = "Time Out", Genre = "Jazz", Duration = 325 },
    new MusicTrack { Title = "So What", Artist = "Miles Davis", Album = "Kind of Blue", Genre = "Jazz", Duration = 562 },
    new MusicTrack { Title = "Piano Concerto No. 21", Artist = "Mozart", Album = "Mozart: Piano Concertos Nos. 20 & 21", Genre = "Classical", Duration = 469 },
    new MusicTrack { Title = "Moonlight Sonata", Artist = "Beethoven", Album = "Beethoven: The Complete Piano Sonatas", Genre = "Classical", Duration = 357 },
    new MusicTrack { Title = "Eine Kleine Nachtmusik", Artist = "Mozart", Album = "Mozart: Eine Kleine Nachtmusik", Genre = "Classical", Duration = 353 }
};

void showList(List<MusicTrack> musicList)
    => musicList.ForEach(t => Console.WriteLine(t));

// sorting by genre and duration
List<MusicTrack> sortedTracks = tracks
    .OrderBy(t => t.Genre)
    .ThenBy(t => t.Duration)
    .ToList();

// showing sorted list
Console.WriteLine("Sorted tracks:");
showList(sortedTracks);
Console.WriteLine();

// displaying a list of compositions of a certain artist
string artist = "Michael Jackson";
List<MusicTrack> artistTracks = tracks.FindAll(t => t.Artist == artist);

Console.WriteLine($"Tracks by {artist}:");
showList(artistTracks);
