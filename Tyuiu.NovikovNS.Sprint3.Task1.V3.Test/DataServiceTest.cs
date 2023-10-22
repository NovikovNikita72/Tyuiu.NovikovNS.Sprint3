using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint3.Task1.V3.Lib;

namespace Tyuiu.NovikovNS.Sprint3.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 28.309;
            Assert.AreEqual(wait, res);
        }
    }
}
