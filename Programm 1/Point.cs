namespace TaskI;
public class Point
{
    public double pointX { get; set; }
    public double pointY { get; set; }

    public Point(double PointX, double PointY) { this.pointX = PointX; this.pointY = PointY; }
    public bool PointInTrangle(Triangle someTriangle)
    {
        if (Math.Round(someTriangle.GetSquare(), 3) != 
            Math.Round(new Triangle(this, someTriangle.pointA, someTriangle.pointB).GetSquare() +
                       new Triangle(this, someTriangle.pointB, someTriangle.pointC).GetSquare() +
                       new Triangle(this, someTriangle.pointC, someTriangle.pointA).GetSquare(), 3))
        {
            Console.WriteLine("Точка с координатами ({0:f2}; {1:f2}) не в треугольнике с вершинами в координатах:", this.pointX, this.pointY);
            Console.WriteLine("A ({0:f2}; {1:f2});", someTriangle.pointA.pointX, someTriangle.pointA.pointY);
            Console.WriteLine("B ({0:f2}; {1:f2});", someTriangle.pointB.pointX, someTriangle.pointB.pointY);
            Console.WriteLine("C ({0:f2}; {1:f2}).", someTriangle.pointC.pointX, someTriangle.pointC.pointY);
            return false;
        }

        Console.WriteLine("Точка с координатами ({0:f2}; {1:f2}) в треугольнике с вершинами в координатах:", this.pointX, this.pointY);
        Console.WriteLine("A ({0:f2}; {1:f2});", someTriangle.pointA.pointX, someTriangle.pointA.pointY);
        Console.WriteLine("B ({0:f2}; {1:f2});", someTriangle.pointB.pointX, someTriangle.pointB.pointY);
        Console.WriteLine("C ({0:f2}; {1:f2}).", someTriangle.pointC.pointX, someTriangle.pointC.pointY);
        return true;
    }
    public static Point GenerateRandomPoint(int firstPointX, int secondPointX, int firstPointY, int secondPointY)
    {
        Random rand = new Random();

        if (firstPointY > secondPointY) { int tmp = firstPointY; firstPointY = secondPointY; secondPointY = tmp; }
        if (firstPointX > secondPointX) { int tmp = firstPointX; firstPointX = secondPointX; secondPointX = tmp; }

        Point somePoint = new Point(rand.Next(firstPointX, secondPointX), rand.Next(firstPointY, secondPointY));
        somePoint.pointX = firstPointX + (somePoint.pointX - firstPointX) * rand.NextDouble();
        somePoint.pointY = firstPointY + (somePoint.pointY - firstPointY) * rand.NextDouble();

        return somePoint;
    }

    public static Point operator -(Point point_1, Point point_2)
    {
        return new(point_1.pointX - point_2.pointX, point_1.pointY - point_2.pointY);
    }

}