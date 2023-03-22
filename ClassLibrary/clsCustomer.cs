using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        private DateTime mDateAdded;
        private string mEmailAdded;
        private string mPassword;
        private string mAddress;
        private string mContactNumber;
        private Boolean mActive;

        public bool Active {
            get
            {
                //sends data out of the property
                return mActive;
            }
            set
            {
                //allows data into the property
                mActive = value;
            }
        }
        public DateTime DateAdded {
            get
            {
                //sends data out of the property
                return mDateAdded;
            }
            set
            {
                //allows data into the property
                mDateAdded = value;
            }

        }
        public string ContactNumber {
            get
            {
                //sends data out of the property
                return mContactNumber;
            }
            set
            {
                //allows data into the property
                mContactNumber = value;
            }

        }
        public int CustomerID {
            get
            {
                //sends data out of the property
                return mCustomerID;
            } 
            set
            {
                //allows data into the property
                mCustomerID = value;
            }
            
         }
        public string Password {
            get
            {
                //sends data out of the property
                return mPassword;
            }
            set
            {
                //allows data into the property
                mPassword = value;
            }

        }
        public string Email {
            get
            {
                //sends data out of the property
                return mEmailAdded; 
            }
            set
            {
                //allows data into the property
                mEmailAdded = value;
            }

        }
        public string Address {
            get
            {
                //sends data out of the property
                return mAddress;
            }
            set
            {
                //allows data into the property
                mAddress = value;
            }
        }

        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Adding parameter for the address no to search for
            DB.AddParameter("@customerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_ID"]);
                mEmailAdded = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DataOfBirth"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["OnlineStatus"]);
                return true;
            }
            else
            {
                return false;
            }           
        }

        public string Valid(string emailCustomer, string passwordCustomer,string dateOfBirthCustomer, string addressCustomer, string contactNumberCustomer)
        {
            String Error = "";
            if(emailCustomer.Length == 0)
            {
                Error = Error + "CustommerID may not be blank: ";
            }

            if (emailCustomer.Length > 50)
            {
                Error = Error + "CustommerID must be less than 50 characters: ";
            }

            return Error;
        }
    }
}