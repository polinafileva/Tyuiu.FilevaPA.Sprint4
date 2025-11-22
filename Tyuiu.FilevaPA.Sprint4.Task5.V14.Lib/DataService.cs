namespace Tyuiu.FilevaPA.Sprint4.Task5.V14.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;
public class DataService : ISprint4Task5V14
{
    public int Calculate(int[,] matrix)
    {
        int count = 0;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
