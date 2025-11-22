namespace Tyuiu.FilevaPA.Sprint4.Task4.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;
public class DataService : ISprint4Task4V12
{
    public int[,] Calculate(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Создаем копию массива для изменений
        int[,] resultMatrix = (int[,])matrix.Clone();

        // Заменяем четные элементы на 1
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (resultMatrix[i, j] % 2 == 0)
                {
                    resultMatrix[i, j] = 1;
                }
            }
        }

        return resultMatrix;
    }
}
