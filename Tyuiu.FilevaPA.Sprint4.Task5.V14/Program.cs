
namespace Tyuiu.FilevaPA.Sprint4.Task5.V14;
using Tyuiu.FilevaPA.Sprint4.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева П. А. | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы                                                *");
        Console.WriteLine("* Задание #5                                                             *");
        Console.WriteLine("* Вариант #14                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти количество положительных элементов в массиве 5x5.               *");
        Console.WriteLine("* Диапазон значений: от -5 до 7.                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        // Создаем и заполняем массив случайными числами
        int[,] matrix = new int[5, 5];
        Random random = new Random();

        Console.WriteLine("Сгенерированная матрица:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = random.Next(-5, 8); // от -5 до 7 включительно
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int result = ds.Calculate(matrix);

        Console.WriteLine($"Количество положительных элементов = {result}");

        // Детальный вывод
        Console.WriteLine("\nДетальный анализ:");
        Console.WriteLine("Строка | Положительные элементы");
        Console.WriteLine("--------------------------------");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"  {i + 1}    | ");
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > 0)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}