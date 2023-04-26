namespace GUI_QLNT
{
    partial class FrmLogin
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txUser = new System.Windows.Forms.TextBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbUser.Location = new System.Drawing.Point(63, 71);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(182, 39);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tài Khoản:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbPass.Location = new System.Drawing.Point(63, 157);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(171, 39);
            this.lbPass.TabIndex = 0;
            this.lbPass.Text = "Mật Khẩu:";
            // 
            // txUser
            // 
            this.txUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txUser.Location = new System.Drawing.Point(285, 71);
            this.txUser.Margin = new System.Windows.Forms.Padding(4);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(313, 45);
            this.txUser.TabIndex = 0;
            this.txUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txUser_KeyDown);
            // 
            // txPass
            // 
            this.txPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txPass.Location = new System.Drawing.Point(285, 154);
            this.txPass.Margin = new System.Windows.Forms.Padding(4);
            this.txPass.Name = "txPass";
            this.txPass.PasswordChar = '*';
            this.txPass.Size = new System.Drawing.Size(313, 45);
            this.txPass.TabIndex = 1;
            this.txPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txUser_KeyDown);
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btLogin.Location = new System.Drawing.Point(433, 240);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(165, 60);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Đăng Nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(712, 333);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txPass);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Button btLogin;
    }
}

