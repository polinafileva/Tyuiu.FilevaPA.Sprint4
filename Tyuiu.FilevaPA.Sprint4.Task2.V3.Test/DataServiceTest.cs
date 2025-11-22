namespace Tyuiu.FilevaPA.Sprint4.Task2.V3.Test;
using Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib.DataService ds = new Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib.DataService();

        int[] array = { 2, 4, 6, 2, 4, 6, 2, 4, 6, 2, 4, 6 };
        int result = ds.Calculate(array);

        Assert.AreEqual(48, result);
    }
}
