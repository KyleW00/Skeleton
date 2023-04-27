using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.Address = "some street";
            TestItem.ContactNumber = "123456789";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "example@gmail.com";
            TestItem.Password = "123abc";

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.Active = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.Address = "some street";
            TestCustomer.ContactNumber = "123456789";
            TestCustomer.DateAdded = DateTime.Now.Date;
            TestCustomer.Email = "example@gmail.com";
            TestCustomer.Password = "123abc";

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.Address = "some street";
            TestItem.CustomerID = 1;
            TestItem.ContactNumber = "123456789";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "example@gmail.com";
            TestItem.Password = "123abc";

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.Address = "some street";
            TestItem.ContactNumber = "123456789";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "example@gmail.com";
            TestItem.Password = "123abc";

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.Address = "some street";
            TestItem.ContactNumber = "123456789";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "example@gmail.com";
            TestItem.Password = "123abc";

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;

            TestItem.Active = false;
            TestItem.Address = "update street";
            TestItem.ContactNumber = "121111111";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "update@gmail.com";
            TestItem.Password = "123444444";

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }
}
