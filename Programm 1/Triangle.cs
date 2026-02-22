using System.Linq;
using System.Runtime.ExceptionServices;

namespace TaskI;

public class Triangle
{
    public Point pointA { get; }
    public Point pointB { get; }
    public Point pointC { get; }

    public Triangle(Point pointA, Point pointB, Point pointC)
    {
        this.pointA = pointA;
        this.pointB = pointB;
        this.pointC = pointC;
    }

    public double GetSquare()
    {
        double a = Math.Sqrt(Math.Pow((pointA - pointB).pointX, 2) + Math.Pow((pointA - pointB).pointY, 2));
        double b = Math.Sqrt(Math.Pow((pointC - pointB).pointX, 2) + Math.Pow((pointC - pointB).pointY, 2));
        double c = Math.Sqrt(Math.Pow((pointC - pointA).pointX, 2) + Math.Pow((pointC - pointA).pointY, 2));
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
    (Math.Round(pointA.pointX, 2) == Math.Round(pointB.pointX, 2) && Math.Round(pointB.pointX, 2) == Math.Round(pointC.pointX, 2) &&
     Math.Round(pointA.pointY, 2) == Math.Round(pointB.pointY, 2) && Math.Round(pointB.pointY, 2) == Math.Round(pointC.pointY, 2));

    public bool IsLine()
    {
        List<double> xPoints = new List<double>(), yPoints = new List<double>();
        xPoints.Add(pointA.pointX); yPoints.Add(pointA.pointY);
        xPoints.Add(pointB.pointX); yPoints.Add(pointB.pointY);
        xPoints.Add(pointC.pointX); yPoints.Add(pointC.pointY);

        if((Math.Round(pointA.pointX, 2) == Math.Round(pointB.pointX, 2) && Math.Round(pointB.pointX, 2) == Math.Round(pointC.pointX, 2)) ^
           (Math.Round(pointA.pointY, 2) == Math.Round(pointB.pointY, 2) && Math.Round(pointB.pointY, 2) == Math.Round(pointC.pointY, 2)))
            return true;
        
        if(((yPoints.Max() - yPoints.Min()) / (xPoints.Max() - xPoints.Min()) ==
            yPoints.Single(n => n != yPoints.Max() && n != yPoints.Min()) /
            xPoints.Single(n => n != xPoints.Max() && n != xPoints.Min())))
            return true;
        return false;   
    }

}