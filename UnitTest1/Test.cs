using MasterOfArrays;
namespace UnitTest;

[TestClass]
public sealed class Test
{
    [TestMethod]
    public void TestMethod()
    {
        var dbConnector = new DateBaseConnector();
        dbConnector.AddUser("testUser_1", "100", "", "");
        dbConnector.AddUser("testUser_2", "1000", "", "");
        dbConnector.AddUser("testUser_3", "10000", "", "");

        ArrayEditor arrayEditor = new ArrayEditor();

        dbConnector.SignIsWellDone("testUser_1", "100");
        for (int i = 0; i < 100; i++)
        {
            Assert.IsTrue(dbConnector.AddArray("1 1 1 2", ("Array" + i)));
        }
        dbConnector.SignIsWellDone("testUser_2", "1000");
        for (int i = 0; i < 1000; i++)
        {
            Assert.IsTrue(dbConnector.AddArray("1 1 1 2", ("Array" + i)));
        }
        dbConnector.SignIsWellDone("testUser_3", "10000");
        for (int i = 0; i < 10000; i++)
        {
            Assert.IsTrue(dbConnector.AddArray("1 1 2", ("Array" + i)));
        }

        dbConnector.SignIsWellDone("testUser_1", "100");
        arrayEditor.ClearArray();
        for (int i = 0; i < 100; i++)
        {
            string ArrayString;
            Assert.IsTrue(dbConnector.GetArrayFromDB(out ArrayString, ("Array" + i)));
            Assert.IsTrue(arrayEditor.AddNumbersFromString(ArrayString));
        }
        dbConnector.SignIsWellDone("testUser_2", "1000");
        arrayEditor.ClearArray();
        for (int i = 0; i < 1000; i++)
        {
            string ArrayString;
            Assert.IsTrue(dbConnector.GetArrayFromDB(out ArrayString, ("Array" + i)));
            Assert.IsTrue(arrayEditor.AddNumbersFromString(ArrayString));
        }
        dbConnector.SignIsWellDone("testUser_3", "10000");
        arrayEditor.ClearArray();
        for (int i = 0; i < 10000; i++)
        {
            string ArrayString;
            Assert.IsTrue(dbConnector.GetArrayFromDB(out ArrayString, ("Array" + i)));
            Assert.IsTrue(arrayEditor.AddNumbersFromString(ArrayString));
        }
        arrayEditor.ClearArray();

        dbConnector.SignIsWellDone("testUser_1", "100");
        for (int i = 0; i < 100; i++)
        {
            Assert.IsTrue(dbConnector.DeleteArray("Array" + i));
        }
        dbConnector.SignIsWellDone("testUser_2", "1000");
        for (int i = 0; i < 1000; i++)
        {
            Assert.IsTrue(dbConnector.DeleteArray("Array" + i));
        }
        dbConnector.SignIsWellDone("testUser_3", "10000");
        for (int i = 0; i < 10000; i++)
        {
            Assert.IsTrue(dbConnector.DeleteArray("Array" + i));
        }
    }
}
