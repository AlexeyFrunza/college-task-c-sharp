using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagerProject.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        Database db = new Database();
        String query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "'";
            showItemList(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "' and name like '"+txtSearch.Text+"%'";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            listBoxSearch.Items.Clear();
            DataSet ds = db.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.ResetText();
            txtTotal.Clear();
            String text = listBoxSearch.GetItemText(listBoxSearch.SelectedItem);
            txtItemName.Text = text;
            query = "select price from items where name = '" + text + "'";
            DataSet ds = db.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                 
            }
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(txtQuantity.Value.ToString());
            Double price = Double.Parse(txtPrice.Text);
            txtTotal.Text = (quantity * price).ToString();
        }
        protected int n;
        double total = 0;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQuantity.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + double.Parse(txtTotal.Text);
                labelTotalAmount.Text = total.ToString("0.##") + " RUP";
            }
            else
            {
                MessageBox.Show("Minimum quantity is 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        double amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = double.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch
            {

            }
            total -= amount;
            labelTotalAmount.Text = total.ToString("0.##") + " RUP";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Order check";
            printer.SubTitle = string.Format("Date: {0}",DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + labelTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);
            total = 0;
            guna2DataGridView1.Rows.Clear();
            labelTotalAmount.Text = total.ToString("0.##") + " RUP";
        }
    }
}
