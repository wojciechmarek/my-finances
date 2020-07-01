using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinances.Stock.Service
{
    public class StockHistoryModel
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public IEnumerable<decimal> Prices { get; set; }
    }
}
