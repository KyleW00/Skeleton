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
        }

        public string Valid(string staff_Name, string staff_Role, string staff_Started, string staff_Salary)
        {
            //create string variable to store an error
            String Error = "";
            DateTime DateTemp;
            Double DoubTemp;
            // if the Staff_Name is blank
            if (staff_Name.Length == 0)
            {
                //record the error
                Error = Error + "The Staff_Name may not be blank : ";
            }
            // if the Staff_Name is more than 20 characters
            if (staff_Name.Length > 20)
            {
                //record the error
                Error = Error + "The Staff_Name may not more the 20 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(staff_Started);
                // if the Staff_Started is more than 10 years ago
                if (DateTemp < DateTime.Now.Date.AddYears(-10))
                {
                    Error = Error + "The Staff_Started may not be more than 10 years in the past : ";
                }
                // if the staff started is in the future
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Staff_Started may not be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }


            // if the Staff_Role is blank
            if (staff_Role.Length == 0)
            {
                //record the error
                Error = Error + "The Staff_Role may not be blank : ";
            }
            // if the Staff_Role is more than 30 characters
            if (staff_Role.Length > 30)
            {
                //record the error
                Error = Error + "The Staff_Role may not more the 30 characters : ";
            }

            try
            {
                DoubTemp = Convert.ToDouble(staff_Salary);
                // if the Staff_Salary is negative
                if (DoubTemp < 0)
                {
                    //record the error
                    Error = Error + "The Staff_Salary cannot be negative : ";
                }
                if (DoubTemp > 200000)
                {
                    //record the error
                    Error = Error + "The Staff_Salary cannot be more than 200000";
                }
            }
            catch
            {
                //record the Error
                Error = Error + "The Salary is not a valid type : ";
            }
 


            //return any error messages
            return Error;
        }
    }
}