using Tyuiu.LavrentevVA.Sprint3.Task3.V17.Lib;
namespace Tyuiu.LavrentevVA.Sprint3.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "*vn98n! b,";

            double res = ds.ConvertStringToInt(str);

            int wait = 98;

            Assert.AreEqual(wait, res);
        }
    }
}
