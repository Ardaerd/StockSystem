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
    public partial class OrderProductForm : Form
    {
        private Form1 form;
        private OrderProduct orderProduct;
        private SelectProductForm selectProductForm;
        private string query_1 = "SELECT * FROM orderProduct";
        private int opid;
        public OrderProductForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.orderProduct = new OrderProduct();
            addingCompany();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.BackColor = Color.Red;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.BackColor = Color.FromArgb(57, 91, 100);
        }

        private void addingCompany()
        {
            string query = "SELECT cname,cid FROM company";

            comboBox_companyName.DataSource = orderProduct.getList(query);
            comboBox_companyName.DisplayMember = "cname";
            comboBox_companyName.ValueMember = "cid";
            comboBox_companyName.SelectedIndex = -1;
        }

        public int getCid()
        {
            return Int32.Parse(comboBox_companyName.SelectedValue.ToString()); 
        }

        private void button_selectProduct_Click(object sender, EventArgs e)
        {
            if (comboBox_companyName.Text.Trim().Equals(""))
            {
                MessageBox.Show("First you have to select company!", "Select Company", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                selectProductForm = new SelectProductForm(null, null, null, this);
                selectProductForm.Show();
            }
        }

        private void OrderProductForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_deliveryDate.Value = DateTime.Now;

            dataGridView_orderProduct.DataSource = orderProduct.getList(query_1);

            // customize datagridView header
            dataGridView_orderProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_orderProduct.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            dataGridView_orderProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_orderProduct.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Regular);


            dataGridView_orderProduct.EnableHeadersVisualStyles = false;

            int column = dataGridView_orderProduct.Columns.Count - 1;

            for (int i = 0; i < column; i++)
            {
                dataGridView_orderProduct.Columns[i].ReadOnly = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string cname = comboBox_companyName.Text;
                int pid = (int)numericUpDown_ProductId.Value;
                int quantity = (int)numericUpDownQuantity.Value;
                DateTime delivery_date = dateTimePicker_deliveryDate.Value.Date;

                if (orderProduct.addOrder(cname,pid,quantity,delivery_date))
                {
                    dataGridView_orderProduct.DataSource = orderProduct.getList(query_1);
                    MessageBox.Show("Product is Ordered Successfully!", "Order", MessageBoxButtons.OK);

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderProduct.deleteOrder(opid))
                {
                    dataGridView_orderProduct.DataSource = orderProduct.getList(query_1);
                    MessageBox.Show("Order is deleted Successfully!", "Order Delete", MessageBoxButtons.OK);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void dataGridView_orderProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.opid = Int32.Parse(dataGridView_orderProduct.CurrentRow.Cells[0].Value.ToString()); 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
    }
}
