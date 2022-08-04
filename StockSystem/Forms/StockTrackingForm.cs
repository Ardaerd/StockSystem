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
        public StockTrackingForm(Form1 form1)
        {
            InitializeComponent();
            stockTracking = new StockTracking();
            this.form1 = form1;
            addingCompany();
        }

        private void button_stock_Click(object sender, EventArgs e)
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
            dataGridView_stock.DataSource = stockTracking.stockTrackingList(startingDate,endingDate,companyName);
        }

        private void StockTrackingForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_startingDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_startingDate.CustomFormat = "dd/MM/yyyy";

            dateTimePicker_endingDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_endingDate.CustomFormat = "dd/MM/yyyy";

            // customize datagridView header
            dataGridView_stock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_stock.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            dataGridView_stock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_stock.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Regular);


            dataGridView_stock.EnableHeadersVisualStyles = false;
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

        private void dataGridView_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void addingCompany()
        {
            string query = "SELECT cname FROM company";

            comboBox_companyName.DataSource = stockTracking.companyNameList(query);
            comboBox_companyName.DisplayMember = "cname";
            comboBox_companyName.ValueMember = "cname";
            comboBox_companyName.SelectedIndex = -1;
        }
    }
}
