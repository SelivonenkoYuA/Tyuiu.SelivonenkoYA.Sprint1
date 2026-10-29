using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SelivonenkoYuA.Sprint1.Task0.V25.Lib;

namespace Tyuiu.SelivonenkoYuA.Sprint1.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
