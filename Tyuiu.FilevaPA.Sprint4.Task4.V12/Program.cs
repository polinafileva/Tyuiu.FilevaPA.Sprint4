namespace Tyuiu.FilevaPA.Sprint4.Task4.V12.Test;
using Tyuiu.FilevaPA.Sprint4.Task4.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева П. А. | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы                                                *");
        Console.WriteLine("* Задание #4                                                           *");
        Console.WriteLine("* Вариант #12                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Заменить четные элементы массива на 1.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] matrix = {
                { 3, 6, 6, 8, 8 },
                { 2, 7, 2, 4, 6 },
                { 3, 6, 2, 6, 4 },
                { 8, 6, 2, 7, 3 },
                { 8, 7, 6, 6, 6 }
            };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int[,] result = ds.Calculate(matrix);

        Console.WriteLine("Матрица после замены четных элементов на 1:");
        PrintMatrix(result);

        Console.ReadKey();
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}