using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.LavrentevVA.Sprint3.Task5.V24.Lib
{
    public class DataService : ISprint3Task5V24
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    sum += (Math.Pow(x, j) + 2)*Math.Sin(j);
                }

            }
            return Math.Round(sum, 3);
        }
    }
}
