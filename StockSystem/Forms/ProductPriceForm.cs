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
    public partial class ProductPriceForm : Form
    {
        private Form1 form1;
        private ProductPrice productPrice;
        private SelectProductForm selectProductForm;
        public ProductPriceForm(Form1 form1)
        {
            this.form1 = form1;
            productPrice = new ProductPrice();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(57, 91, 100);
        }

        private void ProductPriceForm_Load(object sender, EventArgs e)
        {
            form1.Hide();

            // Show table in dataGridView
            dataGridView_productPrice.DataSource = productPrice.productPriceList();

            // customize datagridView header
            dataGridView_productPrice.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_productPrice.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 10, FontStyle.Regular);
            dataGridView_productPrice.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_productPrice.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Regular);


            dataGridView_productPrice.EnableHeadersVisualStyles = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDown_Id.Value;
                double price = (double)numericUpDown_price.Value;
                DateTime date = dateTimePicker_date.Value.Date;

                Console.WriteLine(date.ToString());

                if (productPrice.addProductInfo(id, date, price))
                {
                    dataGridView_productPrice.DataSource = productPrice.productPriceList();
                    MessageBox.Show("Product price is added Successfully!", "Product price Added Successfully", MessageBoxButtons.OK);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDown_Id.Value;
                double price = (double)numericUpDown_price.Value;
                DateTime date = dateTimePicker_date.Value.Date;

                Console.WriteLine(date.ToString());


                if (productPrice.editProductPrice(id, date, price))
                {
                    MessageBox.Show("Product price is edited successfully", "Edit Product Price", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with genres
                    dataGridView_productPrice.DataSource = productPrice.productPriceList();
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

        private void dataGridView_productPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_Id.Text = dataGridView_productPrice.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker_date.Text = dataGridView_productPrice.CurrentRow.Cells[1].Value.ToString();
            numericUpDown_price.Text = dataGridView_productPrice.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDown_Id.Value;
                DateTime date = dateTimePicker_date.Value;


                if (productPrice.deleteProductPrice(id,date))
                {
                    MessageBox.Show("Product is removed successfully", "Remove Product", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with productInfo
                    dataGridView_productPrice.DataSource = productPrice.productPriceList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            selectProductForm = new SelectProductForm(this,null,null);
            selectProductForm.Show();
        }
    }
}
