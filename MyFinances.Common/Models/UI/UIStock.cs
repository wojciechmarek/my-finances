using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinances.Common.Models.UI
{
    public class UIStock
    {
        public UIStock(DateTime time, decimal price)
        {
            Time = time;
            Price = price;
        }

        public DateTime Time { get; set; }
        public decimal Price { get; set; }
    }
}
