using Tyuiu.ShindinDN.Sprint4.Task5.V20.Lib;

namespace Tyuiu.ShindinDN.Sprint4.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { -7, -7, -1, -5, -3}, 
                                           { 3, -2, -5, 1, 2 }, 
                                           { -4, 1, -4, 1, 3 }, 
                                           { -3, 1, -2, 3, 3 }, 
                                           { -2, 1, -5, 2, 1 } };
            int result = ds.Calculate(array);
            int wait = 22;
            Assert.AreEqual(result, wait);
        }
    }
}