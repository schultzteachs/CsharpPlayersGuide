

Circle BigRedCircle =  new Circle();
BigRedCircle.radius = 20;
Console.WriteLine($"The radius for {BigRedCircle} is {BigRedCircle.radius}. Which means its area is {BigRedCircle.Area}");
Circle smallbluecircle = new Circle();
smallbluecircle.radius = 3;

public class Circle
{
    public static int TotalCirclesCreated = 0;
    private double _radius;

    public double radius
    {
        get { return _radius; }
        set
        {
            if (value < 0) _radius = 0;
            else _radius = value;
        }
    }
    public double Area
    {
        get { return 3.14159 * _radius * _radius; }
    }

    public Circle()
    {
        TotalCirclesCreated++;
    }
}