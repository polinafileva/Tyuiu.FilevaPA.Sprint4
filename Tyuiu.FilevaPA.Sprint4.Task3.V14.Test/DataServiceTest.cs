namespace Tyuiu.FilevaPA.Sprint4.Task3.V14.Test;
using Tyuiu.FilevaPA.Sprint4.Task3.V14.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int[,] array = {
                { 3, 2, 3, 3, 5 },
                { 2, 3, 3, 7, 3 },
                { 7, 5, 2, 7, 3 },
                { 4, 2, 7, 5, 2 },
                { 3, 5, 4, 2, 6 }
            };

        int result = ds.Calculate(array);

        Assert.AreEqual(7, result);
    }
}
