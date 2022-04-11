
namespace CafeManagerProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guestLogin = new System.Windows.Forms.LinkLabel();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.usernameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(76, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(76, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // guestLogin
            // 
            this.guestLogin.AutoSize = true;
            this.guestLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.guestLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guestLogin.Location = new System.Drawing.Point(132, 452);
            this.guestLogin.Name = "guestLogin";
            this.guestLogin.Size = new System.Drawing.Size(130, 20);
            this.guestLogin.TabIndex = 6;
            this.guestLogin.TabStop = true;
            this.guestLogin.Text = "Continue as guest";
            this.guestLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guestLogin_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 10;
            this.loginButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.loginButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.loginButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.loginButton.CheckedState.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(127, 407);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(144, 33);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Log in";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.SteelBlue;
            this.usernameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameInput.DefaultText = "";
            this.usernameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInput.DisabledState.Parent = this.usernameInput;
            this.usernameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInput.FillColor = System.Drawing.Color.SteelBlue;
            this.usernameInput.FocusedState.BorderColor = System.Drawing.Color.White;
            this.usernameInput.FocusedState.Parent = this.usernameInput;
            this.usernameInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.usernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.usernameInput.HoverState.BorderColor = System.Drawing.Color.White;
            this.usernameInput.HoverState.Parent = this.usernameInput;
            this.usernameInput.Location = new System.Drawing.Point(80, 288);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PasswordChar = '\0';
            this.usernameInput.PlaceholderText = "";
            this.usernameInput.SelectedText = "";
            this.usernameInput.ShadowDecoration.Parent = this.usernameInput;
            this.usernameInput.Size = new System.Drawing.Size(231, 28);
            this.usernameInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.usernameInput.TabIndex = 9;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.SteelBlue;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.Parent = this.passwordInput;
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.FillColor = System.Drawing.Color.SteelBlue;
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.White;
            this.passwordInput.FocusedState.Parent = this.passwordInput;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.passwordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.White;
            this.passwordInput.HoverState.Parent = this.passwordInput;
            this.passwordInput.Location = new System.Drawing.Point(80, 352);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.PlaceholderText = "";
            this.passwordInput.SelectedText = "";
            this.passwordInput.ShadowDecoration.Parent = this.passwordInput;
            this.passwordInput.Size = new System.Drawing.Size(231, 28);
            this.passwordInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passwordInput.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagerProject.Properties.Resources.lock_icon_transparent_25;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(159, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(399, 601);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.guestLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel guestLogin;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2TextBox usernameInput;
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
    }
}

