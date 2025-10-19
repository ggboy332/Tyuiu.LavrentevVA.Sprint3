using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.LavrentevVA.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string digits = "";
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
            }
            return digits.Length > 0 ? int.Parse(digits) : 0;
        }
    }
}
