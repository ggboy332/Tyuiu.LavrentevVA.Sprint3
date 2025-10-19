using Tyuiu.LavrentevVA.Sprint3.Task6.V4.Lib;
namespace Tyuiu.LavrentevVA.Sprint3.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 14;
            int stopValue = 20;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 8; 
            Assert.AreEqual(wait, res);
        }
    }
}
