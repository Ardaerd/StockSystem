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
    public partial class SelectCompanyForm : Form
    {
        private string query;
        private CompanyProductForm companyProductForm = null;
        private StockCompanyForm stockCompanyForm = null;
        private string id;
        private Company company;
        public SelectCompanyForm(CompanyProductForm companyProductForm, StockCompanyForm stockCompanyForm)
        {
            this.companyProductForm = companyProductForm;
            query = "SELECT * FROM company";
            company = new Company();
            InitializeComponent();
            this.stockCompanyForm = stockCompanyForm;
        }

        private void SelectCompanyForm_Load(object sender, EventArgs e)
        {
            // Show table in dataGridView
            dataGridView_selectCompany.DataSource = company.companyList(query);

            // customize datagridView header
            dataGridView_selectCompany.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_selectCompany.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 10, FontStyle.Bold);
            dataGridView_selectCompany.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_selectCompany.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Regular);


            dataGridView_selectCompany.EnableHeadersVisualStyles = false;
        }

        private void button_selectClose_Click(object sender, EventArgs e)
        {
            if (stockCompanyForm != null)
            {
                stockCompanyForm.numericUpDown_companyId.Text = id;
            }

            if (companyProductForm != null)
            {
                companyProductForm.numericUpDown_companyId.Text = id;
            }
            this.Close();
        }

        private void dataGridView_selectCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dataGridView_selectCompany.CurrentRow.Cells[0].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(57, 91, 100);
        }
    }
}
