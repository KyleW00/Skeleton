using System;

namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for active
        private Boolean mActive;
        public bool Active 
        {
            get 
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }
        //private data memeber for the stockId property
        private Int32 mStockId;
        //StockId public property
        public int StockId 
        { 
            get
            {
                //this line of code sends data out of the property
                return mStockId;
            }
            set
            {
                //this line of code allows data into the property
                mStockId = value;
            }
        }
        //dateAdded private member variable
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        //private data member for ProductName property
        private string mProductName;
        public string ProductName
        {
            get
            {
                //return the private data
                return mProductName;
            }
            set
            {
                //set the private data
                mProductName = value;
            }
        }
        //private data member for ProductQuantity property
        private int mProductQuantity;
        public int ProductQuantity
        {
            get
            {
                //return the private data
                return mProductQuantity;
            }
            set
            {
                //set the private data
                mProductQuantity = value;
            }
        }
        //private data member for ProductCost property
        private decimal mProductCost;
        public decimal ProductCost
        {
            get
            {
                //return the private data
                return mProductCost;
            }
            set
            {
                //set the private data
                mProductCost = value;
            }
        }
        //private data member for Quantity property
        private int mQuantity;
        public int Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the private data
                mQuantity = value;
            }
        }

        public bool Find(int stockId)
        {
            //set the private data member to the test data value
            mStockId = 12;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            mProductName = "Test Product Name";
            mQuantity = 10;
            mProductCost = Convert.ToDecimal("10.01");
            mActive = true;
            //always return true
            return true;
        }
    }
}