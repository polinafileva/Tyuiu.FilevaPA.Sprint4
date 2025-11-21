namespace Tyuiu.FilevaPA.Sprint4.Task1.V7.Test;
using Tyuiu.FilevaPA.Sprint4.Task1.V7.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
        int result = ds.Calculate(array);

        // Проверка: 2 + 8 + 2 + 6 + 2 + 4 = 24
        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void ValidCalculateNoEvenNumbers()
    {
        DataService ds = new DataService();

        int[] array = { 1, 3, 5, 7, 1, 3, 5, 7, 1, 3, 5 };
        int result = ds.Calculate(array);

        // Если нет четных чисел - должен вернуть 0
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ValidCalculateAllEven()
    {
        DataService ds = new DataService();

        int[] array = { 2, 4, 6, 8, 2, 4, 6, 8, 2, 4, 6 };
        int result = ds.Calculate(array);

        // Все элементы четные
        Assert.AreEqual(52, result);
    }

    [TestMethod]
    public void ValidCalculateEmptyArray()
    {
        DataService ds = new DataService();

        int[] array = new int[0];
        int result = ds.Calculate(array);

        // Пустой массив - должен вернуть 0
        Assert.AreEqual(0, result);
    }
}
