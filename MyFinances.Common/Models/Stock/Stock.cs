using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinances.Common.Models.Stock
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal LastPrice { get; set; }
    }
}
