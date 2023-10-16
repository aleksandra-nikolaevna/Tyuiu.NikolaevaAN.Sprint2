using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint2.Task5.V13.Lib;

namespace Tyuiu.NikolaevaAN.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2000, m = 12, n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "1.1.2001";
            Assert.AreEqual(wait, res);
        }
    }
}
