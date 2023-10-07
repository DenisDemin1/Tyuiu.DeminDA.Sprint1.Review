using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DeminDA.Sprint0.Review.V11.Lib;

namespace Tyuiu.DeminDA.Sprint0.Review.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.751;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
