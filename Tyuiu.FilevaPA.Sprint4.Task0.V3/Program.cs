namespace Tyuiu.FilevaPA.Sprint4.Task0.V3;
using Tyuiu.FilevaPA.Sprint4.Task0.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный       *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать произведение *");
        Console.WriteLine("* нечетных элементов массива. {8, 9, 4, 1, 2, 3, 4, 5, 6, 7}            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int result = ds.GetMultOddArrEl(array);

        Console.WriteLine($"Произведение нечетных элементов массива = {result}");

        // Детальный вывод расчета
        Console.WriteLine();
        Console.WriteLine("Детальный расчет:");
        Console.WriteLine("Индекс | Элемент | Нечетный? | Текущее произведение");
        Console.WriteLine("---------------------------------------------------");

        int currentProduct = 1;
        for (int i = 0; i < array.Length; i++)
        {
            bool isOdd = array[i] % 2 != 0;

            if (isOdd)
            {
                int oldProduct = currentProduct;
                currentProduct *= array[i];
                Console.WriteLine($"  {i,2}   |    {array[i],2}    |     Да     | {oldProduct} × {array[i]} = {currentProduct}");
            }
            else
            {
                Console.WriteLine($"  {i,2}   |    {array[i],2}    |     Нет    | {currentProduct} (без изменений)");
            }
        }

        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine($"Итоговое произведение: {result}");

        Console.ReadKey();
    }

    private static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}