using Tyuiu.MiliukovLO.Sprint2.Task7.V1.Lib;

namespace Tyuiu.MiliukovLO.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new();
            Assert.AreEqual(true, dataService.CheckDotInShadedArea(0.03,-0.03));
        }
    }
}