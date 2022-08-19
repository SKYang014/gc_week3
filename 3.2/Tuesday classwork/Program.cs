////TRIANGLE DEMO 1
//Triangle first = new Triangle(4, 3);
//double area = first.GetArea();
//Console.WriteLine(area);
//Console.WriteLine(first.GetHypotenuse());
//Console.WriteLine(first.GetPerimeter());

//class Triangle
//{

//	// We have a package, like a capsule
//	// The verb we use is "encapsulate"
//	// We've packaged together Length and Height
//	// into a triangle concept.
//	// We have "encapsulated" Length and Height
//	// into a triangle.

//	public double Length;
//	public double Height;

//	// Initializing the data
//	// Create a constructor
//	public Triangle(double _length, double _height)
//	{
//		Length = _length;
//		Height = _height;
//	}

//	public double GetArea()
//	{
//		return Length * Height / 2;
//	}

//	public double GetHypotenuse()
//	{
//		return Math.Sqrt(Length * Length + Height * Height);
//	}

//	public double GetPerimeter()
//	{
//		return Length + Height + GetHypotenuse();
//	}
//}

////Triangle DEMO 2

//Triangle first = new Triangle(4, 3);
//Console.WriteLine(first.GetArea());
//Console.WriteLine(first.GetHypotenuse());
//Console.WriteLine(first.GetPerimeter());

//// first.Height = 10; Can't do this now, because Height is private.

//class Triangle
//{

//	// We have a package, like a capsule
//	// The verb we use is "encapsulate"
//	// We've packaged together Length and Height
//	// into a triangle concept.
//	// We have "encapsulated" Length and Height
//	// into a triangle.

//	private double Length;
//	private double Height;
//	private double Area;

//	// Initializing the data
//	// Create a constructor
//	public Triangle(double _length, double _height)
//	{
//		Length = _length;
//		Height = _height;
//		Area = Length * Height / 2;
//	}

//	public double GetArea()
//	{
//		return Area;
//	}

//	public double GetHypotenuse()
//	{
//		return Math.Sqrt(Length * Length + Height * Height);
//	}

//	public double GetPerimeter()
//	{
//		return Length + Height + GetHypotenuse();
//	}
//}

////ACCESS DEMO
//Car first = new Car("Chevy", "Trax", Color.Blue);
//Console.WriteLine(first.GetMake()); // We can read the value of Make through this function
//Console.WriteLine(first.GetModel());
//Console.WriteLine(first.GetColor());
//first.SetColor(Color.Red);
//Console.WriteLine(first.GetColor());
////first.SetColor("White");
//Console.WriteLine(first.GetColor());

//// first.Make = "Ford";  // We cannot write the value of Make.


////bool yesno = false; // Two possible choices for a boolean variable
////int n = 100;
////double p = 3.14;
////Color carcolor = Color.Blue; // Four possible choices because of how we created our enum

////Color pianocolor = Color.Black; // We have four possible choices: Red, Blue, Black, Silver
////pianocolor = Color.Red;


//enum Color
//{
//	Red,
//	Blue,
//	Black,
//	Silver
//}


//class Car
//{
//	// Attributes that cannot be changed
//	private string Make;
//	private string Model;

//	// Attributes that can be changed
//	private Color CarColor;

//	public Car(string _make, string _model, Color _color)
//	{
//		Make = _make;
//		Model = _model;
//		CarColor = _color;
//	}

//	// Make only has a "getter" method, so we can only look at it. We cannot change it.
//	public string GetMake()
//	{
//		return Make;
//	}

//	// Model only has a "getter" method, so we can only look at it. We cannot change it.
//	public string GetModel()
//	{
//		return Model;
//	}

//	// Color has both a "getter" and "setter" so we can look at it AND change it.
//	public Color GetColor()
//	{
//		return CarColor;
//	}

//	public void SetColor(Color _color)
//	{
//		// Let's do some validation. Make sure it's a valid color.
//		//if (_color == Color.Red || _color == Color.Blue || _color == Color.Black || _color == Color.Silver)
//		//{
//		//	CarColor = _color;
//		//}

//		// With an enum, we don't need to validate
//		CarColor = _color;
//	}
//}
////ACCESS DEMO


//List<Song> playlist = new List<Song>();

//Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
//playlist.Add(song1);

//Song song2 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
//playlist.Add(song2);

//Song song3 = new Song("Britney Spears", "Toxic", "Pop", 2003);
//playlist.Add(song3);

//Console.WriteLine("Here are your songs:");
//foreach (Song next in playlist)
//{
//	Console.WriteLine(next.Title);
//}

//Console.WriteLine();
//Console.Write("Which song do you want more details on: ");
//string mysong = Console.ReadLine();

//class Song
//{
//	public string Artist;
//	public string Title;
//	public string Genre;
//	public int Year;

//	public Song(string _Artist, string _Title, string _Genre, int _Year)
//	{
//		Artist = _Artist;
//		Title = _Title;
//		Genre = _Genre;
//		Year = _Year;
//	}

//	public override string ToString()
//	{
//		return $"\"{Title}\" by {Artist} from {Year} ({Genre})";
//	}
//}
////LIST OF OBJECTS

//List<Song> playlist = new List<Song>();

//Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
//playlist.Add(song1);

//Song song2 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
//playlist.Add(song2);

//Song song3 = new Song("Britney Spears", "Toxic", "Pop", 2003);
//playlist.Add(song3);

//Console.WriteLine("Here are your songs:");
//foreach (Song next in playlist)
//{
//	Console.WriteLine(next.Title);
//}

//Console.WriteLine();
//Console.Write("Which song do you want more details on: ");
//string mysong = Console.ReadLine();

//class Song
//{
//	public string Artist;
//	public string Title;
//	public string Genre;
//	public int Year;

//	public Song(string _Artist, string _Title, string _Genre, int _Year)
//	{
//		Artist = _Artist;
//		Title = _Title;
//		Genre = _Genre;
//		Year = _Year;
//	}

//	public override string ToString()
//	{
//		return $"\"{Title}\" by {Artist} from {Year} ({Genre})";
//	}
//}

////LIST OF OBJECTS2

//
// Section 1: Create and populate the list of songs
//

List<Song> playlist = new List<Song>();

// We don't need to keep making a new variable after we put the object in the list.
Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
playlist.Add(song1);

// Let's just re-use the song1 variable.
song1 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
playlist.Add(song1);

song1 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playlist.Add(song1);

// Jeff's favorite approach
// In fact, we don't need a variable at all. We just the create the object,
// and hand its address right over to the List's Add method.
playlist.Add(new Song("Dave Brubeck", "Take 5", "Jazz", 1959));

//
// Section 2: Print out the titles
//

Console.WriteLine("Here is your playlist:");
foreach (Song next in playlist)
{
    Console.WriteLine(next.Title);
}


//
// Section 3: Ask the user for a song and print out the details
//

Console.Write("Which song title do you want more info on: ");
string mysong = Console.ReadLine();

Song found = FindSong(playlist, mysong);
if (found == null)
{
    Console.WriteLine("Sorry, we don't have that song.");
}
else
{
    Console.WriteLine(found);
}


//
// Section 4: A "helper method" that searches the list by title.
//            Side note: We need to pass the list in. Fact of life...
//

static Song FindSong(List<Song> thelist, string thetitle)
{
    foreach (Song next in thelist)
    {
        if (next.Title.ToLower() == thetitle.ToLower())
        {
            return next;
        }
    }
    return null;
}

class Song
{
    public string Artist;
    public string Title;
    public string Genre;
    public int Year;

    public Song(string _Artist, string _Title, string _Genre, int _Year)
    {
        Artist = _Artist;
        Title = _Title;
        Genre = _Genre;
        Year = _Year;
    }

    public override string ToString()
    {
        return $"\"{Title}\" by {Artist} from {Year} ({Genre})";
    }
}


