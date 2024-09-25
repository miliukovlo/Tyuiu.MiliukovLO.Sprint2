using Tyuiu.MiliukovLO.Sprint2.Task6.V13.Lib;

namespace Tyuiu.MiliukovLO.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual("1.1.2", dataService.FindDateOfNextDay(1, 1, 1));
        }
    }
}