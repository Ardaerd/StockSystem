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
    public partial class ProductInfoForm : Form
    {
        private Form1 form1;
        private ProductInfo productInfo = new ProductInfo();
        private string query = "SELECT * FROM productInfo";

        public ProductInfoForm(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void label2_MouseEnter_1(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave_1(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(57, 91, 100);
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            form1.Hide();

            // Show table in dataGridView
            dataGridView_productInfo.DataSource = productInfo.productInfoList(query);

            // customize datagridView header
            dataGridView_productInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_productInfo.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 10, FontStyle.Regular);
            dataGridView_productInfo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_productInfo.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Regular);


            dataGridView_productInfo.EnableHeadersVisualStyles = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int id = (int) numericUpDown_Id.Value;
            string pname = textBox_pname.Text;
            string barcode = textBox_barcode.Text;
            int sim = (int) numericUpDown_sim.Value;
            string picLink = textBox_picLink.Text;
            double price = (double) numericUpDown_price.Value;
            int stock = (int) numericUpDown_stock.Value;

            if (productInfo.addProductInfo(pname, barcode, sim, picLink, price, stock))
            {
                dataGridView_productInfo.DataSource = productInfo.productInfoList(query);
                MessageBox.Show(pname + " is added!", "Product Added Successfully", MessageBoxButtons.OK);
            }
            
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

            try
            {
                int id = (int)numericUpDown_Id.Value;
                string pname = textBox_pname.Text;
                string barcode = textBox_barcode.Text;
                int sim = (int)numericUpDown_sim.Value;
                string picLink = textBox_picLink.Text;
                double price = (double)numericUpDown_price.Value;
                int stock = (int)numericUpDown_stock.Value;

                
                    if (productInfo.editProductInfo(id, pname, barcode, sim, picLink,price,stock))
                    {
                        MessageBox.Show("Product is edited successfully", "Edit Product", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // populate datagridView with genres
                        dataGridView_productInfo.DataSource = productInfo.productInfoList(query);
                    }
                    else
                    {
                        MessageBox.Show("Product is not edited", "Product Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int id = (int)numericUpDown_Id.Value;


                if (productInfo.deleteProductInfo(id))
                {
                    MessageBox.Show("Product is removed successfully", "Remove Product", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with productInfo
                    dataGridView_productInfo.DataSource = productInfo.productInfoList(query);
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

        private void dataGridView_productInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_Id.Text = dataGridView_productInfo.CurrentRow.Cells[0].Value.ToString();
            textBox_pname.Text = dataGridView_productInfo.CurrentRow.Cells[1].Value.ToString();
            textBox_barcode.Text = dataGridView_productInfo.CurrentRow.Cells[2].Value.ToString();
            numericUpDown_sim.Text = dataGridView_productInfo.CurrentRow.Cells[3].Value.ToString();
            textBox_picLink.Text = dataGridView_productInfo.CurrentRow.Cells[4].Value.ToString();
            numericUpDown_price.Text = dataGridView_productInfo.CurrentRow.Cells[5].Value.ToString();
            numericUpDown_stock.Text = dataGridView_productInfo.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
