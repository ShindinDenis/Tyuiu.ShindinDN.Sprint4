using Tyuiu.ShindinDN.Sprint4.Task2.V22.Lib;

namespace Tyuiu.ShindinDN.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 2, 5, 3, 4, 2, 5, 3, 1, 1, 5, 2, 3, 5 };
            int res = ds.Calculate(nums);
            int wait = 16875;
            Assert.AreEqual(res, wait);
        }
    }
}