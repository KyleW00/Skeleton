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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Boolean variable to store the resultsof the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockId = 12;
            Found = AStock.Find(StockId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStockFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean varaible to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 12;
            //invoke the emthod
            Found = AStock.Find(StockId);
            //check the stock number
            if (AStock.StockId != 12)
            {
                OK = false;
            }
            //test t osee that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
