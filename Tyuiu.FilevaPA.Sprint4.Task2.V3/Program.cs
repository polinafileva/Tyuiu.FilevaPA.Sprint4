namespace Tyuiu.FilevaPA.Sprint4.Task2.V3.Test;
using Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева П. А. | ИСПБ-25-1";

        Console.WriteLine("************************************************************");
        Console.WriteLine("* Спринт #4                                                *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                 *");
        Console.WriteLine("* Задание #2                                              *");
        Console.WriteLine("* Вариант #3                                               *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1         *");
        Console.WriteLine("************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                 *");
        Console.WriteLine("* Подсчитать сумму четных элементов массива               *");
        Console.WriteLine("************************************************************");

        int[] array = { 2, 5, 3, 6, 2, 7, 4, 3, 6, 5, 4, 7 };

        Console.WriteLine("Массив: [2, 5, 3, 6, 2, 7, 4, 3, 6, 5, 4, 7]");

        Console.WriteLine("************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
        Console.WriteLine("************************************************************");

        DataService ds = new DataService();
        int result = ds.Calculate(array);

        Console.WriteLine("Сумма четных элементов = " + result);

        Console.ReadKey();
    }
}