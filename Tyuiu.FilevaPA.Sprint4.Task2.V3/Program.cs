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
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный       *");
        Console.WriteLine("* случайными значениями в диапазоне от 2 до 7. Подсчитать сумму четных   *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        // Создаем массив и заполняем случайными числами
        int[] array = new int[12];
        Random random = new Random();

        Console.WriteLine("Сгенерированный массив:");
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(2, 8); // От 2 до 7 включительно
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int result = ds.Calculate(array);

        Console.WriteLine($"Сумма четных элементов массива = {result}");

        // Детальный вывод расчета
        Console.WriteLine("\nДетальный расчет:");
        Console.WriteLine("Индекс | Элемент | Четный? | Текущая сумма");
        Console.WriteLine("------------------------------------------------");

        int currentSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isEven = array[i] % 2 == 0;

            if (isEven)
            {
                int oldSum = currentSum;
                currentSum += array[i];
                Console.WriteLine($"  {i,2}   |    {array[i],2}    |   Да    | {oldSum} + {array[i]} = {currentSum}");
            }
            else
            {
                Console.WriteLine($"  {i,2}   |    {array[i],2}    |   Нет   | {currentSum} (без изменений)");
            }
        }

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Итоговая сумма: {result}");

        Console.ReadKey();
    }
}