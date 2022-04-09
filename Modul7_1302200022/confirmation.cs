using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_1302200022
{
    internal class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }

        public confirmation() { }
        public confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
