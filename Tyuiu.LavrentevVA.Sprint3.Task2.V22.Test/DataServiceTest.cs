using Tyuiu.LavrentevVA.Sprint3.Task2.V22.Lib;

namespace Tyuiu.LavrentevVA.Sprint3.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}

