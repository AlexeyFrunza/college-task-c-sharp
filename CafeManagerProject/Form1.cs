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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guestLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("guest");
            ds.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "Admin" && passwordInput.Text == "admin2903")
            {
                Dashboard ds = new Dashboard("admin");
                ds.Show();
                this.Hide();
            }
        }
    }
}
