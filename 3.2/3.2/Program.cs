
List<Movie> movies = new List<Movie>();
bool again = true;

movies.Add(new Movie("My Neighbor Totoro", "Animated"));
movies.Add(new Movie("Kiki's Delivery Service", "Animated"));
movies.Add(new Movie("Howl's Moving Castle", "Drama"));
movies.Add(new Movie("Princess Mononke", "Drama"));
movies.Add(new Movie("The Cat Returns", "Drama"));
movies.Add(new Movie("Spirited Away", "Horror"));
movies.Add(new Movie("Ponyo", "Horror"));
movies.Add(new Movie("Grave of the Fireflies", "Horror"));
movies.Add(new Movie("Nausicaa", "Sci-Fi"));
movies.Add(new Movie("Castle in the Sky", "Sci-Fi"));

//Console.WriteLine("Here are all of the movies: ");

//Movie find = findMovie(movies, choice);
//bool categoryTest = movies.Contains(choice);
//if (categoryTest)
//{

do
{

    Console.WriteLine($"There are {movies.Count} movies total");
    Console.WriteLine("What Category are you interested in? \n" +
        "Please enter animated, drama, horror, or sci-fi: ");
    string choice = Console.ReadLine();

    if (choice == "Animated" || choice == "Drama" || choice == "Horror" || choice == "Sci-fi")

    {

        findMovie(movies, choice);
    }

    else
    {
        Console.WriteLine("Whoops we don't carry that category\n" +
            "Consider donating to expand our library!");

    }
    again = ask();
} while (again);



static bool ask()
{
    Console.WriteLine("Would you like to see another category? y/n");
    string answer = Console.ReadLine().ToLower();
    if (answer == "yes" || answer == "y")
    {
        return true;
    }
    else if (answer == "no" || answer == "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("Please only enter yes or no: ");
        return ask();
    }
}

//fn loops through the list and returns each movie with the choosen category
static Movie findMovie(List<Movie> y, string x)
{
    foreach (Movie item in y)
    {
        if (x == item.Category)
        {
            Console.WriteLine(item);
        }
    };
    return null;

}


class Movie
{
    public string Title;
    public string Category;


    public Movie(string aTitle, string aCategory)
    {
        Title = aTitle;
        Category = aCategory;
    }

    public override string ToString()
    {
        return $"{Title} is in category: {Category}";
    }
}
