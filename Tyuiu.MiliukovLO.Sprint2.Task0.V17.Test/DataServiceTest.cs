using Tyuiu.MiliukovLO.Sprint2.Task0.V17.Lib;

namespace Tyuiu.MiliukovLO.Sprint2.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            var dataService = new DataService();
            Assert.AreEqual([false, true, false, false, false, false], dataService.GetCompareOperations(1022, 766));
        }
    }
}