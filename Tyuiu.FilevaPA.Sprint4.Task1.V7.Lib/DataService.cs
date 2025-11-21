namespace Tyuiu.FilevaPA.Sprint4.Task1.V7.Lib;
    using tyuiu.cources.programming.interfaces.Sprint4;


public class DataService : ISprint4Task1V7

{
    public int Calculate(int[] array)
    {
        int sum = 0;

        foreach (int num in array)
        {
            if (num % 2 == 0) // Проверка на четность
            {
                sum += num;
            }
        }

        return sum;
    }
}

