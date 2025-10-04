using Tyuiu.LavrentevVA.Sprint3.Task0.V29.Lib;
namespace Tyuiu.LavrentevVA.Sprint3.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest

    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.004;

            Assert.AreEqual(wait, res);
        }
    }
}
