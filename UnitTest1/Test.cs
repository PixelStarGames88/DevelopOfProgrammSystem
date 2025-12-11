using MasterOfArrays;
namespace IntegratedTest;

[TestClass]
public sealed class Test
{
    DateBaseConnector dbConnector = null!;
    Random random = null!;
    ArrayEditor arrayEditor = null!;

    [TestInitialize]
    public void TestSetup()
    {
        arrayEditor = new ArrayEditor();
        dbConnector = new DateBaseConnector();
        random = new Random();

        dbConnector.DeleteUser("testUser");
        dbConnector.AddUser("testUser", "100", "", "");
        dbConnector.SignIsWellDone("testUser", "100");
    }
    public bool AddTest(int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            arrayEditor.AddRandomNumbers((uint)random.Next(0, Constants.QUANTITY_LIMIT),
                                     random.Next(-Constants.NUMBER_IN_ARRAY_LIMIT, Constants.NUMBER_IN_ARRAY_LIMIT),
                                     random.Next(-Constants.NUMBER_IN_ARRAY_LIMIT, Constants.NUMBER_IN_ARRAY_LIMIT));
            dbConnector.AddArray(arrayEditor.GetStringSourceArray(), ("Array " + i));
        }
        return quantity == dbConnector.UserArrays.Count;
    }

    public bool DownloadTest(int quantity)
    {
        int count = 0;
        for (int i = 0; i < quantity; ++i)
        {
            string array = "";
            if (dbConnector.GetArrayFromDB(out array, ("Array " + i))) count++;
        }
        return count == quantity;
    }

    public bool DeleteTest(int quantity)
    {

        for (int i = 0; i < quantity; i++)
        {
            dbConnector.DeleteArray("Array " + i);
        }
        return dbConnector.UserArrays.Count == 0;
    }

    [TestCleanup]
    public void TestTeardown()
    {
        dbConnector.DeleteUser("testUser");
    }
    [AssemblyCleanup]
    public static void AssemblyTeardown()
    {
        var dbConnector = new DateBaseConnector();
        dbConnector.VacuumDB();
    }

    [TestMethod]
    [DoNotParallelize]
    public void TestMethod_01_With100Arrays()
    {
        Assert.IsTrue(AddTest(100));
        Assert.IsTrue(DownloadTest(100));
        Assert.IsTrue(DeleteTest(100));
    }
    
    [TestMethod]
    [DoNotParallelize]
    public void TestMethod_02_With1000Arrays()
    {
        Assert.IsTrue(AddTest(1000));
        Assert.IsTrue(DownloadTest(1000));
        Assert.IsTrue(DeleteTest(1000));
    }

    [TestMethod]
    [DoNotParallelize]
    public void TestMethod_03_With10000Arrays()
    {
        Assert.IsTrue(AddTest(10000));
        Assert.IsTrue(DownloadTest(10000));
        Assert.IsTrue(DeleteTest(10000));
    }

}