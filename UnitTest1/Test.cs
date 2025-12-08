using MasterOfArrays;
namespace UnitTest;

[TestClass]
public sealed class Test
{
    [TestMethod]
    public void TestMethodOfAddToDataBase()
    {
        var dbConnector = new DateBaseConnector();
        dbConnector.AddUser("testUser_1", "100", "", "");
        dbConnector.AddUser("testUser_2", "1000", "", "");
        dbConnector.AddUser("testUser_3", "10000", "", "");

        dbConnector.SignIsWellDone("testUser_1", "100");
        for (int i = 0; i < 100; i++)
        {
            Assert.AreEqual(true, dbConnector.AddArray("1 1 1 2", ("Array" + i)));
        }
        dbConnector.SignIsWellDone("testUser_2", "1000");
        for (int i = 0; i < 1000; i++)
        {
            Assert.AreEqual(true, dbConnector.AddArray("1 1 1 2", ("Array" + i)));
        }
        dbConnector.SignIsWellDone("testUser_3", "10000");
        for (int i = 0; i < 10000; i++)
        {
            Assert.AreEqual(true, dbConnector.AddArray("1 1 1 2", ("Array" + i)));
        }
        dbConnector.SignIsWellDone("testUser_1", "100");
        for (int i = 0; i < 100; i++)
        {
            Assert.AreEqual(true, dbConnector.DeleteArray("Array" + i));
        }
        dbConnector.SignIsWellDone("testUser_2", "1000");
        for (int i = 0; i < 1000; i++)
        {
            Assert.AreEqual(true, dbConnector.DeleteArray("Array" + i));
        }
        dbConnector.SignIsWellDone("testUser_3", "10000");
        for (int i = 0; i < 10000; i++)
        {
            Assert.AreEqual(true, dbConnector.DeleteArray("Array" + i));
        }
    }
}
