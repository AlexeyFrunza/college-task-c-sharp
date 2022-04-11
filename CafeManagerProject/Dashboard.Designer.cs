
namespace CafeManagerProject
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.LinkLabel();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.removeItemBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateItemBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addItemBtn = new Guna.UI2.WinForms.Guna2Button();
            this.placeOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_UpdateItem1 = new CafeManagerProject.AllUserControls.UC_UpdateItem();
            this.uC_PlaceOrder1 = new CafeManagerProject.AllUserControls.UC_PlaceOrder();
            this.uC_AddItem1 = new CafeManagerProject.AllUserControls.UC_AddItem();
            this.uC_Welcome1 = new CafeManagerProject.AllUserControls.UC_Welcome();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_RemoveItem1 = new CafeManagerProject.AllUserControls.UC_RemoveItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.removeItemBtn);
            this.panel1.Controls.Add(this.updateItemBtn);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Controls.Add(this.placeOrderBtn);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 586);
            this.panel1.TabIndex = 0;
            // 
            // logOutBtn
            // 
            this.logOutBtn.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.logOutBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.8F);
            this.logOutBtn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.logOutBtn.Location = new System.Drawing.Point(69, 489);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(61, 20);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.TabStop = true;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOutBtn_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.guna2Transition1.SetDecoration(this.exitButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(9, 12);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(29, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeItemBtn.BorderRadius = 20;
            this.removeItemBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.removeItemBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.removeItemBtn.CheckedState.ForeColor = System.Drawing.Color.SteelBlue;
            this.removeItemBtn.CheckedState.Parent = this.removeItemBtn;
            this.removeItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeItemBtn.CustomImages.Parent = this.removeItemBtn;
            this.guna2Transition1.SetDecoration(this.removeItemBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.removeItemBtn.FillColor = System.Drawing.Color.Transparent;
            this.removeItemBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.removeItemBtn.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.removeItemBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.removeItemBtn.HoverState.Parent = this.removeItemBtn;
            this.removeItemBtn.Location = new System.Drawing.Point(9, 246);
            this.removeItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.ShadowDecoration.Parent = this.removeItemBtn;
            this.removeItemBtn.Size = new System.Drawing.Size(193, 37);
            this.removeItemBtn.TabIndex = 3;
            this.removeItemBtn.Text = "Remove items";
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // updateItemBtn
            // 
            this.updateItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateItemBtn.BorderRadius = 20;
            this.updateItemBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.updateItemBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.updateItemBtn.CheckedState.ForeColor = System.Drawing.Color.SteelBlue;
            this.updateItemBtn.CheckedState.Parent = this.updateItemBtn;
            this.updateItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateItemBtn.CustomImages.Parent = this.updateItemBtn;
            this.guna2Transition1.SetDecoration(this.updateItemBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateItemBtn.FillColor = System.Drawing.Color.Transparent;
            this.updateItemBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.updateItemBtn.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.updateItemBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.updateItemBtn.HoverState.Parent = this.updateItemBtn;
            this.updateItemBtn.Location = new System.Drawing.Point(9, 189);
            this.updateItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateItemBtn.Name = "updateItemBtn";
            this.updateItemBtn.ShadowDecoration.Parent = this.updateItemBtn;
            this.updateItemBtn.Size = new System.Drawing.Size(193, 37);
            this.updateItemBtn.TabIndex = 2;
            this.updateItemBtn.Text = "Update items";
            this.updateItemBtn.Click += new System.EventHandler(this.updateItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.addItemBtn.BorderRadius = 20;
            this.addItemBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addItemBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.addItemBtn.CheckedState.ForeColor = System.Drawing.Color.SteelBlue;
            this.addItemBtn.CheckedState.Parent = this.addItemBtn;
            this.addItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemBtn.CustomImages.Parent = this.addItemBtn;
            this.guna2Transition1.SetDecoration(this.addItemBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addItemBtn.FillColor = System.Drawing.Color.Transparent;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.addItemBtn.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.addItemBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.addItemBtn.HoverState.Parent = this.addItemBtn;
            this.addItemBtn.Location = new System.Drawing.Point(9, 132);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.ShadowDecoration.Parent = this.addItemBtn;
            this.addItemBtn.Size = new System.Drawing.Size(193, 37);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add items";
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.placeOrderBtn.BorderRadius = 20;
            this.placeOrderBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.placeOrderBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.placeOrderBtn.CheckedState.ForeColor = System.Drawing.Color.SteelBlue;
            this.placeOrderBtn.CheckedState.Parent = this.placeOrderBtn;
            this.placeOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeOrderBtn.CustomImages.Parent = this.placeOrderBtn;
            this.guna2Transition1.SetDecoration(this.placeOrderBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.placeOrderBtn.FillColor = System.Drawing.Color.Transparent;
            this.placeOrderBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.placeOrderBtn.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.placeOrderBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.placeOrderBtn.HoverState.Parent = this.placeOrderBtn;
            this.placeOrderBtn.Location = new System.Drawing.Point(9, 78);
            this.placeOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.ShadowDecoration.Parent = this.placeOrderBtn;
            this.placeOrderBtn.Size = new System.Drawing.Size(193, 37);
            this.placeOrderBtn.TabIndex = 0;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.uC_RemoveItem1);
            this.panel2.Controls.Add(this.uC_UpdateItem1);
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_AddItem1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 586);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 0;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.guna2Transition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 0;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // uC_UpdateItem1
            // 
            this.uC_UpdateItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Transition1.SetDecoration(this.uC_UpdateItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItem1.Location = new System.Drawing.Point(1, 0);
            this.uC_UpdateItem1.Name = "uC_UpdateItem1";
            this.uC_UpdateItem1.Size = new System.Drawing.Size(603, 581);
            this.uC_UpdateItem1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uC_PlaceOrder1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 3);
            this.uC_PlaceOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(603, 581);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_AddItem1
            // 
            this.uC_AddItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Transition1.SetDecoration(this.uC_AddItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddItem1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AddItem1.Name = "uC_AddItem1";
            this.uC_AddItem1.Size = new System.Drawing.Size(605, 586);
            this.uC_AddItem1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(-2, -2);
            this.uC_Welcome1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(605, 586);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 0;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Transition1.SetDecoration(this.uC_RemoveItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(603, 581);
            this.uC_RemoveItem1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button placeOrderBtn;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
        private Guna.UI2.WinForms.Guna2Button removeItemBtn;
        private Guna.UI2.WinForms.Guna2Button updateItemBtn;
        private Guna.UI2.WinForms.Guna2Button addItemBtn;
        private System.Windows.Forms.LinkLabel logOutBtn;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AllUserControls.UC_AddItem uC_AddItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_UpdateItem uC_UpdateItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_RemoveItem uC_RemoveItem1;
    }
}