using Sort;
namespace SortTest;
[TestClass]
public sealed class SortTest
{
    [TestMethod]
    public void SortIsCorrect()
    {
        int[] sortedArray = { 0, 1, 2, 5, 6, 9 };
        int[] startArray = { 6, 9, 2, 1, 5, 0 };
        SortedArray testArray = new SortedArray();
        testArray.AddNumbers(startArray);
        testArray.SortArray();
        CollectionAssert.AreEqual(testArray.GetSortArray, sortedArray, message: "Test is not correct");
    }
}
