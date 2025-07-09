namespace Tugasucp1
{
    partial class Form2
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
            this.txtIDDonatur = new System.Windows.Forms.TextBox();
            this.txtNamaDonatur = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.NamaDonatur = new System.Windows.Forms.Label();
            this.IDDonatur = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.Label();
            this.NoTelp = new System.Windows.Forms.Label();
            this.dgvDonatur = new System.Windows.Forms.DataGridView();
            this.Donatur = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonatur)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDDonatur
            // 
            this.txtIDDonatur.Location = new System.Drawing.Point(192, 99);
            this.txtIDDonatur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDDonatur.Name = "txtIDDonatur";
            this.txtIDDonatur.Size = new System.Drawing.Size(303, 26);
            this.txtIDDonatur.TabIndex = 0;
            // 
            // txtNamaDonatur
            // 
            this.txtNamaDonatur.Location = new System.Drawing.Point(192, 162);
            this.txtNamaDonatur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamaDonatur.Name = "txtNamaDonatur";
            this.txtNamaDonatur.Size = new System.Drawing.Size(303, 26);
            this.txtNamaDonatur.TabIndex = 1;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(192, 231);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(303, 26);
            this.txtAlamat.TabIndex = 2;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(192, 292);
            this.txtNoTelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(303, 26);
            this.txtNoTelp.TabIndex = 3;
            // 
            // NamaDonatur
            // 
            this.NamaDonatur.AutoSize = true;
            this.NamaDonatur.Location = new System.Drawing.Point(47, 170);
            this.NamaDonatur.Name = "NamaDonatur";
            this.NamaDonatur.Size = new System.Drawing.Size(113, 20);
            this.NamaDonatur.TabIndex = 4;
            this.NamaDonatur.Text = "Nama Donatur";
            // 
            // IDDonatur
            // 
            this.IDDonatur.AutoSize = true;
            this.IDDonatur.Location = new System.Drawing.Point(47, 106);
            this.IDDonatur.Name = "IDDonatur";
            this.IDDonatur.Size = new System.Drawing.Size(86, 20);
            this.IDDonatur.TabIndex = 5;
            this.IDDonatur.Text = "lD Donatur";
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Location = new System.Drawing.Point(47, 235);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(59, 20);
            this.Alamat.TabIndex = 6;
            this.Alamat.Text = "Alamat";
            // 
            // NoTelp
            // 
            this.NoTelp.AutoSize = true;
            this.NoTelp.Location = new System.Drawing.Point(47, 300);
            this.NoTelp.Name = "NoTelp";
            this.NoTelp.Size = new System.Drawing.Size(90, 20);
            this.NoTelp.TabIndex = 7;
            this.NoTelp.Text = "No Telepon";
            // 
            // dgvDonatur
            // 
            this.dgvDonatur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonatur.Location = new System.Drawing.Point(51, 348);
            this.dgvDonatur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDonatur.Name = "dgvDonatur";
            this.dgvDonatur.RowHeadersWidth = 51;
            this.dgvDonatur.RowTemplate.Height = 24;
            this.dgvDonatur.Size = new System.Drawing.Size(450, 188);
            this.dgvDonatur.TabIndex = 8;
            // 
            // Donatur
            // 
            this.Donatur.AutoSize = true;
            this.Donatur.Location = new System.Drawing.Point(328, 49);
            this.Donatur.Name = "Donatur";
            this.Donatur.Size = new System.Drawing.Size(67, 20);
            this.Donatur.TabIndex = 9;
            this.Donatur.Text = "Donatur";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(663, 98);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(84, 29);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Add";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(663, 145);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 29);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(663, 195);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(663, 248);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 29);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_click);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(663, 325);
            this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(84, 29);
            this.btnBACK.TabIndex = 14;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.Donatur);
            this.Controls.Add(this.dgvDonatur);
            this.Controls.Add(this.NoTelp);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.IDDonatur);
            this.Controls.Add(this.NamaDonatur);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNamaDonatur);
            this.Controls.Add(this.txtIDDonatur);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonatur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDDonatur;
        private System.Windows.Forms.TextBox txtNamaDonatur;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.Label NamaDonatur;
        private System.Windows.Forms.Label IDDonatur;
        private System.Windows.Forms.Label Alamat;
        private System.Windows.Forms.Label NoTelp;
        private System.Windows.Forms.DataGridView dgvDonatur;
        private System.Windows.Forms.Label Donatur;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBACK;
    }
}