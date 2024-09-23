using Tyuiu.MiliukovLO.Sprint2.Task1.V24.Lib;

namespace Tyuiu.MiliukovLO.Sprint2.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            var dataService = new DataService();
            Assert.AreEqual([true, false, true, false, true, false], dataService.GetLogicOperations(325,325,242,324));
        }
    }
}