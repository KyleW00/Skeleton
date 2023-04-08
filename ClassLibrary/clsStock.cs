using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public int StockId { get; set; }
        public DateTime DateAdded { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductCost { get; set; }
        public int Quantity { get; set; }
    }
}