namespace TaskI;
internal class Point
{
    public double pointX { get; }
    public double pointY { get; }

    public Point(double PointX, double PointY) { this.pointX = PointX; this.pointY = PointY; }
    public bool PointInTrangle(Triangle someTriangle)
    {
        if (Math.Round(someTriangle.GetSquare(), 3) != 
            Math.Round(new Triangle(this, someTriangle.pointA, someTriangle.pointB).GetSquare() +
                       new Triangle(this, someTriangle.pointB, someTriangle.pointC).GetSquare() +
                       new Triangle(this, someTriangle.pointC, someTriangle.pointA).GetSquare()))
            return false;
        return true;
    }

    public static Point operator -(Point point_1, Point point_2)
    {
        return new(point_1.pointX - point_2.pointX, point_1.pointY - point_2.pointY);
    }

}