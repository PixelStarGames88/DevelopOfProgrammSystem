namespace TaskI;

internal class Triangle
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
}