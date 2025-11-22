namespace Tyuiu.FilevaPA.Sprint4.Task7.V25.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;
public class DataService : ISprint4Task7V25
{
    public int Calculate(int n, int m, string value)
    {
        int[,] matrix = new int[n, m];
        int index = 0;

        // Преобразуем строку в матрицу n x m
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(value[index].ToString());
                index++;
            }
        }

        // Подсчитываем сумму четных чисел
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    sum += matrix[i, j];
                }
            }
        }

        return sum;
    }
}
