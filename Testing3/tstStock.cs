using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
        String StockName = "Stock21";
        String StockQuantity = "210";
        String StockCost = "21.01";
        String DateAdded = DateTime.Now.Date.ToString();

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
        public void InStockProperty()
        {
            //create instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data
            Boolean TestData = true;
            //assign the data to the stock
            AStock.InStock = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.InStock, TestData);
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
            Int32 StockId = 1;
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
            Int32 StockId = 1;
            //invoke the emthod
            Found = AStock.Find(StockId);
            //check the stock number
            if (AStock.StockId != 1)
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
            Int32 StockId = 1;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.DateAdded != Convert.ToDateTime("10/01/2022"))
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
            Int32 StockId = 1;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.StockName != "Stock1")
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
            Int32 StockId = 1;
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
            Int32 StockId = 1;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.StockQuantity != 100)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the property
            if (AStock.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockName = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMin()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockName = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockName = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMax()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMid()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                ""; //this should fail
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockName = "";
            StockName = StockName.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a varable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a varable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a varable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a varable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a varable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            String DateAdded = "this is not a date!";
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockCostExtremeMin()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Decimal TestValue = -100000;
            String StockCost = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockCostMinLessOne()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Decimal TestValue = -1;
            String StockCost = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockCostMin()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Decimal TestValue = 0;
            String StockCost = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCostMinPlusOne()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Decimal TestValue = 1;
            String StockCost = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCostMaxLessOne()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Decimal TestValue = 99999;
            String StockCost = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCostMax()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Decimal TestValue = 100000;
            String StockCost = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCostMaxPlusOne()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Decimal TestValue = 100001;
            String StockCost = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockCostMid()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StockCost = "50000"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCostExtremeMax()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Decimal TestValue = 90000000;
            String StockCost = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockCostInvalidData()
        {
            //creates instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            String StockCost = "this is not a salary";
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestValue = -1;
            String StockQuantity = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMin()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestValue = 0;
            String StockQuantity = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestValue = 1;
            String StockQuantity = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxLessOne()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestValue = 999;
            String StockQuantity = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMax()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestValue = 1000;
            String StockQuantity = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxPlusOne()
        {
            //create instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestValue = 1001;
            String StockQuantity = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMid()
        {
            // create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestValue = 500;
            //create some test data to pass to the method
            String StockQuantity = TestValue.ToString();
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityExtremeMax()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestValue = 10000;
            String StockQuantity = TestValue.ToString();
            // invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityInvalidData()
        {
            //creates instance of the class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            String StockQuantity = "this is not a stock Quantity";
            //invoke the method
            Error = AStock.Valid(StockName, StockQuantity, StockCost, DateAdded);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockInstanceOk()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {   //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.StockId = 1;
            TestItem.StockName = "Stock1";
            TestItem.StockQuantity = 1;
            TestItem.StockCost = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
           // AllStock.StockList = TestList;
            //test to see that the two values are the same
            //Assert.AreEqual(AllStock.StockList, TestList);

        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
          //  AllStock.Count = SomeCount;
            //test to see that the two values are the same
          //  Assert.AreEqual(AllStock.Count, SomeCount);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.InStock = true;
            TestStock.StockId = 1;
            TestStock.StockName = "Stock1";
            TestStock.StockQuantity = 1;
            TestStock.StockCost = 1;
            TestStock.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            //AllStock.ThisStock = TestStock;
            //test to see that the two values ae the same
           // Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.StockId = 1;
            TestItem.StockName = "Stock1";
            TestItem.StockQuantity = 1;
            TestItem.StockCost = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            //AllStock.StockList = TestList;
            //test to see that the two values are the same
           // Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        


    }
}
