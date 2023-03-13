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
    }
}
