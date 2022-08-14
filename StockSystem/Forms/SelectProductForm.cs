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

namespace StockSystem.Forms
{
    public partial class SelectProductForm : Form
    {
        private ProductInfo productInfo;
        private CompanyProduct companyProduct;
        private string query;
        private ProductPriceForm productPriceForm = null;
        private CompanyProductForm companyProductForm = null;
        private StockProductForm stockProductForm = null;
        private OrderProductForm orderProductForm = null;
        private string id;
        private string price;
        public SelectProductForm(ProductPriceForm productPriceForm, CompanyProductForm companyProductForm, StockProductForm stockProductForm, OrderProductForm orderProductForm)
        {
            productInfo = new ProductInfo();
            query = "SELECT pid,pname,price,stock FROM productInfo";
            InitializeComponent();
            this.companyProductForm = companyProductForm;
            this.stockProductForm = stockProductForm;
            this.productPriceForm = productPriceForm;
            this.orderProductForm = orderProductForm;
            companyProduct = new CompanyProduct();
        }

        private void SelectProductForm_Load(object sender, EventArgs e)
        {
            if (stockProductForm != null)
            {
                // Show table in dataGridView
                dataGridView_selectProduct.DataSource = companyProduct.companyProductListConditions(stockProductForm.GetCid());
            }

            if (companyProductForm != null || productPriceForm != null)
            {
                // Show table in dataGridView
                dataGridView_selectProduct.DataSource = productInfo.productInfoList(query);
            }

            if (orderProductForm != null)
            {
                // Show table in dataGridView
                dataGridView_selectProduct.DataSource = companyProduct.companyProductListConditions(orderProductForm.getCid());
            }
            

            // customize datagridView header
            dataGridView_selectProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_selectProduct.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 10, FontStyle.Bold);
            dataGridView_selectProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_selectProduct.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Regular);


            dataGridView_selectProduct.EnableHeadersVisualStyles = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(57, 91, 100);
        }

        private void dataGridView_selectProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dataGridView_selectProduct.CurrentRow.Cells[0].Value.ToString();
            this.price = dataGridView_selectProduct.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_selectClose_Click(object sender, EventArgs e)
        {
            if (productPriceForm != null)
            {
                productPriceForm.numericUpDown_Id.Text = id;
                productPriceForm.numericUpDown_price.Text = price;
                this.Close();
            }

            if (companyProductForm != null)
            {
                companyProductForm.numericUpDown_Id.Text = id;
                this.Close();
            }

            if (stockProductForm != null)
            {
                stockProductForm.numericUpDown_ProductId.Text = id;
                this.Close();
            }

            if (orderProductForm != null)
            {
                orderProductForm.numericUpDown_ProductId.Text = id;
                this.Close();
            }
        }

        public string getPrice()
        {
            return this.price;
        }
    }
}
