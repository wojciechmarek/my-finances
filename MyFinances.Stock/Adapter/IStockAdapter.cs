using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Common.Models.Stock;

namespace MyFinances.Stock.Adapter
{
    public interface IStockAdapter
    {
        IList<Common.Models.Stock.Stock> GetStocks();
        IList<Common.Models.Stock.Stock> SearchStock(string nameOrSymbol);
        StockHistory GetStockHistory(string symbol);
    }
}
