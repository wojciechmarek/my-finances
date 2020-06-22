using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MyFinances.Stock.Service
{
    public class StockApi
    {
        private HttpClient httpClient;

        public StockApi()
        {
            httpClient = new HttpClient();
        }

        public object ReturnListOfStocks()
        {
            return new object();
        }

        public object GetInfoAboutStock(string symbol)
        {
            return new object();
        }
    }
}
