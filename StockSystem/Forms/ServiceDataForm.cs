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
    public partial class ServiceDataForm : Form
    {
        private Form1 form;
        private SoldProduct soldProduct;
        private string query = "SELECT * FROM soldProduct";
        public ServiceDataForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;

            try
            {
                soldProduct = new SoldProduct();

                if (soldProduct.deleteSoldProduct())
                {
                    Console.WriteLine("Old data is deleted !");
                }
                else
                {
                    MessageBox.Show("Old data couldn't delete!", "Server", MessageBoxButtons.OK);

                }

                SoldProducts_API soldProducts = new SoldProducts_API();

                List<SoldProductsInfo_API> Info = soldProducts.Get_SoldProducts();

                foreach (SoldProductsInfo_API info in Info)
                {
                    soldProducts.setPid(info.pid);
                    soldProducts.setPrice(info.price); 
                    soldProducts.setQuantity(info.quantity);
                    soldProducts.Set_cashRegister_No(info.cashRegister_No);
                    soldProducts.Set_document_No(info.document_No);
                    soldProducts.setBarcode(info.barcode);

                    DateTime irsaliyeDate = DateTime.ParseExact(info.irsaliyeDate, "dd/MM/yyyy", null);
                    soldProducts.Set_irsaliyeDate(irsaliyeDate);

                    if (soldProduct.addSoldProduct(soldProducts.getPid(), soldProducts.getPrice(), soldProducts.getQuantity(), soldProducts.getBarcode(), soldProducts.Get_cashRegister_No(), soldProducts.Get_document_No(), soldProducts.get_irsaliyeDate()))
                    {
                        Console.WriteLine("Data is recived Successfully from the Server!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
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

        private void ServerDataForm_Load(object sender, EventArgs e)
        {

            dataGridView_ServerData.DataSource = soldProduct.getSoldProductsList(query);

            // customize datagridView header
            dataGridView_ServerData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_ServerData.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            dataGridView_ServerData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_ServerData.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Regular);


            dataGridView_ServerData.EnableHeadersVisualStyles = false;

            int column = dataGridView_ServerData.Columns.Count - 1;

            for (int i = 0; i < column; i++)
            {
                dataGridView_ServerData.Columns[i].ReadOnly = true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
