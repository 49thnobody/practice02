using Microsoft.VisualStudio.TestTools.UnitTesting;
using practice02;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void TestMethodAverageNormal()
        {
            Data testData = new Data(new List<double> { 3d, 5d});

            Assert.AreEqual(testData.Average, 4);
        }

        [TestMethod]
        public void TestMethodAverageAllSame()
        {
            Data testData = new Data(new List<double> { 3d, 3d });

            Assert.AreEqual(testData.Average, 3);
        }

        [TestMethod]
        public void TestMethodAverageNegative()
        {
            Data testData = new Data(new List<double> { -3d, 3d });

            Assert.AreEqual(testData.Average, 0);
        }
    }
}
