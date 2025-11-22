namespace Tyuiu.FilevaPA.Sprint4.Task3.V14.Test;
using Tyuiu.FilevaPA.Sprint4.Task3.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева П. А. | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы                                                *");
        Console.WriteLine("* Задание #3                                                             *");
        Console.WriteLine("* Вариант #14                                                            *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти максимальный элемент в четвертой строке массива                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = {
                { 3, 2, 3, 3, 5 },
                { 2, 3, 3, 7, 3 },
                { 7, 5, 2, 7, 3 },
                { 4, 2, 7, 5, 2 },
                { 3, 5, 4, 2, 6 }
            };

        Console.WriteLine("Массив 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int result = ds.Calculate(array);

        Console.WriteLine($"Максимальный элемент в четвертой строке = {result}");

        Console.ReadKey();
    }
}