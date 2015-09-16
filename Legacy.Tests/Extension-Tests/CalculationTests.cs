using System;
using System.Threading;
using ExtensionMethods.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.Tests.Extension_Tests
{
    [TestClass]
    public class CalculationTests
    {
        //Test to check test runs for 1 sec around
        [TestMethod]
        public void GetTimeElapsed()
        {
            var calculations = new Calculations();
            calculations.Start();
            Thread.Sleep(800);
            Assert.AreEqual(1,calculations.GetElapsedTime());
        }
        //Test to check precise elapsed time
        [TestMethod]
        public void GetPreciseTimeElapsed()
        {
            var calculations = new Calculations();
            calculations.Start();
            Thread.Sleep(800);
            var elapsedTime = calculations.GetElapsedTime();
            Assert.IsTrue(elapsedTime>=0.75 || elapsedTime<0.90);
        }
    }
}
