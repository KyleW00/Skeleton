using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer customer = new clsCustomer();
            Assert.IsNotNull(customer);
        }
    }
}
