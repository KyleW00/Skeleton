using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //creating a new instance for the class we want to create
            clsStaff AStaff = new clsStaff();
            //testing to see if the class actually exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void OnlineStaff()
        {
            //create a instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data
            Boolean TestData = true;
            //assign the data to the staff
            AStaff.Staff_Online = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Staff_Online, TestData);
        }

        [TestMethod]
        public void StaffDateAdded()
        {
            //create a instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the staff
            AStaff.Staff_Started = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Staff_Started, TestData);
        }

        [TestMethod]
        public void StaffSalary()
        {
            //create a instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data
            Double TestData = 1.24;
            //assign the data to the staff
            AStaff.Staff_Salary = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Staff_Salary, TestData);
        }
    }
}
