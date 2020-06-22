using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Common.Models.Stock;

namespace MyFinances.Stock.Adapter
{
    public interface IStockAdapter
    {
        IEnumerable<Common.Models.Stock.Stock> GetStocks();
        StockHistory GetStockHistory(string symbol);
    }
}
