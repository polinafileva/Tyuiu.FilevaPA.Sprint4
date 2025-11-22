namespace Tyuiu.FilevaPA.Sprint4.Task5.V14.Test;
using Tyuiu.FilevaPA.Sprint4.Task5.V14.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int[,] matrix = {
                { -3,  2, -1,  5,  0 },
                {  4, -2,  7, -4,  1 },
                { -5,  3,  6, -3,  2 },
                {  0, -1,  4,  7, -2 },
                {  1,  5, -5,  3,  6 }
            };

        int result = ds.Calculate(matrix);

        // Положительные элементы: 2, 5, 4, 7, 1, 3, 6, 2, 4, 7, 1, 5, 3, 6 = 14
        Assert.AreEqual(14, result);
    }

    [TestMethod]
    public void ValidCalculateAllPositive()
    {
        DataService ds = new DataService();

        int[,] matrix = {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 1, 2, 3 },
                { 4, 5, 6, 7, 1 },
                { 2, 3, 4, 5, 6 },
                { 7, 1, 2, 3, 4 }
            };

        int result = ds.Calculate(matrix);

        // Все 25 элементов положительные
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void ValidCalculateNoPositive()
    {
        DataService ds = new DataService();

        int[,] matrix = {
                { -5, -4, -3, -2, -1 },
                { -1, -2, -3, -4, -5 },
                { -5, -4, -3, -2, -1 },
                { -1, -2, -3, -4, -5 },
                { -5, -4, -3, -2, -1 }
            };

        int result = ds.Calculate(matrix);

        // Нет положительных элементов
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ValidCalculateMixed()
    {
        DataService ds = new DataService();

        int[,] matrix = {
                { -1,  2, -3,  4, -5 },
                {  6, -7,  8, -9, 10 },
                { -1,  2, -3,  4, -5 },
                {  6, -7,  8, -9, 10 },
                { -1,  2, -3,  4, -5 }
            };

        int result = ds.Calculate(matrix);

        // Положительные: 2, 4, 6, 8, 10, 2, 4, 6, 8, 10, 2, 4 = 12
        Assert.AreEqual(12, result);
    }
}
