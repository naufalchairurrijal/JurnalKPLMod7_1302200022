using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Modul7_1302200022
{
    internal class readConfig
    {
        public BankTransferConfig config;
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;


        public void setDefault()
        {

        }

        public BankTransferConfig ReadConfigFile()
        {
            string jsonString = File.ReadAllText(path + "\\bank_transfer_config.json");
            config = JsonConvert.DeserializeObject<BankTransferConfig>(jsonString);
        }
    }
}
