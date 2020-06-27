using System.Collections.Generic;

namespace MyFinances.Common.Models.Stock
{
    public class StockHistory
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public IEnumerable<decimal> Price { get; set; }
    }
}
