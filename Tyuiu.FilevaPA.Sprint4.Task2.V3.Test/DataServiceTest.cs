namespace Tyuiu.FilevaPA.Sprint4.Task2.V3.Test;
using Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        // Тестовый массив с известными значениями
        int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4, 3 };
        int result = ds.Calculate(array);

        // Проверка: четные элементы: 2, 8, 2, 6, 2, 4
        // Сумма: 2 + 8 + 2 + 6 + 2 + 4 = 24
        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void ValidCalculateAllEven()
    {
        DataService ds = new DataService();

        int[] array = { 2, 4, 6, 2, 4, 6, 2, 4, 6, 2, 4, 6 };
        int result = ds.Calculate(array);

        // Все элементы четные
        Assert.AreEqual(48, result); // 2+4+6+2+4+6+2+4+6+2+4+6 = 48
    }

    [TestMethod]
    public void ValidCalculateNoEven()
    {
        DataService ds = new DataService();

        int[] array = { 3, 5, 7, 3, 5, 7, 3, 5, 7, 3, 5, 7 };
        int result = ds.Calculate(array);

        // Нет четных элементов
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ValidCalculateMixed()
    {
        DataService ds = new DataService();

        int[] array = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7 };
        int result = ds.Calculate(array);

        // Четные элементы: 2, 4, 6, 2, 4, 6
        // Сумма: 2 + 4 + 6 + 2 + 4 + 6 = 24
        Assert.AreEqual(24, result);
    }
}
