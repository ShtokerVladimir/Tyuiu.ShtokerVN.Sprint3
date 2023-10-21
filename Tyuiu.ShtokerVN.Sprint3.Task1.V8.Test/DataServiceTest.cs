﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint3.Task1.V8.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 7;

            double asd = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 558.503;

            Assert.AreEqual(wait, asd);
        }
    }
}
