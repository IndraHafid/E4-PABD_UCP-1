namespace Tugasucp1
{
    partial class Form4
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
            this.dgvDonasi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Jumlah = new System.Windows.Forms.Label();
            this.Jenis_Barang = new System.Windows.Forms.Label();
            this.txtJumlahBarang = new System.Windows.Forms.TextBox();
            this.IDDonatur = new System.Windows.Forms.Label();
            this.IDDonasi = new System.Windows.Forms.Label();
            this.txtIDDonasi = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.Analyz = new System.Windows.Forms.Button();
            this.cmbJenisBarang = new System.Windows.Forms.ComboBox();
            this.cmbIDDonatur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonasi
            // 
            this.dgvDonasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonasi.Location = new System.Drawing.Point(72, 318);
            this.dgvDonasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDonasi.Name = "dgvDonasi";
            this.dgvDonasi.RowHeadersWidth = 51;
            this.dgvDonasi.RowTemplate.Height = 24;
            this.dgvDonasi.Size = new System.Drawing.Size(620, 188);
            this.dgvDonasi.TabIndex = 31;
            this.dgvDonasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonasi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Donasi";
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSize = true;
            this.Jumlah.Location = new System.Drawing.Point(85, 259);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(60, 20);
            this.Jumlah.TabIndex = 27;
            this.Jumlah.Text = "Jumlah";
            // 
            // Jenis_Barang
            // 
            this.Jenis_Barang.AutoSize = true;
            this.Jenis_Barang.Location = new System.Drawing.Point(85, 216);
            this.Jenis_Barang.Name = "Jenis_Barang";
            this.Jenis_Barang.Size = new System.Drawing.Size(102, 20);
            this.Jenis_Barang.TabIndex = 26;
            this.Jenis_Barang.Text = "Jenis Barang";
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.Location = new System.Drawing.Point(216, 253);
            this.txtJumlahBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.Size = new System.Drawing.Size(235, 26);
            this.txtJumlahBarang.TabIndex = 25;
            // 
            // IDDonatur
            // 
            this.IDDonatur.AutoSize = true;
            this.IDDonatur.Location = new System.Drawing.Point(85, 92);
            this.IDDonatur.Name = "IDDonatur";
            this.IDDonatur.Size = new System.Drawing.Size(88, 20);
            this.IDDonatur.TabIndex = 22;
            this.IDDonatur.Text = "ID Donatur";
            // 
            // IDDonasi
            // 
            this.IDDonasi.AutoSize = true;
            this.IDDonasi.Location = new System.Drawing.Point(85, 133);
            this.IDDonasi.Name = "IDDonasi";
            this.IDDonasi.Size = new System.Drawing.Size(80, 20);
            this.IDDonasi.TabIndex = 21;
            this.IDDonasi.Text = "ID Donasi";
            // 
            // txtIDDonasi
            // 
            this.txtIDDonasi.Location = new System.Drawing.Point(216, 125);
            this.txtIDDonasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDDonasi.Name = "txtIDDonasi";
            this.txtIDDonasi.Size = new System.Drawing.Size(235, 26);
            this.txtIDDonasi.TabIndex = 20;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(729, 196);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(84, 29);
            this.Refresh.TabIndex = 19;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(729, 160);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(84, 29);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(729, 124);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(84, 29);
            this.Update.TabIndex = 17;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(729, 88);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 29);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(729, 301);
            this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(84, 29);
            this.btnBACK.TabIndex = 32;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // Analyz
            // 
            this.Analyz.Location = new System.Drawing.Point(729, 234);
            this.Analyz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Analyz.Name = "Analyz";
            this.Analyz.Size = new System.Drawing.Size(84, 29);
            this.Analyz.TabIndex = 33;
            this.Analyz.Text = "Analyz";
            this.Analyz.UseVisualStyleBackColor = true;
            this.Analyz.Click += new System.EventHandler(this.BtnAnalisis_Click);
            // 
            // cmbJenisBarang
            // 
            this.cmbJenisBarang.FormattingEnabled = true;
            this.cmbJenisBarang.Location = new System.Drawing.Point(216, 208);
            this.cmbJenisBarang.Name = "cmbJenisBarang";
            this.cmbJenisBarang.Size = new System.Drawing.Size(235, 28);
            this.cmbJenisBarang.TabIndex = 35;
            // 
            // cmbIDDonatur
            // 
            this.cmbIDDonatur.FormattingEnabled = true;
            this.cmbIDDonatur.Location = new System.Drawing.Point(216, 85);
            this.cmbIDDonatur.Name = "cmbIDDonatur";
            this.cmbIDDonatur.Size = new System.Drawing.Size(235, 28);
            this.cmbIDDonatur.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nama Barang";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(216, 163);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(235, 26);
            this.txtNamaBarang.TabIndex = 37;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.cmbIDDonatur);
            this.Controls.Add(this.cmbJenisBarang);
            this.Controls.Add(this.Analyz);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.dgvDonasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.Jenis_Barang);
            this.Controls.Add(this.txtJumlahBarang);
            this.Controls.Add(this.IDDonatur);
            this.Controls.Add(this.IDDonasi);
            this.Controls.Add(this.txtIDDonasi);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Jumlah;
        private System.Windows.Forms.Label Jenis_Barang;
        private System.Windows.Forms.TextBox txtJumlahBarang;
        private System.Windows.Forms.Label IDDonatur;
        private System.Windows.Forms.Label IDDonasi;
        private System.Windows.Forms.TextBox txtIDDonasi;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button Analyz;
        private System.Windows.Forms.ComboBox cmbJenisBarang;
        private System.Windows.Forms.ComboBox cmbIDDonatur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaBarang;
    }
}