namespace Tyuiu.FilevaPA.Sprint4.Task7.V25.Test;
using Tyuiu.FilevaPA.Sprint4.Task7.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева П. А. | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Преобразование строки в матрицу                                  *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #25                                                           *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Преобразовать строку в матрицу n x m и подсчитать сумму четных чисел.  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int n = 4; // количество строк
        int m = 3; // количество столбцов
        string value = "348561792486";

        Console.WriteLine($"Количество строк (n) = {n}");
        Console.WriteLine($"Количество столбцов (m) = {m}");
        Console.WriteLine($"Строка для преобразования: \"{value}\"");
        Console.WriteLine($"Длина строки: {value.Length} символов");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int result = ds.Calculate(n, m, value);

        Console.WriteLine($"Сумма четных чисел в матрице {n}x{m} = {result}");

        // Детальный вывод преобразования
        Console.WriteLine("\nДетальный анализ:");
        Console.WriteLine($"Матрица {n}x{m}:");

        int[,] matrix = new int[n, m];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Строка {i + 1}: [ ");
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(value[index].ToString());
                Console.Write(matrix[i, j] + " ");
                index++;
            }
            Console.WriteLine("]");
        }

        // Подсчет четных чисел
        Console.WriteLine("\nЧетные числа в матрице:");
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    Console.WriteLine($"Позиция [{i + 1},{j + 1}]: {matrix[i, j]}");
                    sum += matrix[i, j];
                }
            }
        }

        Console.WriteLine($"\nСумма четных чисел: {sum}");

        Console.ReadKey();
    }
}