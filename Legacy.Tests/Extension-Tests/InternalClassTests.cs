using System;
using System.Reflection;
using ExtensionMethods.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.Tests.Extension_Tests
{
    [TestClass]
    public class InternalClassTests
    {
        [TestMethod]
        public void Class1Test()
        {
            var obj1 = new internalClass();
            Assert.AreEqual("a",obj1.getFirstValue());
        }
        [TestMethod]
        public void Class2Test()
        {
            var obj2 = new internalClass.secondClass();
            Assert.AreEqual("b", obj2.getSecondValue());
        }
        [TestMethod]
        public void Class3Test()
        {
            var type = typeof (internalClass.secondClass).GetNestedType("thirdClass", BindingFlags.NonPublic);
            var methodInfo = type.GetMethod("getThirdValue", BindingFlags.NonPublic | BindingFlags.Instance);
            var obj3 = Activator.CreateInstance(type);
            Assert.AreEqual("c",methodInfo.Invoke(obj3,null));
        }
        [TestMethod]
        public void Class1ExtensionTest()
        {
            var obj1 = new internalClass();
            Assert.AreEqual("A", obj1.getFirstValueUpper());
        }
        [TestMethod]
        public void Class2ExtensionTest()
        {
            var obj2 = new internalClass.secondClass();
            Assert.AreEqual("B", obj2.getSecondValueUpper());
        }
        [TestMethod]
        public void Class3ExtensionTest()
        {
            var type = typeof(internalClass.secondClass).GetNestedType("thirdClass", BindingFlags.NonPublic);
            var methodInfo = type.GetMethod("getThirdValue", BindingFlags.NonPublic | BindingFlags.Instance);
            var obj3 = Activator.CreateInstance(type);
            Assert.AreEqual("C", obj3.getThirdValueUpper());
        }
        [TestMethod]
        public void Class0Test()
        {
            var obj0 = new internalClass();
            Assert.AreEqual("abc",obj0.getString0());
            Assert.AreEqual("ABC", obj0.getString0Upper());
        }
        [TestMethod]
        public void Class2OverrideTest()
        {
            var obj0 = new internalClass.secondClass();
            //Below assertion will fail, as this is overriden
            /*Assert.AreEqual("abc", obj0.getString0());
            Assert.AreEqual("ABC", obj0.getString0Upper());*/
            Assert.AreEqual("xyz", obj0.getString0());
            Assert.AreEqual("XYZ", obj0.getString0Upper());
        }
    }
}
