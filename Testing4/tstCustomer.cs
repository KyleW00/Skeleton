using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer customer = new clsCustomer();
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void ActiveStatusCustomer()
        {
            clsCustomer customer = new clsCustomer();
            Boolean TestData = true;
            customer.Active = TestData;
            Assert.AreEqual(customer.Active, TestData);
        }
        [TestMethod]
        public void DateOfBirthCustomer()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            customer.DateAdded = TestData;
            Assert.AreEqual(customer.DateAdded, TestData);
        }
        [TestMethod]
        public void AddressCustomer()
        {
            clsCustomer customer = new clsCustomer();
            string TestData = "Wilberforce rd";
            customer.Address = TestData;
            Assert.AreEqual(customer.Address, TestData);
        }
        [TestMethod]
        public void EmailCustomer()
        {
            clsCustomer customer = new clsCustomer();
            string TestData = "Example@gmail.com";
            customer.Email = TestData;
            Assert.AreEqual(customer.Email, TestData);
        }

        [TestMethod]
        public void PasswordCustomer()
        {
            clsCustomer customer = new clsCustomer();
            string TestData = "example1234!";
            customer.Password = TestData;
            Assert.AreEqual(customer.Password, TestData);
        }
        [TestMethod]
        public void ContactNumberCustomer()
        {
            clsCustomer customer = new clsCustomer();
            String TestData = "97458844845";
            customer.ContactNumber = TestData;
            Assert.AreEqual(customer.ContactNumber, TestData);
        }
        [TestMethod]
        public void CustomerID()
        {
            clsCustomer customer = new clsCustomer();
            Int32 TestData = 1;
            customer.CustomerID = TestData;
            Assert.AreEqual(customer.CustomerID, TestData);
        }
        //week23
        [TestMethod]
        public void FindMethodOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //creating some test data to use with the method
            Int32 customerID = 21;
            Found = customer.Find(customerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDAddedFound()
        {
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creating some test data to use with the method
            Int32 customerID = 21;
            //invoking the method
            Found = customer.Find(customerID);
            //checking the customerID
            if (customer.CustomerID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creating some test data to use with the method
            Int32 customerID = 21;
            //invoking the method
            Found = customer.Find(customerID);
            //checking the customerID
            if (customer.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddedFound()
        {
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creating some test data to use with the method
            Int32 customerID = 21;
            //invoking the method
            Found = customer.Find(customerID);
            //checking the customerID
            if (customer.Email != "example@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPasswordAddedFound()
        {
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creating some test data to use with the method
            Int32 customerPassword = 21;
            //invoking the method
            Found = customer.Find(customerPassword);
            //checking the customerID
            if (customer.Password != "example1234!")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestAddressAddedFound()
        {
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creating some test data to use with the method
            Int32 customerAddress = 21;
            //invoking the method
            Found = customer.Find(customerAddress);
            //checking the customerID
            if (customer.Address != "22 London Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestContactNumberAddedFound()
        {
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creating some test data to use with the method
            Int32 customerContactNumber = 21;
            //invoking the method
            Found = customer.Find(customerContactNumber);
            //checking the customerID
            if (customer.ContactNumber != "07547799246")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveAddedFound()
        {
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creating some test data to use with the method
            Int32 customerContactNumber = 21;
            //invoking the method
            Found = customer.Find(customerContactNumber);
            //checking the customerID
            if (customer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}

