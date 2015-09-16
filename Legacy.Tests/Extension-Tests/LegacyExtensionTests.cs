using System;
using ExtensionMethods.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.Tests.Extension_Tests
{
    [TestClass]
    public class LegacyExtensionTests
    {
        //Test to check wheteher date is of 20th century
        [TestMethod]
        public void ToLegacyDate_C20()
        {
            var dateTime = new DateTime(1920, 05, 19);
            //1st zero tells 20th century date
            Assert.AreEqual("0200519",dateTime.ToLegacyDate());
        }

        //Test to check wheteher date is of 20th century
        [TestMethod]
        public void ToLegacyDate_C21()
        {
            var dateTime = new DateTime(1983, 05, 19);
            //1st 1 tells 20th century date
            Assert.AreEqual("1830519", dateTime.ToLegacyDate());
        }

        //Test to Reverse the name
        [TestMethod]
        public void ToLegacyName()
        {
            var name = "Rahul Sahay";
            Assert.AreEqual("SAHAY, RAHUL",name.ToLegacyName());
        }

        //Test XML DateTime
        [TestMethod]
        public void ToXMLDateTime()
        {
            var dateTime = new DateTime(2015, 09, 16, 12, 50, 45, 345);
            //Assert will check the UTC Date
            Assert.AreEqual("2015-09-16T12:50:45.345Z",dateTime.ToXMLDateTime());

        }
    }
}
