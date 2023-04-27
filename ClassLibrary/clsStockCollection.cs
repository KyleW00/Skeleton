using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public clsStockCollection()
        {
        }

        public List<clsStock> StockList { get; internal set; }
    }
}