using Tyuiu.ShindinDN.Sprint4.Task7.V18.Lib;

namespace Tyuiu.ShindinDN.Sprint4.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "145258749635789";
            int res = ds.Calculate(n, m, value);
            int wait = 12288;
            Assert.AreEqual(wait, res);
        }
    }
}