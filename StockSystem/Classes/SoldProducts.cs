using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockSystem.Classes
{
    internal class SoldProducts
    {
        private double price;

        private int quantity;
        private int cashRegister_No;

        public string barcode = null;

        private DateTime irsaliyeDate;

        public SoldProducts()
        {
            Get_SoldProducts();
        }

        void Get_SoldProducts()
        {
            using (WebClient web = new WebClient())
            {

                string url = "https://localhost:7135/api/StockSystem";

                var json = web.DownloadString(url);
                List<SoldProductsInfo> Info = JsonConvert.DeserializeObject<List<SoldProductsInfo>>(json);

                price = Info[0].price;
                quantity = Info[0].quantity;
                cashRegister_No = Info[0].cashRegister_No;
                barcode = Info[0].barcode;
                irsaliyeDate = Info[0].irsaliyeDate;
            }
        }

        public double getPrice()
        {
            return this.price;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public int Get_cashRegister_No()
        {
            return this.cashRegister_No;
        }

        public string getBarcode()
        {
            return this.barcode;
        }

        public DateTime get_irsaliyeDate()
        {
            return this.irsaliyeDate;
        }
    }
}
