using System;
using System.Linq;
using ExtensionMethods.Extensions;
using ExtensionMethods.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.Tests.Extension_Tests
{
    [TestClass]
    public class ReferenceDataSourceTests
    {
        //API Refernce Tests
        [TestMethod]
        public void GetItemsTests()
        {
            APIReferenceDataSource sourceItem;
            sourceItem = new APIReferenceDataSource();
            Assert.AreEqual(2,sourceItem.getItems().Count());
        }
    }
}
