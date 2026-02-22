using TaskI;

namespace TestProject;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethodSmall()
    {
        Point somePoint = new(1, 2);
        Point pointA = new(-10, 2);
        Point pointB = new(1, 10);
        Point pointC = new(6, -10);

        Triangle someTriange = new(pointA, pointB, pointC);

        Assert.IsTrue(somePoint.PointInTrangle(someTriange));
    }

    [TestMethod]
    public void TestMethodMiddle()
    {
        Point somePoint = new(154.2, 213.4);
        Point pointA = new(-1563.44, 2443.4);
        Point pointB = new(1123.4, 1092.34);
        Point pointC = new(666.23, -1180.01);

        Triangle someTriange = new(pointA, pointB, pointC);

        Assert.IsTrue(somePoint.PointInTrangle(someTriange));
    }

    [TestMethod]
    public void TestMethodLarge()
    {
        Point somePoint = new(12991.3, 13202.2);
        Point pointA = new(-193384.764, 340492.3);
        Point pointB = new(203491.534, 136243.4);
        Point pointC = new(123355.4, -784629.012);

        Triangle someTriange = new(pointA, pointB, pointC);

        Assert.IsTrue(somePoint.PointInTrangle(someTriange));
    }
}
