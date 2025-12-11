using MasterOfArrays;
using System;
namespace UnitTest;

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
    public bool UserTest(int quantity)
    {
        
        int count = 0;
        for (int i = 0; i < quantity; i++)
        {
            
            arrayEditor.AddRandomNumbers((uint)random.Next(0, Constants.QUANTITY_LIMIT),
                                     random.Next(-Constants.NUMBER_IN_ARRAY_LIMIT, Constants.NUMBER_IN_ARRAY_LIMIT),
                                     random.Next(-Constants.NUMBER_IN_ARRAY_LIMIT, Constants.NUMBER_IN_ARRAY_LIMIT));
            if (dbConnector.AddArray(arrayEditor.GetStringSourceArray(), ("Array" + i))) count++;
            arrayEditor.ClearArray();   
        }
        for(int i = 0; i < quantity; ++i)
        {
            string array;
            if(dbConnector.GetArrayFromDB(out array, ("Array" + i))) count++;
        }
        for( int i = 0; i < quantity; i++)
        {
            if(dbConnector.DeleteArray("Array" + i)) count++;

        }
        return count == quantity * 3;
    }

    [TestCleanup]
    public void TestTeardown()
    {
        dbConnector.DeleteUser("testUser");
    }

    [TestMethod]
    public void TestMethodWithHundriedArrays()
    {
        Assert.IsTrue(UserTest(100));
    }
    [TestMethod]
    public void TestMethodWithThouthendArrays()
    {
        Assert.IsTrue(UserTest(1000));
    }
    [TestMethod]
    public void TestMethodWithTenThouthendArrays()
    {
        Assert.IsTrue(UserTest(10000));
    }
}