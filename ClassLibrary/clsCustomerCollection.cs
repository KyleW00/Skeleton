

using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            clsCustomer TestItem = new clsCustomer();


            TestItem.Active = true;
            TestItem.Address = "First street";
            TestItem.ContactNumber = "123456789";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "example1@gmail.com";
            TestItem.Password = "password1";

            mCustomerList.Add(TestItem);
            TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.Address = "second street";
            TestItem.ContactNumber = "987654321";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Email = "example2@gmail.com";
            TestItem.Password = "password2";
            mCustomerList.Add(TestItem);
        }
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        private Int32 count;
        private clsCustomer clsCustomer;

        public List<clsCustomer> CustomerList {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }


        public int Count {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //
            }

        }
        public clsCustomer ThisCustomer {
            get
            {
                return clsCustomer;
            }

            set
            {
                clsCustomer = value;
            }
        }
    }
}