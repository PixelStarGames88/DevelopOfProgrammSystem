//Point.cs
namespace TaskI;
public class Point
{
    public double PointX { get; set; }
    public double PointY { get; set; }

    public Point(double PointX, double PointY) { this.PointX = PointX; this.PointY = PointY; }
    public bool PointInTrangle(Triangle someTriangle)
    {
        if (someTriangle.GetSquare().Equals
                      (new Triangle(this, someTriangle.PointA, someTriangle.PointB).GetSquare() +
                       new Triangle(this, someTriangle.PointB, someTriangle.PointC).GetSquare() +
                       new Triangle(this, someTriangle.PointC, someTriangle.PointA).GetSquare()))
        {
            Console.WriteLine("Точка с координатами ({0:f2}; {1:f2}) не в треугольнике с вершинами в координатах:", this.PointX, this.PointY);
            Console.WriteLine("A ({0:f2}; {1:f2});", someTriangle.PointA.PointX, someTriangle.PointA.PointY);
            Console.WriteLine("B ({0:f2}; {1:f2});", someTriangle.PointB.PointX, someTriangle.PointB.PointY);
            Console.WriteLine("C ({0:f2}; {1:f2}).", someTriangle.PointC.PointX, someTriangle.PointC.PointY);
            return false;
        }

        Console.WriteLine("Точка с координатами ({0:f2}; {1:f2}) в треугольнике с вершинами в координатах:", this.PointX, this.PointY);
        Console.WriteLine("A ({0:f2}; {1:f2});", someTriangle.PointA.PointX, someTriangle.PointA.PointY);
        Console.WriteLine("B ({0:f2}; {1:f2});", someTriangle.PointB.PointX, someTriangle.PointB.PointY);
        Console.WriteLine("C ({0:f2}; {1:f2}).", someTriangle.PointC.PointX, someTriangle.PointC.PointY);
        return true;
    }
    public static Point GenerateRandomPoint(int firstPointX, int secondPointX, int firstPointY, int secondPointY)
    {
        Random rand = new Random();

        if (firstPointY > secondPointY) { int tmp = firstPointY; firstPointY = secondPointY; secondPointY = tmp; }
        if (firstPointX > secondPointX) { int tmp = firstPointX; firstPointX = secondPointX; secondPointX = tmp; }

        Point somePoint = new Point(firstPointX + (secondPointX - firstPointX) * rand.NextDouble(),
                                    firstPointY + (secondPointY - firstPointY) * rand.NextDouble());

        return somePoint;
    }

    public static Point operator -(Point point_1, Point point_2)
    {
        return new(point_1.PointX - point_2.PointX, point_1.PointY - point_2.PointY);
    }

}