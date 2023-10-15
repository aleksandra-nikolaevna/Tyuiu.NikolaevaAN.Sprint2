using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint2.Task4.V25.Lib;

namespace Tyuiu.NikolaevaAN.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 40;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 1.005;
            Assert.AreEqual(wait, res);
        }
    }
}
