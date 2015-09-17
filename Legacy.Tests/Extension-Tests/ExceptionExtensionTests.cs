using System;
using System.Diagnostics;
using ExtensionMethods.ExceptionExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.Tests.Extension_Tests
{
    [TestClass]
    public class ExceptionExtensionTests
    {
        [TestMethod]
        public void DivideBy1()
        {
            Assert.AreEqual(7, Divide(7, 1));
        }
        [TestMethod]
        public void DivideBy0()
        {
            try
            {
                Divide(7, 0);
                Assert.Fail("Should throw exception");
            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex.Message);
                //Custom Message
                Debug.WriteLine(ex.CompleteMessage());
                Assert.IsInstanceOfType(ex,typeof(ApplicationException));
            }
        }

        public double Divide(int num, int denom)
        {
            try
            {
                return num/denom;
            }
            catch (Exception ex)
            {
                var invalidOp = new InvalidOperationException("Invalid Opeartion", ex);
                var message = string.Format("Divison Failed, numerator:{0}-denominator:{1}", num, denom);
                throw new ApplicationException(message,invalidOp);
            }
        }
    }
}
