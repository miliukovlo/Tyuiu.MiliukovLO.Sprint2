using Tyuiu.MiliukovLO.Sprint2.Task5.V14.Lib;

namespace Tyuiu.MiliukovLO.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual("�������", dataService.FindDayName(5,1));
        }
    }
}