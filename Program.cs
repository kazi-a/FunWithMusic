namespace FunWithMusic
{
    //Define music genre enum
    public enum MusicGenre
    {
        Rock,
        Pop,
        HipHop,
        Jazz,
        Electronic
    }

    // Define Music structure
    public struct Music
    {
        public string Title;
        public string Artist;
        public string Album;
        public int Length; 
        public MusicGenre Genre;

        // Parameterized Constructor
        public Music(string title, string artist, string album, int length, MusicGenre genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Length = length;
            Genre = genre;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Length: {Length} seconds");
            Console.WriteLine($"Genre: {Genre}");
        }

        // Set method for Title
        public void SetTitle(string newTitle)
        {
            Title = newTitle;
        }

        // Set method for Length
        public void SetLength(int newLength)
        {
            Length = newLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for music information
            Console.WriteLine("Enter music information for song 1:");
            Console.Write("Title: ");
            string title1 = Console.ReadLine();
            Console.Write("Artist: ");
            string artist1 = Console.ReadLine();
            Console.Write("Album: ");
            string album1 = Console.ReadLine();
            Console.Write("Length (seconds): ");
            int length1 = Convert.ToInt32(Console.ReadLine());

            // Get music genre from user 
            Console.WriteLine("Enter music genre for song 1:");
            foreach (MusicGenre genre in Enum.GetValues(typeof(MusicGenre)))
            {
                Console.WriteLine($"{(int)genre}. {genre}");
            }
            Console.Write("Choose genre (enter number): ");
            int genreIndex1 = Convert.ToInt32(Console.ReadLine());
            MusicGenre selectedGenre1 = (MusicGenre)genreIndex1;

            // Music structure instance 
            Music song1 = new Music(title1, artist1, album1, length1, selectedGenre1);

            // Display music information 
            Console.WriteLine("\nFirst Song Information:");
            song1.Display();

            // Exercise #2
            // Create a new structure variable for song 2
            Music moreMusic = song1;

            // Use set methods to change information for song 2
            moreMusic.SetTitle("New Song Title");
            moreMusic.SetLength(300); 

            // Print out both songs
            Console.WriteLine("\nSecond Song Information:");
            moreMusic.Display();

            Console.ReadLine(); 
        }
    }
}

