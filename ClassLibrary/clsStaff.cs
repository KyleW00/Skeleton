using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff_Id
        private Int32 mStaff_Id;
        //private data member for the Staff_Started
        private DateTime mStaff_Started;
        //private data member for the Staff_Name
        private String mStaff_Name;
        //private data member for the Staff_Role
        private String mStaff_Role;
        //private data member for the Staff_Salary
        private double mStaff_Salary;
        //private data member for the Staff_Online
        private bool mStaff_Online;

        public bool Staff_Online
        {
            get
            {
                // sends data out of the property
                return mStaff_Online;
            }
            set
            {
                // allows data into the property
                mStaff_Online = value;
            }
        }
        public DateTime Staff_Started
        {
            get
            {
                // sends data out of the property
                return mStaff_Started;
            }
            set
            {
                // allows data into the property
                mStaff_Started = value;
            }
        }

        public double Staff_Salary
        {
            get
            {
                // sends data out of the property
                return mStaff_Salary;
            }
            set
            {
                // allows data into the property
                mStaff_Salary = value;
            }
        }
        public Int32 Staff_Id
        {
            get
            {
                // sends data out of the property
                return mStaff_Id;
            }
            set
            {
                // allows data into the property
                mStaff_Id = value;
            }
        }
        public string Staff_Name
        {
            get
            {
                // sends data out of the property
                return mStaff_Name;
            }
            set
            {
                // allows data into the property
                mStaff_Name = value;
            }
        }
        public string Staff_Role
        {
            get
            {
                // sends data out of the property
                return mStaff_Role;
            }
            set
            {
                // allows data into the property
                mStaff_Role = value;
            }
        }
        
        public bool Find(int Staff_Id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Staff_Id to search for
            DB.AddParameter("@Staff_Id", Staff_Id);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaff_Id");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaff_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_Id"]);
                mStaff_Name = Convert.ToString(DB.DataTable.Rows[0]["Staff_Name"]);
                mStaff_Role = Convert.ToString(DB.DataTable.Rows[0]["Staff_Role"]);
                mStaff_Started = Convert.ToDateTime(DB.DataTable.Rows[0]["Staff_Started"]);
                mStaff_Online = Convert.ToBoolean(DB.DataTable.Rows[0]["Staff_Online"]);
                mStaff_Salary = Convert.ToDouble(DB.DataTable.Rows[0]["Staff_Salary"]);
                //return everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }



            //set the private data members to the test data
            //mStaff_Id = 21;
            //mStaff_Started = Convert.ToDateTime("16/9/2015");
            //mStaff_Name = "Dave";
            //mStaff_Role = "Manager";
           // mStaff_Salary = 2.21;
           // mStaff_Online = false;
            //always return true
            //return true;
        }
    }
}