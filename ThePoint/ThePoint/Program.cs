//The first pedestal asks you to create a Point class to store a point in two dimensions. Each point is using
//represented by an x-coordinate (x), a side-to-side distance from a special central point called the origin,
//and a y-coordinate (y), an up-and-down distance away from the origin.
//Objectives:
//• Define a new Point class with properties for X and Y.
//• Add a constructor to create a point from a specific x- and y-coordinate.
//• Add a parameterless constructor to create a point at the origin (0, 0).
//• In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the
//console window in the format (x, y) to illustrate that the class works.
//• Answer this question: Are your X and Y properties immutable? Why did you do what you did?
Point origin = new Point();
Console.WriteLine($"The coordinates of the origin are: ({origin.x}, {origin.y})");

int x1 = 2;
int y1 = 3;
Point first = new Point(x1, y1);

int x2 = -4;
int y2 = 0;
Point second = new Point(x2, y2);

Console.WriteLine($"The coordinates of the first point is ({first.x}, {first.y}) and the points of the second point is ({second.x}, {second.y})");  

public class Point
{
    public int x { get; set; } = 0;

    public int y { get; set; } = 0;
    

    public Point(int x, int y )
    {
     
        this.x = x;
        this.y = y;

    }
    public Point(): this(0,0)
    {
        
    }
}



/*
 * You have fixed the property issue! By using `{ get; set; }` without a body, you are now using **Auto-Implemented Properties**. The compiler creates a hidden "backing field" for you, so you no longer have the infinite loop problem.

To set up **default values**, there are two ways to do it depending on what you want to achieve.

### 1. Using a Parameterless Constructor (The Challenge Requirement)

The "The Point" challenge specifically asks you to add a **parameterless constructor** that sets the point to (0, 0).

In C#, you can have multiple constructors in one class (this is called "overloading"). You simply add another constructor that takes no arguments:

```csharp
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Your existing constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // NEW: Parameterless constructor for default values
    public Point()
    {
        X = 0;
        Y = 0;
    }
}

```

Now, the user of your class has two options:

* `Point p1 = new Point(2, 3);` (Uses the first constructor)
* `Point p2 = new Point();` (Uses the second constructor, setting it to 0,0)

### 2. Constructor Chaining (The "Pro" Way)

As you read further in the book, you'll see a cleaner way to do this called **Constructor Chaining**. Instead of writing `X = 0; Y = 0;` twice, you can make the empty constructor "call" the one with parameters using the `this` keyword:

```csharp
public Point() : this(0, 0) 
{
    // This body stays empty because the other constructor does the work!
}

```

### 3. Property Initializers (The Modern C# Way)

If you want the properties to *always* start at a certain value unless told otherwise (even before any constructor runs), you can set them directly where they are declared:

```csharp
public int X { get; set; } = 0;
public int Y { get; set; } = 0;

```

**Which one should you use?**
For "The Point" challenge, the author is looking for **Option 1**: creating a second constructor with no parameters. This ensures you understand how to provide multiple ways to "build" an object!
 * 
 * 
 * 
 */

