namespace Tyuiu.FilevaPA.Sprint4.Task1.V7.Test;
using Tyuiu.FilevaPA.Sprint4.Task1.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #1                                                             *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов. Подсчитать сумму  *");
        Console.WriteLine("* четных элементов массива.                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };

        Console.WriteLine("Массив: [2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4]");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int result = ds.Calculate(array);

        Console.WriteLine($"Сумма четных элементов массива = {result}");

        // Детальный вывод расчета
        Console.WriteLine("\nДетальный расчет:");
        Console.WriteLine("Четные элементы: 2, 8, 2, 6, 2, 4");
        Console.WriteLine("Сумма: 2 + 8 + 2 + 6 + 2 + 4 = 24");

        Console.ReadKey();
    }
}