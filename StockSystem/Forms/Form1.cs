using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockSystem.Classes;
using StockSystem.Database;
using StockSystem.Forms;

namespace StockSystem
{
    public partial class Form1 : Form
    {
        private ProductPriceForm productPriceForm;
        private ProductInfoForm productInfoForm;
        private CompanyForm companyForm;
        private CompanyProductForm companyProductForm;
        private StockProductForm stockProductForm;
        private StockCompanyForm stockCompanyForm;
        private StockTrackingForm stockTrackingForm;
        private OrderProductForm orderProductForm;
        private ServiceDataForm serverDataForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(57, 91, 100);
        }

        private void button_productInfo_Click(object sender, EventArgs e)
        {
            productInfoForm = new ProductInfoForm(this);
            productInfoForm.Show();
            this.Hide();
        }

        private void button_productPrice_Click(object sender, EventArgs e)
        {
            productPriceForm = new ProductPriceForm(this);
            productPriceForm.Show();
            this.Hide();
        }

        private void button_comapny_Click(object sender, EventArgs e)
        {
            companyForm = new CompanyForm(this);
            companyForm.Show();
            this.Hide();
        }

        private void button_stockCompany_Click(object sender, EventArgs e)
        {
            stockCompanyForm = new StockCompanyForm(this);
            stockCompanyForm.Show();
            this.Hide();
        }

        private void button_stockTracking_Click(object sender, EventArgs e)
        {
            stockTrackingForm = new StockTrackingForm(this);
            stockTrackingForm.Show();
            this.Hide();
        }

        private void button_orderProduct_Click(object sender, EventArgs e)
        {
            orderProductForm = new OrderProductForm(this);
            orderProductForm.Show();
            this.Hide();
        }

        private void button_getData_Click(object sender, EventArgs e)
        {
            try
            {
                SoldProduct soldProduct = new SoldProduct();

                if (soldProduct.deleteSoldProduct())
                {
                    Console.WriteLine("Old data is deleted !");
                }
                else
                {
                    MessageBox.Show("Old data couldn't delete!", "Server", MessageBoxButtons.OK);

                }

                SoldProducts_API soldProducts = new SoldProducts_API();

                List<SoldProductsInfo_API> Info = soldProducts.Get_SoldProducts();

                foreach (SoldProductsInfo_API info in Info)
                {
                    double price = info.price;
                    int quantity = info.quantity;
                    int cashRegister_No = info.cashRegister_No;
                    int document_No = info.document_No;
                    string barcode = info.barcode;
                    DateTime irsaliyeDate = DateTime.ParseExact(info.irsaliyeDate, "dd/MM/yyyy", null);

                    if (soldProduct.addSoldProduct(price, quantity, barcode, cashRegister_No, document_No, irsaliyeDate))
                    {
                        Console.WriteLine("Data is recived Successfully from the Server!");
                    }
                }

                serverDataForm = new ServiceDataForm(this);
                serverDataForm.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
    }
}
