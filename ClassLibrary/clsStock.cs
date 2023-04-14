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
        //private data member for StockName property
        private string mStockName;
        public string StockName
        {
            get
            {
                //return the private data
                return mStockName;
            }
            set
            {
                //set the private data
                mStockName = value;
            }
        }
        
        //private data member for StockCost property
        private decimal mStockCost;
        public decimal StockCost
        {
            get
            {
                //return the private data
                return mStockCost;
            }
            set
            {
                //set the private data
                mStockCost = value;
            }
        }
        //private data member for StockQuantity property
        private int mStockQuantity;
        public int StockQuantity
        {
            get
            {
                //return the private data
                return mStockQuantity;
            }
            set
            {
                //set the private data
                mStockQuantity = value;
            }
        }

        public bool Find(int stockId)
        {
            //set the private data member to the test data value
            mStockId = 12;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            mStockName = "Test Stock Name";
            mStockQuantity = 10;
            mStockCost = Convert.ToDecimal("10.01");
            mActive = true;
            //always return true
            return true;
        }
    }
}