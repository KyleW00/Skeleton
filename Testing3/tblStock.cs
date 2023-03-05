using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tblStock
    {
        [TestMethod]
        public void tstStock()
        {
            //create an instance of the class we want to create
            clsStock StockId = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(StockId);
        }
        [TestMethod]
        public void InStock()
        {
            //create instance of the class we want to create
            clsStock InStock = new clsStock();
            //create some test data
            Boolean TestData = true;
            //assign the data to the stock
            InStock.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(InStock.Active, TestData);
        }
    }
}
