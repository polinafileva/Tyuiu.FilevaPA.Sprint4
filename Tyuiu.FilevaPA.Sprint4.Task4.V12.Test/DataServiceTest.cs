namespace Tyuiu.FilevaPA.Sprint4.Task4.V12.Test;
using Tyuiu.FilevaPA.Sprint4.Task4.V12.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int[,] matrix = {
                { 3, 6, 6, 8, 8 },
                { 2, 7, 2, 4, 6 },
                { 3, 6, 2, 6, 4 },
                { 8, 6, 2, 7, 3 },
                { 8, 7, 6, 6, 6 }
            };

        int[,] result = ds.Calculate(matrix);

        // Проверяем, что четные элементы заменены на 1
        Assert.AreEqual(3, result[0, 0]);  // 3 (нечетное) → остается 3
        Assert.AreEqual(1, result[0, 1]);  // 6 (четное) → заменяется на 1
        Assert.AreEqual(1, result[0, 2]);  // 6 (четное) → заменяется на 1
        Assert.AreEqual(1, result[0, 3]);  // 8 (четное) → заменяется на 1
        Assert.AreEqual(1, result[0, 4]);  // 8 (четное) → заменяется на 1
    }
}
