namespace Tyuiu.FilevaPA.Sprint4.Task6.V25.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;
public class DataService : ISprint4Task6V25
{
    public int Calculate(string[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length > 6)
            {
                count++;
            }
        }

        return count;
    }
}
