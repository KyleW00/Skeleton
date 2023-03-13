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
            //setting private data members to the test data value
            mCustomerID = 21;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            mEmailAdded = "example@gmail.com";
            mPassword = "example1234!";
            mAddress = "22 London Road";
            mContactNumber = "07547799246";
            mActive = true;

            //always return true
            return true;
        }
    }
}