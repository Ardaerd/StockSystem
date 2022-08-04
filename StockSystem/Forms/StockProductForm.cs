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
    public partial class StockProductForm : Form
    {
        private SelectProductForm selectProductForm = null;
        private StockCompanyForm stockCompanyForm = null;
        private Form1 form1;
        private StockProduct stockProduct;
        private double price;
        private string queryAllRow = "SELECT * FROM stockProduct_view ORDER BY sid ASC";
        private string queryNewRow = "SELECT * FROM stockProduct_view WHERE sid > :sid ORDER BY sid ASC";
        private int lastSid;

        public StockProductForm(StockCompanyForm stockCompanyForm)
        {
            InitializeComponent();
            stockProduct = new StockProduct();
            this.stockCompanyForm = stockCompanyForm;

            int row = stockProduct.stockProductList(queryAllRow).Rows.Count - 1;
            lastSid = Int32.Parse(stockProduct.stockProductList(queryAllRow).Rows[row]["sid"].ToString());
        }

        private void button_selectProduct_Click(object sender, EventArgs e)
        {
            selectProductForm = new SelectProductForm(null,null,this);
            selectProductForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            stockCompanyForm.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(57, 91, 100);
        }

        private void StockProductForm_Load(object sender, EventArgs e)
        {

            stockCompanyForm.Hide();

            // Show table in dataGridView
            dataGridView_stockProduct.DataSource = stockProduct.stockProductWithPidList(queryNewRow,lastSid);

            // customize datagridView header
            dataGridView_stockProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_stockProduct.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            dataGridView_stockProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_stockProduct.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Regular);


            dataGridView_stockProduct.EnableHeadersVisualStyles = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = stockCompanyForm.getSid();
                int pid = (int)numericUpDown_ProductId.Value;
                int quantity = (int)numericUpDownQuantity.Value;
                double price = Convert.ToDouble(selectProductForm.getPrice());
                double total = price * quantity;


                if (stockProduct.addStockProduct(sid, pid, quantity, price, total))
                {
                    dataGridView_stockProduct.DataSource = stockProduct.stockProductWithPidList(queryNewRow,lastSid);

                    // Adding product to the dataGridView of the stockCompanyForm
                    stockCompanyForm.dataGridView_stockCompany.DataSource =
                        stockProduct.stockProductWithPidList(queryNewRow, stockCompanyForm.getLastSid());

                    MessageBox.Show("Product is added to the Stock Successfully!", "Product Added Successfully", MessageBoxButtons.OK);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = (int)numericUpDown_StockId.Value;
                int pid = (int)numericUpDown_ProductId.Value;
                int quantity = (int)numericUpDownQuantity.Value;
                double total = price * quantity;

                if (stockProduct.editStockProduct(sid, pid, quantity,total))
                {
                    MessageBox.Show("Quantity of the product is edited successfully", "Edit Product Quantity", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with genres
                    dataGridView_stockProduct.DataSource = stockProduct.stockProductWithPidList(queryNewRow,lastSid);

                    // Editing product to the dataGridView of the stockCompanyForm
                    stockCompanyForm.dataGridView_stockCompany.DataSource =
                        stockProduct.stockProductWithPidList(queryNewRow, stockCompanyForm.getLastSid());
                }
                else
                {
                    MessageBox.Show("Product price is not edited", "Product Price Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = (int)numericUpDown_ProductId.Value;
                int sid = (int)numericUpDown_StockId.Value;

                if (stockProduct.deleteStockProduct(sid, pid))
                {
                    MessageBox.Show("Product is removed from Stock successfully", "Remove Product", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with productInfo
                    dataGridView_stockProduct.DataSource = stockProduct.stockProductWithPidList(queryNewRow,lastSid);

                    // Deleting product to the dataGridView of the stockCompanyForm
                    stockCompanyForm.dataGridView_stockCompany.DataSource =
                        stockProduct.stockProductWithPidList(queryNewRow, stockCompanyForm.getLastSid());
                }
                else
                {
                    MessageBox.Show("Product is not removed", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }

        private void dataGridView_stockProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_StockId.Text = dataGridView_stockProduct.CurrentRow.Cells[0].Value.ToString();
            numericUpDown_ProductId.Text = dataGridView_stockProduct.CurrentRow.Cells[1].Value.ToString();
            numericUpDownQuantity.Text = dataGridView_stockProduct.CurrentRow.Cells[2].Value.ToString();
            price = (double)dataGridView_stockProduct.CurrentRow.Cells[3].Value;
        }

        public int GetCid()
        {
            return stockCompanyForm.getCid();
        }
    }
}
