using Tyuiu.MiliukovLO.Sprint2.Task3.V21.Lib;

namespace Tyuiu.MiliukovLO.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual(242, 2);
        }
    }
}