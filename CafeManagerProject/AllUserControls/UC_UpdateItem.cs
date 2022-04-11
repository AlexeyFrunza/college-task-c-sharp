﻿using System;
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
    public partial class UC_UpdateItem : UserControl
    {
        Database db = new Database();
        String query;
        public UC_UpdateItem()
        {
            InitializeComponent();
        }

        private void UC_UpdateItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = db.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like'"+txtSearchItem.Text+"%'";
            DataSet ds = db.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            double price = double.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set name='" + txtName.Text + "',category='" + txtCategory.Text + "', price=" + txtPrice.Text + " where id=" + id + "";
            db.setData(query);
            loadData();
            txtCategory.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }
    }
}