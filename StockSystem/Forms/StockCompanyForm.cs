using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockSystem.Classes;

namespace StockSystem.Forms
{
    public partial class StockCompanyForm : Form
    {
        private Form1 form1;
        private SelectCompanyForm selectCompanyForm;
        private StockCompany stockCompany;
        private StockProduct stockProduct;
        private StockProductForm stockProductForm;
        private string queryForCompany = "SELECT * FROM stockCompany_view ORDER BY sid ASC";
        private string queryForProduct = "SELECT * FROM stockProduct_view ORDER BY sid ASC";
        private string queryNewRows = "SELECT * FROM stockProduct_view WHERE sid > :sid ORDER BY sid ASC";
        private int sid;
        private int cid;
        private int lastSid;
        public StockCompanyForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            stockCompany = new StockCompany();
            stockProduct = new StockProduct();
            int row = stockProduct.stockProductList(queryForProduct).Rows.Count - 1;
            lastSid = Int32.Parse(stockProduct.stockProductList(queryForProduct).Rows[row]["sid"].ToString());
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

        private void button_selectCompany_Click(object sender, EventArgs e)
        {
            selectCompanyForm = new SelectCompanyForm(this);
            selectCompanyForm.Show();
        }

        private void StockCompanyForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_IrsaliyeDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_IrsaliyeDate.CustomFormat = "dd/MM/yyyy";


            // Show table in dataGridView
            dataGridView_stockCompany.DataSource = stockProduct.stockProductWithPidList(queryNewRows,lastSid);

            // customize datagridView header
            dataGridView_stockCompany.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_stockCompany.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            dataGridView_stockCompany.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_stockCompany.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Regular);


            dataGridView_stockCompany.EnableHeadersVisualStyles = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                stockProductForm = new StockProductForm(this);

                int cid = (int)numericUpDown_companyId.Value;
                int tip = (int)numericUpDown_tip.Value;
                string status = textBox_status.Text;
                String irsaliyeDate = dateTimePicker_IrsaliyeDate.Value.Date.ToString("dd/MM/yyyy");
                int irsaliyeNo = (int)numericUpDown_IrsaliyeNo.Value;

                DateTime date_2 = DateTime.ParseExact(irsaliyeDate, @"dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture);

                if (cid == 0)
                {
                    MessageBox.Show("You have to fill cid", "Fill CID", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                else
                {

                    if (stockCompany.addStockCompany(cid, tip, status, date_2, irsaliyeNo))
                    {
                        MessageBox.Show("Company is added to the Stock Successfully!", "Company Added Successfully", MessageBoxButtons.OK);

                        // sending sid and cid to the stockProductForm for selecting the products which belongs to the current company
                        int row = stockCompany.stockCompanyList(queryForCompany).Rows.Count - 1;
                        this.sid = Int32.Parse(stockCompany.stockCompanyList(queryForCompany).Rows[row]["sid"].ToString());
                        this.cid = Int32.Parse(stockCompany.stockCompanyList(queryForCompany).Rows[row]["cid"].ToString());
                    }
                }

                stockProductForm.Show();
                this.Hide();
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
                int sid = (int)numericUpDown_stockId.Value;
                int cid = (int)numericUpDown_companyId.Value;
                int tip = (int)numericUpDown_tip.Value;
                string status = textBox_status.Text;
                DateTime irsaliyeDate = dateTimePicker_IrsaliyeDate.Value.Date;
                int irsaliyeNo = (int)numericUpDown_IrsaliyeNo.Value;

                if (stockCompany.editStockProduct(sid, cid, tip, status,irsaliyeDate,irsaliyeNo))
                {
                    MessageBox.Show("Stock Company is edited successfully", "Edit Stock Company", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with genres
                    dataGridView_stockCompany.DataSource = stockProduct.stockProductWithPidList(queryNewRows, lastSid);
                }
                else
                {
                    MessageBox.Show("StockCompany price is not edited", "StockCompany Price Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int sid = (int)numericUpDown_stockId.Value;

                if (stockCompany.deleteStockProduct(sid))
                {
                    MessageBox.Show("StockProduct is removed successfully", "Remove StockCompany", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with productInfo
                    dataGridView_stockCompany.DataSource = stockProduct.stockProductWithPidList(queryNewRows, lastSid);
                }
                else
                {
                    MessageBox.Show("StockCompany is not removed", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }


        private void button_addProduct_Click(object sender, EventArgs e)
        {
            try
            { 
                sid = (int)numericUpDown_stockId.Value;
                cid = (int)numericUpDown_companyId.Value;

                stockProductForm.Show();
                this.Hide();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }

        public int getSid()
        {
            return sid;
        }

        public int getCid()
        {
            return cid;
        }

        public int getLastSid()
        {
            return this.lastSid;
        }
    }
}
