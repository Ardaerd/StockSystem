﻿using System;
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
        private string query = "SELECT * FROM stockCompany_view ORDER BY sid ASC";
        private string query_2 = "SELECT * FROM stockProduct_view ORDER BY sid ASC";
        private int sid;
        private int cid;
        public StockCompanyForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            stockCompany = new StockCompany();
            stockProductForm = new StockProductForm(this);
            stockProduct = new StockProduct();
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
            dataGridView_stockCompany.DataSource = stockProduct.stockProductList(query_2);

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
                int cid = (int)numericUpDown_companyId.Value;
                int tip = (int)numericUpDown_tip.Value;
                string status = textBox_status.Text;
                String irsaliyeDate = dateTimePicker_IrsaliyeDate.Value.Date.ToString("dd/MM/yyyy");
                int irsaliyeNo = (int)numericUpDown_IrsaliyeNo.Value;

                DateTime date_2 = DateTime.ParseExact(irsaliyeDate, @"d/M/yyyy",
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

                        int row = stockCompany.stockCompanyList(query).Rows.Count - 1;
                        this.sid = Int32.Parse(dataGridView_stockCompany.Rows[row].Cells[0].Value.ToString());
                        this.cid = Int32.Parse(dataGridView_stockCompany.Rows[row].Cells[1].Value.ToString());
                    }
                }

                stockProductForm.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
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
                    dataGridView_stockCompany.DataSource = stockCompany.stockCompanyList(query);
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
                    dataGridView_stockCompany.DataSource = stockCompany.stockCompanyList(query);
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

        private void dataGridView_stockCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_stockId.Text = dataGridView_stockCompany.CurrentRow.Cells[0].Value.ToString();
            numericUpDown_companyId.Text = dataGridView_stockCompany.CurrentRow.Cells[1].Value.ToString();
            numericUpDown_tip.Text = dataGridView_stockCompany.CurrentRow.Cells[2].Value.ToString();
            textBox_status.Text = dataGridView_stockCompany.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_IrsaliyeDate.Text = dataGridView_stockCompany.CurrentRow.Cells[5].Value.ToString();
            numericUpDown_IrsaliyeNo.Text = dataGridView_stockCompany.CurrentRow.Cells[6].Value.ToString();

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
    }
}
