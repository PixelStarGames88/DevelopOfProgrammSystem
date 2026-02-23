//Triangle.cs
namespace TaskI;
public class Triangle
{
    public Point PointA { get; }
    public Point PointB { get; }
    public Point PointC { get; }

    public Triangle(Point pointA, Point pointB, Point pointC)
    {
        this.PointA = pointA;
        this.PointB = pointB;
        this.PointC = pointC;
    }

    public double GetSquare()
    {
        double a = Math.Sqrt(Math.Pow((PointA - PointB).PointX, 2) + Math.Pow((PointA - PointB).PointY, 2));
        double b = Math.Sqrt(Math.Pow((PointC - PointB).PointX, 2) + Math.Pow((PointC - PointB).PointY, 2));
        double c = Math.Sqrt(Math.Pow((PointC - PointA).PointX, 2) + Math.Pow((PointC - PointA).PointY, 2));
        double p = (a + b + c) / 2;
        return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }

    public static Triangle GenerateRandomTriangle(int firstPointX, int secondPointX, int firstPointY, int secondPointY)
    {
        Point PointA = Point.GenerateRandomPoint(firstPointX, secondPointX, firstPointY, secondPointY);
        Point PointB = Point.GenerateRandomPoint(firstPointX, secondPointX, firstPointY, secondPointY);
        Point PointC = Point.GenerateRandomPoint(firstPointX, secondPointX, firstPointY, secondPointY);

        return new Triangle(PointA, PointB, PointC);
    }

    public bool IsPoint() =>
    (PointA.PointX.Equals(PointB.PointX) && PointB.PointX.Equals(PointC.PointX) &&
     PointA.PointY.Equals(PointB.PointY) && PointA.PointY.Equals(PointC.PointY));

    public bool IsLine()
    {
        List<Point> points = new List<Point> { PointA, PointB, PointC };
        foreach (Point firstPoint in points)
            foreach (Point secondPoint in points)
                foreach (Point thirdPoint in points)
                    if (((firstPoint.PointY - thirdPoint.PointY) / (secondPoint.PointY - thirdPoint.PointY)).Equals((firstPoint.PointX - thirdPoint.PointX) / (secondPoint.PointX - thirdPoint.PointX)) &&
                        !firstPoint.Equals(secondPoint) && !firstPoint.Equals(thirdPoint) && !thirdPoint.Equals(secondPoint))
                        return true;

        return false;
    }

}