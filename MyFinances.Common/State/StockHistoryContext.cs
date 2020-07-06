using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Common.Models.Stock;

namespace MyFinances.Common.State
{
    public class StockHistoryContext
    {
        private StockHistoryState _state = null;

        public void SetStockHistoryContext(StockHistoryState state)
        {
            _state = state;
        }

        public StockHistory GetStockHistory(string symbol)
        {
            return _state.GetHistory(symbol);
        }
    }
}
