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
    public partial class CompanyForm : Form
    {
        private string query;
        private Form1 form1;
        private Company company = new Company();
        private CompanyProductForm companyProductForm;
        private int cid;
        public CompanyForm(Form1 form1)
        {
            query = "SELECT * FROM company ORDER BY cid ASC";
            this.form1 = form1;
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {

            form1.Hide();

            // Show table in dataGridView
            dataGridView_company.DataSource = company.companyList(query);

            // customize datagridView header
            dataGridView_company.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_company.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
            dataGridView_company.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_company.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Regular);


            dataGridView_company.EnableHeadersVisualStyles = false;
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

        private void button_add_Click(object sender, EventArgs e)
        {
            //int cid = (int) company.companyList(query).;
            string cname = textBox_comapnyName.Text;

            if (company.addCompany(cname))
            {
                dataGridView_company.DataSource = company.companyList(query);
                MessageBox.Show(cname + " is added!", "Compnay Added Successfully", MessageBoxButtons.OK);

                int row = company.companyList(query).Rows.Count - 1;
                cid = Int32.Parse(dataGridView_company.Rows[row].Cells[0].Value.ToString());
            }

            companyProductForm = new CompanyProductForm(this);
            companyProductForm.Show();
            this.Hide();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDown_Id.Value;
                string cname = textBox_comapnyName.Text;


                if (company.editCompany(id, cname))
                {
                    MessageBox.Show("Comapny is edited successfully", "Edit Comapny", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with genres
                    dataGridView_company.DataSource = company.companyList(query);
                }
                else
                {
                    MessageBox.Show("Company is not edited", "Company Edited Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int cid = (int) numericUpDown_Id.Value;

                if (company.deleteCompany(cid))
                {
                    MessageBox.Show("Company is removed successfully", "Remove Company", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with productInfo
                    dataGridView_company.DataSource = company.companyList(query);
                }
                else
                {
                    MessageBox.Show("Company is not removed", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }

        private void dataGridView_company_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_Id.Text = dataGridView_company.CurrentRow.Cells[0].Value.ToString();
            textBox_comapnyName.Text = dataGridView_company.CurrentRow.Cells[1].Value.ToString();
        }

        public int getCid()
        {
            return this.cid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cid = (int)numericUpDown_Id.Value;
                string cname = textBox_comapnyName.Text;

                companyProductForm = new CompanyProductForm(this);
                companyProductForm.Show();
                this.Hide();
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }
    }
}
