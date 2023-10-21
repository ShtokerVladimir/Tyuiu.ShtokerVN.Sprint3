using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint3.Task2.V20.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 7218.973;

            Assert.AreEqual(wait, res);
        }
    }
}
