using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        // create some test data to pass to the method
        String Staff_Name = "Rodger";
        String Staff_Role = "Junior Developer";
        String Staff_Started = DateTime.Now.Date.ToString();
        String Staff_Online = "false";
        String Staff_Salary = "1.54";



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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_NameMinLessOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Name = ""; // this should fail
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_NameMin()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Name = "a"; // this should be ok
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_NameMinPlusOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Name = "ab"; // this should be ok
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_NameMaxLessOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Name = "abcdefghijacvbdsero"; // this should be ok
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_NameMax()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Name = "abcdefghijacvbdserol"; // this should be ok
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_NameMid()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Name = "aaaaaaaaaa"; // this should be ok
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_NameMaxPlusOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Name = "abcdefghijacvbdserols"; // this should fail
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_NameExtremeMax()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Name = "";
            Staff_Name = Staff_Name.PadRight(500, 'a'); // this should fail
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_StartedExtremeMin()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            // set date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String Staff_Started = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_StartedMinLessOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            // set date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String Staff_Started = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_StartedMin()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            // set date to todays date
            TestDate = DateTime.Now.Date;
            String Staff_Started = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_StartedMinPlusOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            // set date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String Staff_Started = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_StartedExtremeMax()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            // set date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String Staff_Started = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_StartedInvalidData()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Started = "this is not a date!!!";
            //invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMinLessOne()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Role = ""; // this should fail
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMin()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Role = "a"; // this should pass
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMinPlusOne()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Role = "aa"; // this should pass
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMaxLessOne()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Role = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // this should Pass
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMax()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Role = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // this should Pass
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMaxPlusOne()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Role = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // this should fail
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMid()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Role = "aaaaaaaaaaaaaaa"; // this should pass
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleExtremeMax()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Role = "";
            Staff_Role = Staff_Role.PadRight(500, 'a'); // this should fail
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryExtremeMin()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            Double TestValue = -1000000.47;
            String Staff_Salary = TestValue.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryMinLessOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            Double TestValue = -1.00;
            String Staff_Salary = TestValue.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryMin()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            Double TestValue = -0;
            String Staff_Salary = TestValue.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryMinPlusOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            Double TestValue = 1.00;
            String Staff_Salary = TestValue.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryMaxLessOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            Double TestValue = 199000;
            String Staff_Salary = TestValue.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryMax()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            Double TestValue = 200000;
            String Staff_Salary = TestValue.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryMaxPlusOne()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            Double TestValue = 200001;
            String Staff_Salary = TestValue.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryExtremeMax()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            Double TestValue = 200000*50;
            String Staff_Salary = TestValue.ToString();
            // invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_SalaryInvalidData()
        {
            //creates instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            String Staff_Salary = "this is not a salary";
            //invoke the method
            Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
            // test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
}
