using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Classes
{
    internal class SoldProductsInfo_API
    {
        public double price { get; set; }
        public int quantity { get; set; }
        public string barcode { get; set; }
        public int cashRegister_No { get; set; }
        public int document_No { get; set; }
        public DateTime irsaliyeDate { get; set; }

    }
}
