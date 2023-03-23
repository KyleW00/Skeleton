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
        public void CountPropertyOK()
        {
            //Create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data
            Int32 SomeCount = 0;
            //assign the data to property
            AllStaff.Count = SomeCount;
            //test
            Assert.AreEqual(AllStaff.Count, SomeCount);
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


        }
}
