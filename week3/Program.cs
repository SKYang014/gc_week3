// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
////Pen Demo
//// int x = 10;
//// List<string> mylist = new List<string>();

//// firstpen is an object that has inside it four variables.

//Pen firstpen = new Pen();
//firstpen.InkColor = "blue";
//firstpen.Length = 4.5;
//firstpen.PointType = "Gel";
//firstpen.PointSize = "Small";
//firstpen.InkAmount = 5;

//Console.WriteLine(firstpen.InkColor);
//Console.WriteLine(firstpen.Length);
//Console.WriteLine(firstpen.PointType);
//Console.WriteLine(firstpen.PointSize);
//Console.WriteLine(firstpen.InkAmount);

//Console.WriteLine("Let's draw with firstpen!");
//firstpen.Draw();
//Console.WriteLine($"The ink is now {firstpen.InkAmount}");

//Console.WriteLine();

//Pen secondpen = new Pen();
//secondpen.InkColor = "red";
//secondpen.Length = 4.5;
//secondpen.PointType = "Ball Point";
//secondpen.PointSize = "Medium";
//secondpen.InkAmount = 2;

//Console.WriteLine(secondpen.InkColor);
//Console.WriteLine(secondpen.Length);
//Console.WriteLine(secondpen.PointType);
//Console.WriteLine(secondpen.PointSize);
//Console.WriteLine(secondpen.InkAmount);

//Console.WriteLine("Let's do two drawings with secondpen!");
//secondpen.Draw();
//secondpen.Draw();

//Console.WriteLine($"secondpen now has ink level {secondpen.InkAmount}");
//Console.WriteLine($"firstpen still has ink level {firstpen.InkAmount}");

//secondpen.Draw();
//Console.WriteLine($"secondpen now has ink level {secondpen.InkAmount}");

//secondpen.Refill();
//Console.WriteLine($"secondpen now has ink level {secondpen.InkAmount}");

//Console.WriteLine();
//Console.WriteLine("Let's refill firstpen with green ink");
//firstpen.Refill("green");
//Console.WriteLine($"First pen has ink {firstpen.InkColor}");

//Console.WriteLine();
//Pen thirdpen = new Pen();
//Console.WriteLine(thirdpen.InkAmount);

//Console.WriteLine();
//Pen fourthpen = new Pen("green");
//Console.WriteLine(fourthpen.InkAmount);
//Console.WriteLine(fourthpen.InkColor);

//class Pen
//{
//	// Member variables
//	public string InkColor;
//	public double Length;
//	public string PointType;
//	public string PointSize;
//	public int InkAmount;

//	public Pen() // Default Constructor
//	{
//		InkAmount = 10;
//		InkColor = "black";
//	}

//	public Pen(string _InkColor)
//	{
//		InkColor = _InkColor;
//		InkAmount = 10;
//	}

//	// Member methods
//	public void Draw()
//	{
//		if (InkAmount > 0)
//		{
//			InkAmount--;
//		}
//	}

//	public void Refill()
//	{
//		InkAmount = 10;
//	}

//	// Let's add another Refill function that lets us specify ink color
//	public void Refill(string InkColor)
//	{
//		this.InkColor = InkColor;
//		InkAmount = 10;
//	}
//}

////penDemo2

//Pen gelpen = new Pen("green", 5.0, "Gel", "Medium");
//gelpen.Print();

//Pen feltpen = new Pen("blue", 4.0, "Felt", "Small");
//feltpen.Print();

//gelpen.Draw(5);
//gelpen.Print();
//gelpen.Draw(7);
//gelpen.Print();

//Console.WriteLine(gelpen);

//class Pen
//{
//	public string InkColor;
//	public double Length;
//	public string PointType;
//	public string PointSize;
//	public int InkAmount;

//	public Pen(string _InkColor, double _Length, string _PointType, string _PointSize)
//	{
//		InkColor = _InkColor;
//		Length = _Length;
//		PointType = _PointType;
//		PointSize = _PointSize;
//		InkAmount = 10;
//	}

//	public void Print()
//	{
//		Console.WriteLine("This pen:");
//		Console.WriteLine($"   Color: {InkColor} Length: {Length} Type: {PointType} Size: {PointSize} Amount: {InkAmount}");
//	}

//	public void Draw(int linelength)
//	{
//		if (linelength > InkAmount)
//		{
//			Console.WriteLine("Sorry, not enough ink for that!");
//			return;
//		}

//		InkAmount -= linelength;
//		if (InkAmount < 0)
//		{
//			InkAmount = 0;
//		}
//	}

//	public void Refill()
//	{
//		InkAmount = 10;
//	}

//	public override string ToString()
//	{
//		return $"Color: {InkColor}   Length: {Length}   Type: {PointType}   Size: {PointSize}   Amount: {InkAmount}";
//	}
//}


////CDDemo

// First CompactDisc: The Wall

CompactDisc thewall = new CompactDisc("Pink Floyd", "Rock", 80);
Console.WriteLine(thewall);
thewall.Songs.Add("In the Flesh?");
thewall.Songs.Add("The Thin Ice");
thewall.Songs.Add("Another Brick in the Wall, Part 1");
thewall.Songs.Add("The Happiest Days of Our Lives");
thewall.Songs.Add("Another Brick in the Wall, Part 2");
foreach (string song in thewall.Songs)
{
Console.WriteLine(song);
}
Console.WriteLine($"This album has {thewall.Songcount()} songs on it.");

// Let's practice copying -- we actually have the same object referenced by two variables

//CompactDisc another = thewall;
//Console.WriteLine(another.Artist);

Console.WriteLine();
PrintAlbumInfo(thewall);

static void PrintAlbumInfo(CompactDisc which)
{
Console.WriteLine("======Album Info======");
Console.WriteLine(which);
foreach (string song in which.Songs)
{
Console.WriteLine($"  {song}");
}
Console.WriteLine($"  Total song count: {which.Songcount()}");
}


class CompactDisc
{
    public string Artist;
    public string Genre;
    public int Duration;
    public List<string> Songs;

    public CompactDisc(string _Artist, string _Genre, int _Duration)
    {
        Artist = _Artist;
        Genre = _Genre;
        Duration = _Duration;
        Songs = new List<string>();
    }

    public int Songcount()
    {
        return Songs.Count;
    }

    public override string ToString()
    {
        return $"Artist: {Artist}   Genre: {Genre}   Duration: {Duration} minutes";
    }
}
