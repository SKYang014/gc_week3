
bool again = true;
int count = 0;
Console.WriteLine("Welcome to Chirpus Circle Maker");

do
{
    count++;
    Console.WriteLine("Please enter the radius of the circle you'd like to create: ");
    double radius;
    bool radiusTest = double.TryParse(Console.ReadLine(), out radius);
    Circle shape = new Circle(radius);

    while (!radiusTest || radius < 1)
    {
        Console.WriteLine("Please enter in a valid number!");
        radiusTest = double.TryParse(Console.ReadLine(), out radius);
    }

    Console.WriteLine("The circumference of this circle is " + shape.circumference(radius));
    Console.WriteLine("The area of this circle is " + shape.area(radius));

    again = ask();
} while (again);
Console.WriteLine($"You've made {count} circles, BYEE");

static bool ask()
{
    Console.WriteLine("Would you like to calculate another circle? y/n");
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

class Circle
{
    public double Radius;

    public Circle(double aRadius)
    {
        Radius = aRadius;

    }

    public double circumference(double x)
    {
        double radDoub = 2 * x;
        string circ = String.Format("{0:0.00}", radDoub * Math.PI);
        circ = double.Parse(circ);
        return circ;
    }
    public double area(double x)
    {
        double radSqr = x * x;
        double area = radSqr * Math.PI;
        return area;

    }

    public override string ToString()
    {
        return $"Radius: {Radius}";
    }
}