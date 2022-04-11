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
    public partial class UC_RemoveItem : UserControl
    {
        Database db = new Database();
        String query;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = db.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '"+txtSearch1.Text+"%'";
            DataSet ds = db.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item?","Important Message",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where id ='" + id + "'";
                db.setData(query);
                loadData();
            }
        }

        private void delLabel_Click(object sender, EventArgs e)
        {
            delLabel.Text = "Click on row to delete item";
        }
    }
}
