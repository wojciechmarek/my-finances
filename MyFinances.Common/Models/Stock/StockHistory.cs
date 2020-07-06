using System.Collections.Generic;

namespace MyFinances.Common.Models.Stock
{
    public class StockHistory
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Interval { get; set; }
        public IList<decimal> Prices { get; set; }
    }
}
