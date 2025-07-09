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
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.IDDonatur = new System.Windows.Forms.Label();
            this.IDDonasi = new System.Windows.Forms.Label();
            this.txtIDDonasi = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnAnalis = new System.Windows.Forms.Button();
            this.cmbJenisBarang = new System.Windows.Forms.ComboBox();
            this.cmbIDDonatur = new System.Windows.Forms.ComboBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonasi
            // 
            this.dgvDonasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonasi.Location = new System.Drawing.Point(36, 255);
            this.dgvDonasi.Name = "dgvDonasi";
            this.dgvDonasi.RowHeadersWidth = 51;
            this.dgvDonasi.RowTemplate.Height = 24;
            this.dgvDonasi.Size = new System.Drawing.Size(542, 160);
            this.dgvDonasi.TabIndex = 31;
            this.dgvDonasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonasi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Donasi";
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSize = true;
            this.Jumlah.Location = new System.Drawing.Point(124, 208);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(50, 16);
            this.Jumlah.TabIndex = 27;
            this.Jumlah.Text = "Jumlah";
            // 
            // Jenis_Barang
            // 
            this.Jenis_Barang.AutoSize = true;
            this.Jenis_Barang.Location = new System.Drawing.Point(88, 146);
            this.Jenis_Barang.Name = "Jenis_Barang";
            this.Jenis_Barang.Size = new System.Drawing.Size(86, 16);
            this.Jenis_Barang.TabIndex = 26;
            this.Jenis_Barang.Text = "Jenis Barang";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(187, 208);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(250, 22);
            this.txtJumlah.TabIndex = 25;
            // 
            // IDDonatur
            // 
            this.IDDonatur.AutoSize = true;
            this.IDDonatur.Location = new System.Drawing.Point(108, 70);
            this.IDDonatur.Name = "IDDonatur";
            this.IDDonatur.Size = new System.Drawing.Size(70, 16);
            this.IDDonatur.TabIndex = 22;
            this.IDDonatur.Text = "ID Donatur";
            // 
            // IDDonasi
            // 
            this.IDDonasi.AutoSize = true;
            this.IDDonasi.Location = new System.Drawing.Point(108, 108);
            this.IDDonasi.Name = "IDDonasi";
            this.IDDonasi.Size = new System.Drawing.Size(66, 16);
            this.IDDonasi.TabIndex = 21;
            this.IDDonasi.Text = "ID Donasi";
            // 
            // txtIDDonasi
            // 
            this.txtIDDonasi.Location = new System.Drawing.Point(187, 102);
            this.txtIDDonasi.Name = "txtIDDonasi";
            this.txtIDDonasi.Size = new System.Drawing.Size(250, 22);
            this.txtIDDonasi.TabIndex = 20;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(648, 157);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 19;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(648, 128);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(648, 99);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 17;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(648, 70);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(648, 241);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(75, 23);
            this.btnBACK.TabIndex = 32;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // btnAnalis
            // 
            this.btnAnalis.Location = new System.Drawing.Point(648, 187);
            this.btnAnalis.Name = "btnAnalis";
            this.btnAnalis.Size = new System.Drawing.Size(75, 23);
            this.btnAnalis.TabIndex = 33;
            this.btnAnalis.Text = "Analyze";
            this.btnAnalis.UseVisualStyleBackColor = true;
            this.btnAnalis.Click += new System.EventHandler(this.BtnAnalisis_Click);
            // 
            // cmbJenisBarang
            // 
            this.cmbJenisBarang.FormattingEnabled = true;
            this.cmbJenisBarang.Location = new System.Drawing.Point(187, 139);
            this.cmbJenisBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbJenisBarang.Name = "cmbJenisBarang";
            this.cmbJenisBarang.Size = new System.Drawing.Size(250, 24);
            this.cmbJenisBarang.TabIndex = 35;
            // 
            // cmbIDDonatur
            // 
            this.cmbIDDonatur.FormattingEnabled = true;
            this.cmbIDDonatur.Location = new System.Drawing.Point(192, 68);
            this.cmbIDDonatur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIDDonatur.Name = "cmbIDDonatur";
            this.cmbIDDonatur.Size = new System.Drawing.Size(245, 24);
            this.cmbIDDonatur.TabIndex = 36;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(187, 174);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(250, 22);
            this.txtNamaBarang.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nama Barang";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.cmbIDDonatur);
            this.Controls.Add(this.cmbJenisBarang);
            this.Controls.Add(this.btnAnalis);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.dgvDonasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.Jenis_Barang);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.IDDonatur);
            this.Controls.Add(this.IDDonasi);
            this.Controls.Add(this.txtIDDonasi);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
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
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label IDDonatur;
        private System.Windows.Forms.Label IDDonasi;
        private System.Windows.Forms.TextBox txtIDDonasi;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnAnalis;
        private System.Windows.Forms.ComboBox cmbJenisBarang;
        private System.Windows.Forms.ComboBox cmbIDDonatur;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label2;
    }
}