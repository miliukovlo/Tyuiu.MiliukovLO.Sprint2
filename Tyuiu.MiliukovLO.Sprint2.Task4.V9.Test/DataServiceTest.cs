using Tyuiu.MiliukovLO.Sprint2.Task4.V9.Lib;

namespace Tyuiu.MiliukovLO.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(4, dataService.Calculate(3, 3));
        }
    }
}