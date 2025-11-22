namespace Tyuiu.FilevaPA.Sprint4.Task2.V3.Test;
using Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #2                                                           *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                 *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов      *");
        Console.WriteLine("* заполненный случайными значениями от 2 до 7.            *");
        Console.WriteLine("* Подсчитать сумму четных элементов массива.              *");
        Console.WriteLine("************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                         *");
        Console.WriteLine("************************************************************");

        int[] array = new int[12];
        Random rand = new Random();

        Console.Write("Массив: [");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(2, 8);
            Console.Write(array[i]);
            if (i < array.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");

        Console.WriteLine("************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
        Console.WriteLine("************************************************************");

        Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib.DataService ds = new Tyuiu.FilevaPA.Sprint4.Task2.V3.Lib.DataService();
        int result = ds.Calculate(array);

        Console.WriteLine("Сумма четных элементов = " + result);

        Console.ReadKey();
    }
}