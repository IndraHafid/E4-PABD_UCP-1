namespace Tugasucp1
{
    partial class Form1
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
            this.txtNamaAdmin = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNamaAdmin
            // 
            this.txtNamaAdmin.Location = new System.Drawing.Point(308, 138);
            this.txtNamaAdmin.Name = "txtNamaAdmin";
            this.txtNamaAdmin.Size = new System.Drawing.Size(271, 22);
            this.txtNamaAdmin.TabIndex = 0;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(308, 190);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(271, 22);
            this.txtPasswd.TabIndex = 1;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Location = new System.Drawing.Point(217, 144);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(85, 16);
            this.labelAdmin.TabIndex = 2;
            this.labelAdmin.Text = "Nama Admin";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(217, 196);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(367, 253);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtNamaAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamaAdmin;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btnLogin;
    }
}

