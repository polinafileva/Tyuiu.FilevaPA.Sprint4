namespace Tyuiu.FilevaPA.Sprint4.Task2.V3.Test;
using Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int[] array = { 2, 5, 3, 6, 2, 7, 4, 3, 6, 5, 4, 7 };
        int result = ds.Calculate(array);

        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void ValidCalculateEmpty()
    {
        DataService ds = new DataService();

        int[] array = { };
        int result = ds.Calculate(array);

        Assert.AreEqual(0, result);
    }
}
