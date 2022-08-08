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
        private string clickedPid;
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
            dataGridView_stockCompany.DataSource = stockProduct.stockProductListWithSid(queryNewRows,lastSid);

            // customize datagridView header
            dataGridView_stockCompany.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_stockCompany.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            dataGridView_stockCompany.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_stockCompany.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Regular);


            dataGridView_stockCompany.EnableHeadersVisualStyles = false;

            int column = dataGridView_stockCompany.Columns.Count - 1;

            for (int i = 0; i < column; i++)
            {
                if (i != 4)
                {
                    dataGridView_stockCompany.Columns[i].ReadOnly = true;
                }
            }

            addingStatus();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                stockProductForm = new StockProductForm(this,null);

                int cid = (int)numericUpDown_companyId.Value;
                int tip = (int)numericUpDown_tip.Value;
                string status = comboBox_status.SelectedValue.ToString();
                String irsaliyeDate = dateTimePicker_IrsaliyeDate.Value.Date.ToString("dd/MM/yyyy");
                int irsaliyeNo = (int)numericUpDown_IrsaliyeNo.Value;

                DateTime date_2 = DateTime.ParseExact(irsaliyeDate, @"dd/MM/yyyy",
                    System.Globalization.CultureInfo.CurrentCulture);

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
                        numericUpDown_stockId.Value = sid;
                        numericUpDown_companyId.Value = cid;

                        numericUpDown_stockId.Enabled = false;
                        numericUpDown_companyId.Enabled = false;
                        button_add.Enabled = false;
                        button_selectCompany.Enabled = false;
                        numericUpDown_tip.Enabled = false;
                        numericUpDown_IrsaliyeNo.Enabled = false;
                        dateTimePicker_IrsaliyeDate.Enabled = false;

                        stockProductForm.Show();
                        this.Hide();
                    }
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
                int sid = (int)numericUpDown_stockId.Value;
                int cid = (int)numericUpDown_companyId.Value;
                int tip = (int)numericUpDown_tip.Value;
                string status = comboBox_status.SelectedValue.ToString();
                DateTime irsaliyeDate = dateTimePicker_IrsaliyeDate.Value.Date;
                int irsaliyeNo = (int)numericUpDown_IrsaliyeNo.Value;

                if (stockCompany.editStockProduct(sid, cid, tip, status,irsaliyeDate,irsaliyeNo))
                {
                    MessageBox.Show("Stock Company is edited successfully", "Edit Stock Company", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with genres
                    dataGridView_stockCompany.DataSource = stockProduct.stockProductListWithSid(queryNewRows, lastSid);
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

                if (stockProduct.deleteStockProduct(sid,Int32.Parse(this.clickedPid)))
                {
                    MessageBox.Show("Product is removed successfully", "Remove Product", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with productInfo
                    dataGridView_stockCompany.DataSource = stockProduct.stockProductListWithSid(queryNewRows, lastSid);
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

        private void dataGridView_stockCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clickedPid = dataGridView_stockCompany.CurrentRow.Cells[1].Value.ToString();
        }

        private void button_Done_Click_1(object sender, EventArgs e)
        {
            try
            {

                int sid = (int)numericUpDown_stockId.Value;
                int cid = (int)numericUpDown_companyId.Value;
                int tip = (int)numericUpDown_tip.Value;
                string status = "Confirmed";
                DateTime irsaliyeDate = dateTimePicker_IrsaliyeDate.Value.Date;
                int irsaliyeNo = (int)numericUpDown_IrsaliyeNo.Value;

                if (stockCompany.editStockProduct(sid, cid, tip, status, irsaliyeDate, irsaliyeNo))
                {
                    MessageBox.Show("Products are Confirmed", "Confirm", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Products are not Confirmed", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                StockCompanyForm stockCompanyForm = new StockCompanyForm(this.form1);
                this.Close();
                stockCompanyForm.Show();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_addProduct_Click(object sender, EventArgs e)
        {
            try
            {
                stockProductForm = new StockProductForm(this,null);
                int cid = (int)numericUpDown_companyId.Value;
                int tip = (int)numericUpDown_tip.Value;
                string status = comboBox_status.SelectedValue.ToString();
                DateTime irsaliyeDate = dateTimePicker_IrsaliyeDate.Value.Date;
                int irsaliyeNo = (int)numericUpDown_IrsaliyeNo.Value;

                if (stockCompany.editStockProduct(sid, cid, tip, status, irsaliyeDate, irsaliyeNo))
                {
                    MessageBox.Show("Company is added to the Stock Successfully!", "Company Added Successfully", MessageBoxButtons.OK);

                    stockProductForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have to add Company First", "Add Company", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void dataGridView_stockCompany_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addingStatus()
        {
            // Bind combobox to dictionary
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("Prepared","Prepared");
            comboBox_status.DataSource = new BindingSource(status, null);
            comboBox_status.DisplayMember = "Value";
            comboBox_status.ValueMember = "Key";

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<string, string>)comboBox_status.SelectedItem).Value;
            comboBox_status.SelectedIndex = -1;
        }
    }
}
