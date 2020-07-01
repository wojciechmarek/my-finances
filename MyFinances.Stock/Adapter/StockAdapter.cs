using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFinances.Common.Exceptions;
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

        public IList<Common.Models.Stock.Stock> GetStocks()
        {
            IList<Common.Models.Stock.Stock> stocks = new List<Common.Models.Stock.Stock>();

            var result = _stockApi.GetAll();

            if (result == null) throw new StockAdapterException();

            foreach (var stock in result)
            {
                stocks.Add(new Common.Models.Stock.Stock()
                {
                    LastPrice = (decimal)stock.Price,
                    Symbol = stock.Symbol,
                    Name = stock.Name
                });
            }

            return stocks;
        }

        public IList<Common.Models.Stock.Stock> SearchStock(string nameOrSymbol)
        {
            IList<Common.Models.Stock.Stock> stocks = new List<Common.Models.Stock.Stock>();

            var result = _stockApi.SearchStock(nameOrSymbol);

            if (result == null) throw new StockAdapterException();

            foreach (var stock in result)
            {
                stocks.Add(new Common.Models.Stock.Stock()
                {
                    LastPrice = (decimal)stock.Price,
                    Symbol = stock.Symbol,
                    Name = stock.Name
                });
            }

            return stocks;
        }

        public StockHistory GetStockHistory(string symbol)
        {
            StockHistory stockHistory = new StockHistory();

            var result = _stockApi.StockInfo(symbol);

            if (result == null) throw new StockAdapterException();

            stockHistory.Name = result.Name;
            stockHistory.Symbol = result.Symbol;
            stockHistory.Prices = result.Prices.ToList();

            return stockHistory;
        }
    }
}
