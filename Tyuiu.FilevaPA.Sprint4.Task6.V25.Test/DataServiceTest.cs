namespace Tyuiu.FilevaPA.Sprint4.Task6.V25.Test;
using Tyuiu.FilevaPA.Sprint4.Task6.V25.Lib;


    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        DataService ds = new DataService();

        string[] array = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

        int result = ds.Calculate(array);

        // Элементы с длиной > 6: "Баскетбол"(9), "Бейсбол"(8) = 2 элемента
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ValidCalculateAllShort()
    {
        DataService ds = new DataService();

        string[] array = { "Тен", "Фут", "Кри", "Бас", "Бей", "Рег", "Хок" };

        int result = ds.Calculate(array);

        // Все элементы короче 6 символов
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ValidCalculateAllLong()
    {
        DataService ds = new DataService();

        string[] array = { "Теннисист", "Футболист", "Крикетист", "Баскетболист", "Бейсболист", "Регбист", "Хоккеист" };

        int result = ds.Calculate(array);

        // Все элементы длиннее 6 символов
        Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void ValidCalculateEmpty()
    {
        DataService ds = new DataService();

        string[] array = new string[0];

        int result = ds.Calculate(array);

        // Пустой массив
        Assert.AreEqual(0, result);
    }
    }

