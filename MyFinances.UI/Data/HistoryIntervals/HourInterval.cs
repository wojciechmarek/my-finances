using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFinances.Common.Models.Stock;
using MyFinances.Common.State;
using MyFinances.Stock.Adapter;

namespace MyFinances.UI.Data.HistoryIntervals
{
    public class HourInterval : StockHistoryState
    {
        private IStockAdapter _adapter;

        public void SetContext(IStockAdapter adapter)
        {
            _adapter = adapter;
        }

        public override StockHistory GetHistory(string symbol)
        {
            return _adapter.GetStockHistory(symbol);
        }
    }
}
