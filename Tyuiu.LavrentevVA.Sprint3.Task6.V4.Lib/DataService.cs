using tyuiu.cources.programming.interfaces.Sprint3; 
namespace Tyuiu.LavrentevVA.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int i = 10; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        sum ++;
                    }
                }
            }
            return sum;
        }
    }
}
