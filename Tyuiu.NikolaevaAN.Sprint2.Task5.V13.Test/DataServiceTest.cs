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
            int g = 2000, m = 03, n = 29;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "30.03.2000";
            Assert.AreEqual(wait, res);
        }
    }
}
