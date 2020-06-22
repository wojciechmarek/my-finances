using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Common.Models.Stock;
using MyFinances.Stock.Adapter;
using MyFinances.Stock.Service;

namespace MyFinances.Stock.Adapter
{
    public class StockAdapter : IStockAdapter
    {
        private readonly StockApi _stockApi;

        public StockAdapter(StockApi stockApi)
        {
            _stockApi = stockApi;
        }

        public IEnumerable<Common.Models.Stock.Stock> GetStocks()
        {
            throw new NotImplementedException();
        }

        public StockHistory GetStockHistory(string symbol)
        {
            throw new NotImplementedException();
        }
    }
}
