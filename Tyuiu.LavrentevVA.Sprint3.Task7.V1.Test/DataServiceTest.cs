using Tyuiu.LavrentevVA.Sprint3.Task7.V1.Lib;
namespace Tyuiu.LavrentevVA.Sprint3.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueMaitArray;
            valueMaitArray = new double[len];

            valueMaitArray[0] = -12.18;
            valueMaitArray[1] = 16.03;
            valueMaitArray[2] = 18.87;
            valueMaitArray[3] = 4.96;
            valueMaitArray[4] = -9.99;
            valueMaitArray[5] = 0.00;
            valueMaitArray[6] = 2.16;
            valueMaitArray[7] = -7.54;
            valueMaitArray[8] = -22.76;
            valueMaitArray[9] = -20.45;
            valueMaitArray[10] = 7.77;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueMaitArray, res);
        }
    }
}
