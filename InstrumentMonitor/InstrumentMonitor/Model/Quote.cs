using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstrumentMonitor
{
    public class Quote
    {
        public double Bid { get; set; }
        public double Ask { get; set; }
        public double Price { get; set; }
        public string PriceSource { get; set; }

        public int InstrumentID { get; set; }
    }
}
