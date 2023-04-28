using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    class tstStockCollections
    {
        public void StockOK()
        {
            //create an instance of the class we wnat to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }
    }
}
