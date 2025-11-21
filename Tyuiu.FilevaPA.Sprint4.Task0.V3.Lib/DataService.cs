namespace Tyuiu.FilevaPA.Sprint4.Task0.V3.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;
public class DataService : ISprint4Task0V3
{
    public int GetMultOddArrEl(int[] array)
    {
        int product = 1;
        bool foundOdd = false;

        foreach (int num in array)
        {
            if (num % 2 != 0) // Проверка на нечетность
            {
                product *= num;
                foundOdd = true;
            }
        }

        return foundOdd ? product : 0; // Если нечетных нет – возвращаем 0
    }
}
