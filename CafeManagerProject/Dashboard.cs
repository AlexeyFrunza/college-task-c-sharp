using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagerProject
{
    public partial class Dashboard : Form
    {
        public Dashboard(String user)
        {
            InitializeComponent();
            if (user == "guest")
            {
                addItemBtn.Hide();
                updateItemBtn.Hide();
                removeItemBtn.Hide();
            }
            else if (user == "admin")
            {
                addItemBtn.Show();
                updateItemBtn.Show();
                removeItemBtn.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = false;
            uC_UpdateItem1.Visible = false;
            uC_AddItem1.Visible = false;
            uC_PlaceOrder1.Visible = false;
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {

            uC_AddItem1.Visible = true;
            uC_AddItem1.BringToFront();
        }

        private void updateItemBtn_Click(object sender, EventArgs e)
        {
            uC_UpdateItem1.Visible = true;
            uC_UpdateItem1.BringToFront();
        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }
    }
}
