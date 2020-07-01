using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using MyFinances.Common.Exceptions;
using MyFinances.Common.Models.Stock;

namespace MyFinances.Stock.Service
{
    public class StockApi
    {
        private IList<StockModel> _prices;

        public StockApi()
        {
            _prices = new List<StockModel>()
            {
                new StockModel("Alior", "ALR", 16),
                new StockModel("CCC", "CCC", 59),
                new StockModel("CD Projekt", "CDR", 403),
                new StockModel("Cyfrowy Polsat", "CPS", 25),
                new StockModel("Dino", "DNP", 199),
                new StockModel("Jastrzębska Spółka Węglowa", "JSW", 18),
                new StockModel("HGHM", "KGH", 92),
                new StockModel("Lotos", "LTS", 60),
                new StockModel("LPP", "LPP", 6119),
                new StockModel("mBank", "MBK", 234),
                new StockModel("Orange Polska", "OPL", 6),
                new StockModel("Pekao", "PEO", 53),
                new StockModel("PGE", "PGE", 6),
                new StockModel("PGNiG", "PGN", 4),
                new StockModel("Orlen", "PKN", 63),
                new StockModel("PKO BP", "PKO", 23),
                new StockModel("Play", "PLY", 31),
                new StockModel("PZU", "PZU", 28),
                new StockModel("Santander", "SPL", 175),
                new StockModel("Tauron", "TPE", 2),
            };
        }

        public IList<StockModel> GetAll()
        {
            IList<StockModel> resultStocks = new List<StockModel>();

            var resultQuery = _prices.ToList();

            foreach (var stock in resultQuery)
            {
                resultStocks.Add(new StockModel(stock.Name, stock.Symbol, GenerateFakePrice(stock.Price)));
            }

            return resultStocks;
        }

        public IList<StockModel> SearchStock(string symbolOrName)
        {
            IList<StockModel> resultStocks = new List<StockModel>();
           

            var resultQuery = _prices
                .Where(x => x.Name.Contains(symbolOrName) || x.Symbol.Contains(symbolOrName)).ToList();

            if (resultQuery == null) throw new StockNotFoundException();

            foreach (var stock in resultQuery)
            {
                var minPrice = stock.Price - 1;
                var maxPrice = stock.Price + 1;

                resultStocks.Add(new StockModel(stock.Name, stock.Symbol, GenerateFakePrice(stock.Price)));
            }

            return resultStocks;
        }

        public StockHistoryModel StockInfo(string symbol)
        {
            var resultQuery = _prices.FirstOrDefault(x => x.Symbol.Contains(symbol));

            if (resultQuery == null) throw new StockNotFoundException();

            return new StockHistoryModel()
            {
                Name = resultQuery.Name,
                Symbol = resultQuery.Symbol,
                Prices = new List<decimal>()
                {
                    (decimal) GenerateFakePrice(resultQuery.Price),
                    (decimal) GenerateFakePrice(resultQuery.Price),
                    (decimal) GenerateFakePrice(resultQuery.Price),
                }
            };


        }

        private double GenerateFakePrice(double price)
        {
            Random random = new Random();

            var minPrice = price - 1;
            var maxPrice = price + 1;

            return random.NextDouble() * (maxPrice - minPrice) + minPrice);
        }
    }
}
