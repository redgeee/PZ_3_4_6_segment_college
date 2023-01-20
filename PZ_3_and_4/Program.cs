Console.WriteLine("---LineSegment---");
Console.WriteLine("---Line1---");
LineSegment lineSegment1 = new LineSegment(5, 3, 1, 7);
Console.WriteLine(lineSegment1);
Console.WriteLine($"Point1: {lineSegment1.Point1}\nPoint2: {lineSegment1.Point2}");

Console.WriteLine("---Line2---");
LineSegment lineSegment2 = new LineSegment(new Point(7, 3.5), new Point(2, 8.43));
Console.WriteLine(lineSegment2);
Console.WriteLine($"Point1: X:{lineSegment2.Point1.CoordX}, " +
    $"Y:{lineSegment2.Point1.CoordY}\nPoint2: {lineSegment2.Point2}");

Console.WriteLine("---Line2.1---");
lineSegment2.Point1 = new Point(10, 20);
lineSegment2.Point2.SetPoint(4.5, 78.12);
Console.WriteLine(lineSegment2);


public class LineSegment
{
    public LineSegment(Point point1, Point point2)
    {
        this.point1 = point1;
        this.point2 = point2;
    }
    public LineSegment(double x1, double y1, double x2, double y2)
    {
        this.point1 = new Point(x1, y1);
        this.point2 = new Point(x2, y2);
    }

    private Point point1;
    private Point point2;

    public Point Point1
    {
        get { return point1; }
        set { point1 = value; }
    }
    public Point Point2
    {
        get { return point2; }
        set { point2 = value; }
    }

    public override string ToString() =>
        "point1: " + point1.ToString() + " point2: " + point2.ToString();
}

public class Point
{
    public Point(double coordX, double coordY)
    {
        this.coordX = coordX;
        this.coordY = coordY;
    }

    private double coordX;
    private double coordY;

    public double CoordX { get { return coordX; } set { coordX = value; } }
    public double CoordY { get { return coordY; } set { coordY = value; } }

    public void SetPoint(double coordX, double coordY)
    {
        this.coordX = coordX;
        this.coordY = coordY;
    }

    public override string ToString() => GetCoord();
    public string GetCoord() => $"({coordX}, {coordY})";
}
