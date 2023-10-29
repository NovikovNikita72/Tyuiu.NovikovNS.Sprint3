using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint3.Task7.V19.Lib;

namespace Tyuiu.NovikovNS.Sprint3.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWA;
            valueWA = new double[len];
            valueWA[0] = 23.61;
            valueWA[1] = 16.08;
            valueWA[2] = 7.84;
            valueWA[3] = 4.58;
            valueWA[4] = 2.88;
            valueWA[5] = 0.75;
            valueWA[6] = -4.47;
            valueWA[7] = -9.46;
            valueWA[8] = -7.41;
            valueWA[9] = -6.16;
            valueWA[10] = -7.29;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWA, res);
        }
    }
}
