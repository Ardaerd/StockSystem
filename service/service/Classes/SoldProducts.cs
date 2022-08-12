using Newtonsoft.Json;
using System.Net;

namespace service.Classes
{
    public class SoldProducts
    {
        private double price;

        private int quantity;
        private int cashRegister_No;

        public string barcode = null;

        private string irsaliyeDate;

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
                List<SoldProductInfo> Info = JsonConvert.DeserializeObject<List<SoldProductInfo>>(json);

                foreach (SoldProductInfo info in Info)
                {
                    price = info.price;
                    quantity = info.quantity;
                    cashRegister_No = info.cashRegister_No;
                    barcode = info.barcode;
                    irsaliyeDate = info.irsaliyeDate;
                }
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

        public string get_irsaliyeDate()
        {
            return this.irsaliyeDate;
        }
    }
}

