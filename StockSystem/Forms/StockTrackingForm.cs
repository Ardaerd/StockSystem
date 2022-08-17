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
    public partial class StockTrackingForm : Form
    {
        private StockTracking stockTracking;
        private Form1 form1;
        private StockProductForm stockProductForm;
        private StockCompanyForm stockCompanyForm;
        private int sid;
        private int cid;
        private int tip;
        private string status;
        private int irsaliyeNo;
        private string irsaliyeDate;

        public StockTrackingForm(Form1 form1)
        {
            InitializeComponent();
            stockTracking = new StockTracking();
            this.form1 = form1;
            addingCompany();
        }

        private void button_stock_Click(object sender, EventArgs e)
        {
            try
            {
                string startingDate = dateTimePicker_startingDate.Value.Date.ToString("dd/MM/yyyy");
                string endingDate = dateTimePicker_endingDate.Value.Date.ToString("dd/MM/yyyy");
                string companyName = "";



                if (comboBox_companyName.SelectedItem != null)
                {
                    companyName = comboBox_companyName.SelectedValue.ToString();
                }

                Console.WriteLine(startingDate);

                // Show table in dataGridView
                dataGridView_stock.DataSource = stockTracking.stockTrackingList(startingDate, endingDate, companyName);

                int column = dataGridView_stock.Columns.Count - 1;

                for (int i = 0; i < column; i++)
                {
                    dataGridView_stock.Columns[i].ReadOnly = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void StockTrackingForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_startingDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_startingDate.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_startingDate.Value = DateTime.Now;

            dateTimePicker_endingDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_endingDate.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_endingDate.Value = DateTime.Now;

            // customize datagridView header
            dataGridView_stock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_stock.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            dataGridView_stock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_stock.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Regular);


            dataGridView_stock.EnableHeadersVisualStyles = false;
            int column = dataGridView_stock.Columns.Count - 1;

            for (int i = 0; i < column; i++)
            {
                dataGridView_stock.Columns[i].ReadOnly = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(57, 91, 100);
        }

        private void addingCompany()
        {
            string query = "SELECT cname FROM company";

            comboBox_companyName.DataSource = stockTracking.companyNameList(query);
            comboBox_companyName.DisplayMember = "cname";
            comboBox_companyName.ValueMember = "cname";
            comboBox_companyName.SelectedIndex = -1;
        }

        private void dataGridView_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                stockCompanyForm = new StockCompanyForm(form1, this);

                this.sid = Int32.Parse(dataGridView_stock.CurrentRow.Cells[0].Value.ToString());
                this.cid = Int32.Parse(dataGridView_stock.CurrentRow.Cells[1].Value.ToString());
                this.tip = Int32.Parse(dataGridView_stock.CurrentRow.Cells[3].Value.ToString());
                this.status = dataGridView_stock.CurrentRow.Cells[4].Value.ToString();
                this.irsaliyeDate = dataGridView_stock.CurrentRow.Cells[6].Value.ToString();
                this.irsaliyeNo = Int32.Parse(dataGridView_stock.CurrentRow.Cells[7].Value.ToString());

                stockCompanyForm.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        public int getSid()
        {
            return sid;
        }

        public int getCid()
        {
            return this.cid;
        }

        public int getTip()
        {
            return this.tip;
        }

        public string getStatus()
        {
            return this.status;
        }

        public int getIrsaliyeNo()
        {
            return this.irsaliyeNo;
        }

        public string getIrsaliyeDate()
        {
            return this.irsaliyeDate;
        }
    }
}
