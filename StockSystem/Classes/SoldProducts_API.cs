using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StockSystem.Database;

namespace StockSystem.Classes
{
    internal class SoldProducts_API
    {
        private double price;

        private int pid;
        private int quantity;
        private int cashRegister_No;
        private int document_No;

        public string barcode = null;

        private DateTime irsaliyeDate;

        public List<SoldProductsInfo_API> Get_SoldProducts()
        {
            using (WebClient web = new WebClient())
            {

                string url = "https://localhost:7135/api/StockSystem/Get";

                var json = web.DownloadString(url);
                List<SoldProductsInfo_API> Info = JsonConvert.DeserializeObject<List<SoldProductsInfo_API>>(json);

                return Info;
            }
        }

        public int getPid()
        {
            return this.pid;
        }

        public void setPid(int pid)
        {
            this.pid = pid;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int Get_cashRegister_No()
        {
            return this.cashRegister_No;
        }

        public void Set_cashRegister_No(int cashRegister_No)
        {
            this.cashRegister_No = cashRegister_No;
        }

        public int Get_document_No()
        {
            return this.document_No;
        }

        public void Set_document_No(int document_No)
        {
            this.document_No = document_No;
        }

        public string getBarcode()
        {
            return this.barcode;
        }

        public void setBarcode(string barcode)
        {
            this.barcode = barcode;
        }

        public DateTime get_irsaliyeDate()
        {
            return this.irsaliyeDate;
        }

        public void Set_irsaliyeDate(DateTime irsaliyeDate)
        {
            this.irsaliyeDate = irsaliyeDate;
        }
    }
}
