using Tyuiu.ShindinDN.Sprint4.Task6.V24.Lib;

namespace Tyuiu.ShindinDN.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var l = new string[] { "���������", "�������", "�������", "�������", "������", "�������", "����������" };
            string[] res = ds.Calculate(l);
            string[] wait = { "���������", "����������" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}