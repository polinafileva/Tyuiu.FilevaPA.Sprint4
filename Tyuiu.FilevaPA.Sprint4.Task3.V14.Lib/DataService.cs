namespace Tyuiu.FilevaPA.Sprint4.Task3.V14.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;
public class DataService : ISprint4Task3V14
{
    public int Calculate(int[,] array)
    {
        int max = array[3, 0]; // Начинаем с первого элемента четвертой строки

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[3, j] > max)
            {
                max = array[3, j];
            }
        }

        return max;
    }
}
