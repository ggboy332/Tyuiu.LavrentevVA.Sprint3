using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.LavrentevVA.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    y = 0;
                    count++;
                }
                else
                {
                    y = (Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2;
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }        
            }
            return valueArray;
        }
    }
}
