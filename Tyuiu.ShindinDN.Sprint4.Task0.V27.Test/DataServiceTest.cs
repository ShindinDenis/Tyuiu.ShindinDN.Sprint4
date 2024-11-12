using Tyuiu.ShindinDN.Sprint4.Task0.V27.Lib;

namespace Tyuiu.ShindinDN.Sprint4.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetMultOddArrEl(nums);
            int wait = 6615;
            Assert.AreEqual(res, wait);
        }
    }
}