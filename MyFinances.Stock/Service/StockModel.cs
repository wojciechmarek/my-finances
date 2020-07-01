using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinances.Stock.Service
{
    public class StockModel
    {
        public StockModel(string name, string symbol, double price)
        {
            Name = name;
            Symbol = symbol;
            Price = price;
        }

        public string Name { get; set; }
        public string Symbol { get; set; }
        public double Price { get; set; }
    }
}
