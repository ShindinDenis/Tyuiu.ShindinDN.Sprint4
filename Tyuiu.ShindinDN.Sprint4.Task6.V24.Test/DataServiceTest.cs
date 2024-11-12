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
            var l = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            string[] res = ds.Calculate(l);
            string[] wait = { "Компьютер", "Клавиатура" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}