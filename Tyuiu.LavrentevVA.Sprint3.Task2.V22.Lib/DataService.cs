using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.LavrentevVA.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumseries = 1;
            int i = startValue;
            do
            {
                double denominator = i + Math.Pow(value, -i);
                double term = Math.Pow(3.0 / denominator, 2);
                sumseries *= term;
                i++;
            } while (i <= stopValue);
            return Math.Round(sumseries, 3);
        }
    }
}