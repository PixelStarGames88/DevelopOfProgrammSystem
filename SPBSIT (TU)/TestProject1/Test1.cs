using SPBSIT__TU_;

namespace TestProject1;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void SmallShakerTest()
    {
        ArrayObject arrayObject = new ArrayObject();
        arrayObject.GenerateArray(-10, 10, 10);
        int[] someArray = new int[10];
        arrayObject.SomeArray.CopyTo(someArray, 0);
        Array.Sort(someArray);
        CollectionAssert.AreEquivalent(someArray, arrayObject.SortArrayByShaker());
    }
    [TestMethod]
    public void SmallShellTest()
    {
        ArrayObject arrayObject = new ArrayObject();
        arrayObject.GenerateArray(-10, 10, 10);
        int[] someArray = new int[10];
        arrayObject.SomeArray.CopyTo(someArray, 0);
        Array.Sort(someArray);
        CollectionAssert.AreEquivalent(someArray, arrayObject.ShallsSort());
    }
    [TestMethod]
    public void ModdleShakerTest()
    {
        ArrayObject arrayObject = new ArrayObject();
        arrayObject.GenerateArray(-100, 100, 100);
        int[] someArray = new int[100];
        arrayObject.SomeArray.CopyTo(someArray, 0);
        Array.Sort(someArray);
        CollectionAssert.AreEquivalent(someArray, arrayObject.SortArrayByShaker());
    }
    [TestMethod]
    public void MiddleShellTest()
    {
        ArrayObject arrayObject = new ArrayObject();
        arrayObject.GenerateArray(-100, 100, 100);
        int[] someArray = new int[100];
        arrayObject.SomeArray.CopyTo(someArray, 0);
        Array.Sort(someArray);
        CollectionAssert.AreEquivalent(someArray, arrayObject.ShallsSort());
    }

    [TestMethod]
    public void LargeShakerTest()
    {
        ArrayObject arrayObject = new ArrayObject();
        arrayObject.GenerateArray(-10000, 10000, 10000);
        int[] someArray = new int[10000];
        arrayObject.SomeArray.CopyTo(someArray, 0);
        Array.Sort(someArray);
        CollectionAssert.AreEquivalent(someArray, arrayObject.SortArrayByShaker());
    }
    [TestMethod]
    public void LargeShellTest()
    {
        ArrayObject arrayObject = new ArrayObject();
        arrayObject.GenerateArray(-10000, 10000, 10000);
        int[] someArray = new int[10000];
        arrayObject.SomeArray.CopyTo(someArray, 0);
        Array.Sort(someArray);
        CollectionAssert.AreEquivalent(someArray, arrayObject.ShallsSort());
    }
}
