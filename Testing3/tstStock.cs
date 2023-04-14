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
        public void StockIdProperty()
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
        public void ActiveProperty()
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
        public void DateAddedProperty()
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
        public void StockNameProperty()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the Stock
            String TestData = "Hplaptop";
            //assign the data to the property
            AStock.StockName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStock.StockName, TestData);
        }
        [TestMethod]
        public void StockQuantityProperty()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the Stock
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockQuantity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStock.StockQuantity, TestData);
        }
        [TestMethod]
        public void StockCostProperty()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the Stock
            decimal TestData = 1;
            //assign the data to the property
            AStock.StockCost = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStock.StockCost, TestData);
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
        public void TestStockIdFound()
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
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 12;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 12;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.StockName != "Test Stock Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockCostFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 12;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.StockCost != Convert.ToDecimal("10.01"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 12;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.StockQuantity != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 12;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }

}
