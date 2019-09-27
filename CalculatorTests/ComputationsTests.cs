using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class ComputationsTests
    {
        [TestMethod()]
        public void computeDistanceTest()
        {
            Computations computations = new Computations();
            double answer = computations.computeDistance(15.1981, -29.1068);
            Assert.AreEqual(32.5250, answer);
        }

        [TestMethod()]
        public void convertToDegreesTest()
        {
            Computations computations = new Computations();
            double answer = computations.convertToDegrees(0.942893362561167);
            Assert.AreEqual(32.5250, answer);
        }

        [TestMethod()]
        public void NanTest()
        {
            // 0.965025188464128 * 0.873714497436967
            //0.8431564976
            Computations computations = new Computations();
            decimal answer = (decimal)computations.convertToDegrees(Math.Acos(0.8431564976));
            Assert.AreEqual(12.415, answer);
        }

        [TestMethod()]
        public void computeCTest()
        {
            Computations computations = new Computations();
            double answer = computations.computeC(15.1981, computations.computeDistance(15.1981, -29.1068));
            Assert.AreEqual(115.214431518215, answer);
        }
    }
}