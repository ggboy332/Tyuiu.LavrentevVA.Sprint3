using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.LavrentevVA.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multseries = 1;
            while (startValue <= stopValue)
            {
                double numerator = 0.5 + (startValue / 5.0);
                double denominator = Math.Cos(value) + 0.5;
                multseries = multseries * Math.Pow(numerator / denominator, 3);
                startValue++;
            }
            return Math.Round(multseries, 3);
        }
    }
}
