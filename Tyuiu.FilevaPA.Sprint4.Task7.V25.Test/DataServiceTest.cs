namespace Tyuiu.FilevaPA.Sprint4.Task7.V25.Test;
using Tyuiu.FilevaPA.Sprint4.Task7.V25.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int n = 4;
        int m = 3;
        string value = "348561792486";
        int result = ds.Calculate(n, m, value);

        // Матрица 4x3:
        // 3 4 8
        // 5 6 1
        // 7 9 2
        // 4 8 6
        // Четные числа: 4, 8, 6, 2, 4, 8, 6
        // Сумма: 4+8+6+2+4+8+6 = 38
        Assert.AreEqual(38, result);
    }

    [TestMethod]
    public void ValidCalculate3x4()
    {
        DataService ds = new DataService();

        int n = 3;
        int m = 4;
        string value = "348561792486";
        int result = ds.Calculate(n, m, value);

        // Матрица 3x4:
        // 3 4 8 5
        // 6 1 7 9
        // 2 4 8 6
        // Четные числа: 4, 8, 6, 2, 4, 8, 6
        // Сумма: 4+8+6+2+4+8+6 = 38
        Assert.AreEqual(38, result);
    }

    [TestMethod]
    public void ValidCalculate2x6()
    {
        DataService ds = new DataService();

        int n = 2;
        int m = 6;
        string value = "348561792486";
        int result = ds.Calculate(n, m, value);

        // Матрица 2x6:
        // 3 4 8 5 6 1
        // 7 9 2 4 8 6
        // Четные числа: 4, 8, 6, 2, 4, 8, 6
        // Сумма: 4+8+6+2+4+8+6 = 38
        Assert.AreEqual(38, result);
    }

    [TestMethod]
    public void ValidCalculateNoEven()
    {
        DataService ds = new DataService();

        int n = 2;
        int m = 2;
        string value = "1357"; // Все нечетные
        int result = ds.Calculate(n, m, value);

        Assert.AreEqual(0, result);
    }
}
