using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        String Email = "example@gmail.com";
        String Password = "1234";
        String DateOfBirth = DateTime.Now.Date.ToString();
        String Address = "some street";
        String ContactNumber = "9876553";

        /*  [TestMethod]
          public void InstanceOK()
          {
              clsCustomer customer = new clsCustomer();
              Assert.IsNotNull(customer);
          }*/

        [TestMethod]
        public void ActiveStatusProperty()
        {
            clsCustomer customer = new clsCustomer();
            Boolean TestData = true;
            customer.Active = TestData;
            Assert.AreEqual(customer.Active, TestData);
        }
        [TestMethod]
        public void DateOfBirthProperty()
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
        public void AddressProperty()
        {
            clsCustomer customer = new clsCustomer();
            string TestData = "22 London Road";
            customer.Address = TestData;
            Assert.AreEqual(customer.Address, TestData);
        }
        [TestMethod]
        public void EmailProperty()
        {
            clsCustomer customer = new clsCustomer();
            string TestData = "marcus@gmail.com";
            customer.Email = TestData;
            Assert.AreEqual(customer.Email, TestData);
        }

        [TestMethod]
        public void PasswordProperty()
        {
            clsCustomer customer = new clsCustomer();
            string TestData = "marcus2001";
            customer.Password = TestData;
            Assert.AreEqual(customer.Password, TestData);
        }
        [TestMethod]
        public void ContactNumberProperty()
        {
            clsCustomer customer = new clsCustomer();
            String TestData = "07659955421";
            customer.ContactNumber = TestData;
            Assert.AreEqual(customer.ContactNumber, TestData);
        }
        [TestMethod]
        public void CustomerIDProperty()
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
            Int32 customerID = 1;
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
            Int32 customerID = 1;
            //invoking the method
            Found = customer.Find(customerID);
            //checking the customerID
            if (customer.CustomerID != 1)
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
            Int32 customerID = 1;
            //invoking the method
            Found = customer.Find(customerID);
            //checking the customerID
            if (customer.DateAdded != Convert.ToDateTime("01/01/2001"))
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
            Int32 customerID = 1;
            //invoking the method
            Found = customer.Find(customerID);
            //checking the customerID
            if (customer.Email != "marcus@gmail.com")
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
            Int32 customerPassword = 1;
            //invoking the method
            Found = customer.Find(customerPassword);
            //checking the customerID
            if (customer.Password != "marcus2001")
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
            Int32 customerAddress = 1;
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
            Int32 customerContactNumber = 1;
            //invoking the method
            Found = customer.Find(customerContactNumber);
            //checking the customerID
            if (customer.ContactNumber != "07659955421")
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
            Int32 customerContactNumber = 1;
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        //Email Testing 
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Email = "a";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusONe()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Email = "aa";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxLessONe()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(49, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(50, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(25, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(51, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(500, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }
        //Date added Testing 
        [TestMethod]
        public void CustomerDateAddedExtremeMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfBirth = TestDate.ToString();
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateAddedMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateOfBirth = TestDate.ToString();
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateAddedMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfBirth = TestDate.ToString();
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateAddedMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfBirth = TestDate.ToString();
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateAddeExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfBirth = TestDate.ToString();
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateAddedInvalidData()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string DateOfBirth = "this is not a date!";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        //Address Testing
        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Address = "";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Address = "a";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Address = "aa";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(49, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(50, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(51, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(500, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }
        //password testing
        [TestMethod]
        public void CustomerPasswordMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Password = "";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Password = "aaaaaa";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Password = "aaaaaaa";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(49, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(50, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(51, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(25, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String Password = "";
            Password = Password.PadRight(500, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        //contact number testing
        [TestMethod]
        public void CustomerContactNumberMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerContactNumberMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string ContactNumber = "aaaaaa";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerContactNumberMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string ContactNumber = "aaaaaaa";
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerContactNumberMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(49, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerContactNumberMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(50, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerContactNumberMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(51, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerContactNumberMid()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(25, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerContactNumberExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            String ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(500, 'a');
            Error = customer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

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
       /* [TestMethod]
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
        }*/
    }
}

