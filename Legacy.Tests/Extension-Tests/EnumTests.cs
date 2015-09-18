using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.Tests.Extension_Tests
{
    [TestClass]
    public class EnumTests
    {
        [TestMethod]
        public void getMoodule()
        {
            var module = Module.Order;
            Assert.AreEqual("Order", module.ToString());
            Assert.AreEqual("Order", Enum.GetName(typeof (Module), module));
        }
    }

    public enum Module
    {
        [System.ComponentModel.Description("Enum Methods")] Order,
        Chekout,
        Payment,
        Shipping
    }
}