namespace Tyuiu.FilevaPA.Sprint4.Task6.V25.Test;
using Tyuiu.FilevaPA.Sprint4.Task6.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева П. А. | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Работа со строковыми массивами                                   *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #25                                                            *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив. Подсчитать количество элементов, длина которых   *");
        Console.WriteLine("* больше 6.                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string[] array = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int result = ds.Calculate(array);

        Console.WriteLine($"Количество элементов с длиной больше 6 = {result}");

        // Детальный вывод
        Console.WriteLine("\nДетальный анализ:");
        Console.WriteLine("Элемент        | Длина | > 6?");
        Console.WriteLine("-----------------------------");

        foreach (string element in array)
        {
            bool isLongerThan6 = element.Length > 6;
            Console.WriteLine($"{element,-14} | {element.Length,5} | {(isLongerThan6 ? "Да" : "Нет")}");
        }

        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Всего элементов: {array.Length}");
        Console.WriteLine($"Элементов с длиной > 6: {result}");

        Console.ReadKey();
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}