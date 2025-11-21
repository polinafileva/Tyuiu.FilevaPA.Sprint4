namespace Tyuiu.FilevaPA.Sprint4.Task0.V3.Test;
using Tyuiu.FilevaPA.Sprint4.Task0.V3.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
        int result = ds.GetMultOddArrEl(array);

        // Проверка: 9 × 1 × 3 × 5 × 7 = 945
        Assert.AreEqual(945, result);
    }

    [TestMethod]
    public void ValidGetMultOddArrElNoOddNumbers()
    {
        DataService ds = new DataService();

        int[] array = { 2, 4, 6, 8, 0, 2, 4, 6, 8, 2 };
        int result = ds.GetMultOddArrEl(array);

        // Если нет нечетных чисел - должен вернуть 0
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ValidGetMultOddArrElSingleOdd()
    {
        DataService ds = new DataService();

        int[] array = { 2, 4, 3, 6, 8, 2, 4, 6, 8, 2 };
        int result = ds.GetMultOddArrEl(array);

        // Только один нечетный элемент 3
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void ValidGetMultOddArrElWithZero()
    {
        DataService ds = new DataService();

        int[] array = { 1, 0, 3, 2, 5, 4, 7, 6, 9, 8 };
        int result = ds.GetMultOddArrEl(array);

        // Нечетные: 1, 3, 5, 7, 9 → 1 × 3 × 5 × 7 × 9 = 945
        Assert.AreEqual(945, result);
    }
}
