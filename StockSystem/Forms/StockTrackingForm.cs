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
    public partial class StockTrackingForm : Form
    {
        private StockTracking stockTracking;
        private Form1 form1;
        public StockTrackingForm(Form1 form1)
        {
            InitializeComponent();
            stockTracking = new StockTracking();
            this.form1 = form1;
        }

        private void button_stock_Click(object sender, EventArgs e)
        {
            DateTime startingDate = dateTimePicker_startingDate.Value;
            DateTime endingDate = dateTimePicker_endingDate.Value;
            string companyName = textBox_companyName.Text;

            string date1 = startingDate.ToString("dd-MM-yyyy");
            string date2 = endingDate.ToString("dd-MM-yyyy");
            // Show table in dataGridView
            dataGridView_stock.DataSource = stockTracking.stockTrackingList(date1,date2,companyName);
        }

        private void StockTrackingForm_Load(object sender, EventArgs e)
        {
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
            textBox_companyName.Text = dataGridView_stock.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
