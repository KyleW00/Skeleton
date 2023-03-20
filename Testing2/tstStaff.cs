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
        public void OnlineStaffOK()
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
        public void StaffDateAddedOK()
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
        public void StaffSalaryOK()
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

        [TestMethod]
        public void StaffIdentificationOK()
        {
            //create a instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the staff
            AStaff.Staff_Id = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Staff_Id, TestData);
        }

        [TestMethod]
        public void StaffNameOK()
        {
            //create a instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data
            String TestData = "Persons Name";
            //assign the data to the staff
            AStaff.Staff_Name = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Staff_Name, TestData);
        }

        [TestMethod]
        public void StaffRoleOK()
        {
            //create a instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data
            String TestData = "Manager";
            //assign the data to the staff
            AStaff.Staff_Role = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Staff_Role, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create a instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store results of validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Staff_Id = 21;
            //invoke the method
            Found = AStaff.Find(Staff_Id);
            //test to see if it is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaff_IdFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use in the method
            Int32 Staff_Id = 21;
            //invoke the method
            Found = AStaff.Find(Staff_Id);
            // check the staff id number
            if (AStaff.Staff_Id != 21)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaff_StartedFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use in the method
            Int32 Staff_Id = 21;
            //invoke the method
            Found = AStaff.Find(Staff_Id);
            // check the staff id number
            if (AStaff.Staff_Started != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaff_NameFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use in the method
            Int32 Staff_Id = 21;
            //invoke the method
            Found = AStaff.Find(Staff_Id);
            // check the staff id number
            if (AStaff.Staff_Name != "Dave")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaff_RoleFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use in the method
            Int32 Staff_Id = 21;
            //invoke the method
            Found = AStaff.Find(Staff_Id);
            // check the staff id number
            if (AStaff.Staff_Role != "Manager")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaff_SalaryFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use in the method
            Int32 Staff_Id = 21;
            //invoke the method
            Found = AStaff.Find(Staff_Id);
            // check the staff id number
            if (AStaff.Staff_Salary != 2.21)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaff_OnlineFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store results of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use in the method
            Int32 Staff_Id = 21;
            //invoke the method
            Found = AStaff.Find(Staff_Id);
            // check the staff id number
            if (AStaff.Staff_Online != false)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

    }
}
