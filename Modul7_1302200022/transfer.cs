using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_1302200022
{
    internal class transfer
    {
        public long threshold { get; set; }
        public long low_fee { get; set; }
        public long high_fee { get; set; }
        public int V1 { get; }
        public double V2 { get; }

        public transfer(long threshold, long low_fee, long high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }

        public transfer(int v1, double v2)
        {
            V1 = v1;
            V2 = v2;
        }
    }
}
