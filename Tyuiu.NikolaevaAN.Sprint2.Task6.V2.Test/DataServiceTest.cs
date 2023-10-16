using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint2.Task6.V2.Lib;

namespace Tyuiu.NikolaevaAN.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();
            int m = 12;
            string res = ds.FindMonthSeason(m);
            string wait = "Зима";
            Assert.AreEqual(wait, res);
        }
    }
}
