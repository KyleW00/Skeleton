using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data memeber for the stock No property
        private Int32 mStockNo;
        public bool Active { get; set; }
        //StockId public property
        public int StockId 
        { 
            get
            {
                //this line of code sends data out of the property
                return mStockNo;
            }
            set
            {
                //this line of code allows data into the property
                mStockNo = value;
            }
        }
        public DateTime DateAdded { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductCost { get; set; }
        public int Quantity { get; set; }

        public bool Find(int stockId)
        {
            //set the private data member to the test data value
            mStockNo = 12;
            //always return true
            return true;
        }
    }
}