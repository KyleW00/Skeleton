using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data to assign to property
            // in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            // add a item to the list
            //create item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Staff_Id = 1;
            TestItem.Staff_Name = "Lewis";
            TestItem.Staff_Role = "Manager";
            TestItem.Staff_Started = DateTime.Now.Date;
            TestItem.Staff_Online = true;
            TestItem.Staff_Salary = 2.21;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //Create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data
            clsStaff TestStaff = new clsStaff();
            //set properties of test object
            TestStaff.Staff_Id = 1;
            TestStaff.Staff_Name = "Lewis";
            TestStaff.Staff_Role = "Manager";
            TestStaff.Staff_Started = DateTime.Now.Date;
            TestStaff.Staff_Online = true;
            TestStaff.Staff_Salary = 2.21;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data to assign to property
            // in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            // add a item to the list
            //create item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Staff_Id = 1;
            TestItem.Staff_Name = "Lewis";
            TestItem.Staff_Role = "Manager";
            TestItem.Staff_Started = DateTime.Now.Date;
            TestItem.Staff_Online = true;
            TestItem.Staff_Salary = 2.21;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of class you want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staff_Id = 27;
            TestItem.Staff_Name = "James";
            TestItem.Staff_Role = "Manager";
            TestItem.Staff_Started = DateTime.Now.Date;
            TestItem.Staff_Online = true;
            TestItem.Staff_Salary = 2.21;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.Staff_Id = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }


    }
}
