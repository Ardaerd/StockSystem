using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Classes
{
    internal class SoldProductsInfo
    {
        public double price { get; set; }
        public int quantity { get; set; }
        public string barcode { get; set; }
        public int cashRegister_No { get; set; }
        public DateTime irsaliyeDate { get; set; }

        /*public class Data
        {
            public double price { get; set; }
            public int quantity { get; set; }
            public string barcode { get; set; }
            public int cashRegister_No { get; set; }
            public DateTime irsaliyeDate { get; set; }
        }

        public class productInfo
        {
            public List<Data> soldProducts { get; set; }
        }

        public class Root
        {
            public productInfo data { get; set; }
        }*/
    }
}
