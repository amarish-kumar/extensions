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
            Assert.AreEqual("extension",obj1.getFirstValue());
        }
        [TestMethod]
        public void Class2Test()
        {
            var obj2 = new internalClass.secondClass();
            Assert.AreEqual("smith", obj2.getSecondValue());
        }
        [TestMethod]
        public void Class3Test()
        {
            var type = typeof (internalClass.secondClass).GetNestedType("thirdClass", BindingFlags.NonPublic);
            var methodInfo = type.GetMethod("getThirdValue", BindingFlags.NonPublic | BindingFlags.Instance);
            var obj3 = Activator.CreateInstance(type);
            Assert.AreEqual("dave",methodInfo.Invoke(obj3,null));
        }
        [TestMethod]
        public void Class1ExtensionTest()
        {
            var obj1 = new internalClass();
            Assert.AreEqual("EXTENSION", obj1.getFirstValueUpper());
        }
        [TestMethod]
        public void Class2ExtensionTest()
        {
            var obj2 = new internalClass.secondClass();
            Assert.AreEqual("SMITH", obj2.getSecondValueUpper());
        }
        [TestMethod]
        public void Class3ExtensionTest()
        {
            var type = typeof(internalClass.secondClass).GetNestedType("thirdClass", BindingFlags.NonPublic);
            var methodInfo = type.GetMethod("getThirdValue", BindingFlags.NonPublic | BindingFlags.Instance);
            var obj3 = Activator.CreateInstance(type);
            Assert.AreEqual("DAVE", obj3.getThirdValueUpper());
        }
        [TestMethod]
        public void baseClassTest()
        {
            var obj0 = new internalClass();
            Assert.AreEqual("rahul",obj0.getFirstName());
            Assert.AreEqual("RAHUL", obj0.getBaseStringUpper());
        }
        [TestMethod]
        public void Class2OverrideTest()
        {
            var obj0 = new internalClass.secondClass();
            //Below assertion will fail, as this is overriden
            /*Assert.AreEqual("abc", obj0.getFirstName());
            Assert.AreEqual("ABC", obj0.getBaseStringUpper());*/
            Assert.AreEqual("John", obj0.getFirstName());
            Assert.AreEqual("JOHN", obj0.getBaseStringUpper());
        }
    }
}
