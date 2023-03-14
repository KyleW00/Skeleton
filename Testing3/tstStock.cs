using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }
        [TestMethod]
        public void StockId()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the stock
            AStock.StockId = TestData;
            //test to see that it exists
            Assert.AreEqual(AStock.StockId, TestData);
        }
        [TestMethod]
        public void ActiveInStock()
        {
            //create instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data
            Boolean TestData = true;
            //assign the data to the stock
            AStock.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.Active, TestData);
        }
        [TestMethod]
        public void DateAddedStock()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the Stock
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the propert
            AStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DateAdded, TestData);
        }
        [TestMethod]
        public void ProductNameStock()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the Stock
            String TestData = "Hplaptop";
            //assign the data to the property
            AStock.ProductName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStock.ProductName, TestData);
        }
        [TestMethod]
        public void ProductQuantityStock()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the Stock
            Int32 TestData = 1;
            //assign the data to the property
            AStock.ProductQuantity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStock.ProductQuantity, TestData);
        }
        [TestMethod]
        public void ProductCostStock()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the Stock
            decimal TestData = 1;
            //assign the data to the property
            AStock.ProductCost = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStock.ProductCost, TestData);
        }
    }
}
