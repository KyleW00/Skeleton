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
    }
}
