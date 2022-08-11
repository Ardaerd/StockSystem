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
        public Form1()
        {
            InitializeComponent();
            SoldProducts soldProducts = new SoldProducts();

            Console.WriteLine("It is working...");
            Console.WriteLine(soldProducts.getBarcode());
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
    }
}
