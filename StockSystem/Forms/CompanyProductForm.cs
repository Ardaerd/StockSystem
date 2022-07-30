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
    public partial class CompanyProductForm : Form
    {
        private SelectProductForm selectProductForm;
        private SelectCompanyForm selectCompanyForm;
        private CompanyProduct companyProduct;
        private CompanyForm companyForm;
        private string query;
        private int cid;
        public CompanyProductForm(CompanyForm companyForm)
        {
            InitializeComponent();
            query = "SELECT * FROM companyProduct_view";
            this.companyForm = companyForm;
            companyProduct = new CompanyProduct();
            cid = this.companyForm.getCid();
        }

        private void button_selectProduct_Click(object sender, EventArgs e)
        {
            selectProductForm = new SelectProductForm(null, this,null);
            selectProductForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            companyForm.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(57, 91, 100);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int pid = (int)numericUpDown_Id.Value;


            if (companyProduct.addComapnyProduct(pid,cid))
            {
                dataGridView_companyProduct.DataSource = companyProduct.companyProductList(query);
                MessageBox.Show("Company Product pair is added!", "Company Product Added Successfully", MessageBoxButtons.OK);
            }
        }

        private void CompanyProductForm_Load(object sender, EventArgs e)
        {
            // Show table in dataGridView
            dataGridView_companyProduct.DataSource = companyProduct.companyProductList(query);

            // customize datagridView header
            dataGridView_companyProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_companyProduct.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
            dataGridView_companyProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_companyProduct.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Regular);


            dataGridView_companyProduct.EnableHeadersVisualStyles = false;
        }

        private void dataGridView_companyProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_Id.Text = dataGridView_companyProduct.CurrentRow.Cells[0].Value.ToString();
            cid = Int32.Parse(dataGridView_companyProduct.CurrentRow.Cells[2].Value.ToString());
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = (int)numericUpDown_Id.Value;

                if (companyProduct.deleteCompany(pid,cid))
                {
                    MessageBox.Show("Company Product pair is removed successfully", "Remove Company Product", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with productInfo
                    dataGridView_companyProduct.DataSource = companyProduct.companyProductList(query);
                }
                else
                {
                    MessageBox.Show("Company Product pair is not removed", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }
    }
}
