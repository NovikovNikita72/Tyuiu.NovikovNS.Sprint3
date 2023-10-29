using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint3.Task6.V26.Lib;

namespace Tyuiu.NovikovNS.Sprint3.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 15;
            int stopValue = 22;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 33;
            Assert.AreEqual(wait, res);
        }
    }
}
