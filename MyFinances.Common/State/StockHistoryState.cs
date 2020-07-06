using System;
using System.Collections.Generic;
using System.Text;
using MyFinances.Common.Models.Stock;

namespace MyFinances.Common.State
{
    public abstract class StockHistoryState
    {
        public abstract StockHistory GetHistory(string symbol);
    }
}
