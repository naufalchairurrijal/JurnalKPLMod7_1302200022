using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_1302200022
{
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        public transfer Transfer { get; set; }
        public List<string> Methods { get; set; }

        public confirmation Confirmation { get; set; }

        public BankTransferConfig() { }
        public BankTransferConfig(string lang, transfer Transfer, List<string> Methods, confirmation Confirmation)
        {
            this.lang = lang;
            this.Transfer = Transfer;
            this.Methods = Methods;
            this.Confirmation = Confirmation;
        }
    }
}
