using System;
using System;

class Program
{
    static void Main()
    {
       
        Point point1 = new Point(0, 0);
        Point point2 = new Point(3, 0);
        Point point3 = new Point(3, 4);

        
        Triangle triangle = new Triangle(point1, point2, point3);

       
        Console.WriteLine("Points of the Triangle:");
        Console.WriteLine($"Point 1: {point1}");
        Console.WriteLine($"Point 2: {point2}");
        Console.WriteLine($"Point 3: {point3}");

        
        Console.WriteLine($"Perimeter of the Triangle: {triangle.Perimeter()}");
        Console.WriteLine($"Area of the Triangle: {triangle.Area()}");
    }
}

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Point(Point point)
    {
        X = point.X;
        Y = point.Y;
    }

    public double DistanceTo(Point other)
    {
        return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public class Triangle
{
    public Point Point1 { get; set; }
    public Point Point2 { get; set; }
    public Point Point3 { get; set; }

    public Triangle(Point point1, Point point2, Point point3)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }

    public double Perimeter()
    {
        return Point1.DistanceTo(Point2) + Point2.DistanceTo(Point3) + Point3.DistanceTo(Point1);
    }

    public double Area()
    {
        double semiPerimeter = Perimeter() / 2;
        double side1 = Point1.DistanceTo(Point2);
        double side2 = Point2.DistanceTo(Point3);
        double side3 = Point3.DistanceTo(Point1);
        return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
    }

    public override string ToString()
    {
        return $"Triangle[Point1: {Point1}, Point2: {Point2}, Point3: {Point3}]";
    }
}
