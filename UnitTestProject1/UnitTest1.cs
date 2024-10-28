using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
namespace ConsoleApp2Tests
{
    [TestClass]
    public class GeometricProgressionTests
    {
        [TestMethod]
        public void Indexer_ValidIndex_ReturnsCorrectValue()
        {
            var gp = new GeometricProgression();
            gp.Input(2, 3); // b = 2, q = 3

            var result = gp[3]; // має повернути b * q^(3-1) = 2 * 3^2 = 18

            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void Indexer_InvalidIndex_ThrowsArgumentOutOfRangeException()
        {
            var gp = new GeometricProgression();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => gp[-1]);
        }

        [TestMethod]
        public void Sum_ValidN_ReturnsCorrectSum()
        {
            var gp = new GeometricProgression();
            gp.Input(2, 2); // b = 2, q = 2

            var result = gp.Sum(3); // має повернути b * (1 - q^n) / (1 - q) = 2 * (1 - 2^3) / (1 - 2) = 14

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void Sum_InvalidN_ThrowsArgumentOutOfRangeException()
        {
            var gp = new GeometricProgression();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => gp.Sum(0));
        }

        [TestMethod]
        public void Sum_QIsOne_ReturnsCorrectSum()
        {
            var gp = new GeometricProgression();
            gp.Input(3, 1); // b = 3, q = 1

            var result = gp.Sum(4); // має повернути b * n = 3 * 4 = 12

            Assert.AreEqual(12, result);
        }
    }
}