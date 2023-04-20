using System;

namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for active
        private Boolean mInStock;
        public bool InStock 
        {
            get 
            {
                //return the private data
                return mInStock;
            }
            set
            {
                //set the private data
                mInStock = value;
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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Stock Id to search for
            DB.AddParameter("@StockId", stockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                 //copy the data from the database to the private data members
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mStockCost = Convert.ToDecimal(DB.DataTable.Rows[0]["StockCost"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }
    }
}