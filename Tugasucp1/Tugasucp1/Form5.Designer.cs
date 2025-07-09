using System;
using System.Windows.Forms;

namespace Tugasucp1
{
    partial class Form5
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pengiriman_Donasi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPengiriman = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.dtpPengiriman = new System.Windows.Forms.DateTimePicker();
            this.dtpDiterima = new System.Windows.Forms.DateTimePicker();
            this.cmbIDDonasi = new System.Windows.Forms.ComboBox();
            this.cmbIDDonatur = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbCocokBarang = new System.Windows.Forms.ComboBox();
            this.cmbIDPenerima = new System.Windows.Forms.ComboBox();
            this.IDPenerima = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kecocokan Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tanggal Diterima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID Donatur";
            // 
            // Pengiriman_Donasi
            // 
            this.Pengiriman_Donasi.AutoSize = true;
            this.Pengiriman_Donasi.Location = new System.Drawing.Point(312, 45);
            this.Pengiriman_Donasi.Name = "Pengiriman_Donasi";
            this.Pengiriman_Donasi.Size = new System.Drawing.Size(142, 20);
            this.Pengiriman_Donasi.TabIndex = 35;
            this.Pengiriman_Donasi.Text = "Pengiriman Donasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Status Pengiriman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tanggal Pengiriman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID Donasi";
            // 
            // dgvPengiriman
            // 
            this.dgvPengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengiriman.Location = new System.Drawing.Point(26, 404);
            this.dgvPengiriman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPengiriman.Name = "dgvPengiriman";
            this.dgvPengiriman.RowHeadersWidth = 51;
            this.dgvPengiriman.RowTemplate.Height = 24;
            this.dgvPengiriman.Size = new System.Drawing.Size(440, 186);
            this.dgvPengiriman.TabIndex = 26;
            this.dgvPengiriman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPengiriman_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(574, 178);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 29);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(574, 141);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(84, 29);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Delete";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(574, 105);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(84, 29);
            this.btnUbah.TabIndex = 23;
            this.btnUbah.Text = "Update";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(574, 69);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(84, 29);
            this.btnTambah.TabIndex = 22;
            this.btnTambah.Text = "Add";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(560, 322);
            this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(84, 29);
            this.btnBACK.TabIndex = 44;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // dtpPengiriman
            // 
            this.dtpPengiriman.Location = new System.Drawing.Point(263, 179);
            this.dtpPengiriman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPengiriman.Name = "dtpPengiriman";
            this.dtpPengiriman.Size = new System.Drawing.Size(241, 26);
            this.dtpPengiriman.TabIndex = 45;
            // 
            // dtpDiterima
            // 
            this.dtpDiterima.Location = new System.Drawing.Point(262, 215);
            this.dtpDiterima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDiterima.Name = "dtpDiterima";
            this.dtpDiterima.Size = new System.Drawing.Size(241, 26);
            this.dtpDiterima.TabIndex = 46;
            // 
            // cmbIDDonasi
            // 
            this.cmbIDDonasi.FormattingEnabled = true;
            this.cmbIDDonasi.Location = new System.Drawing.Point(264, 142);
            this.cmbIDDonasi.Name = "cmbIDDonasi";
            this.cmbIDDonasi.Size = new System.Drawing.Size(191, 28);
            this.cmbIDDonasi.TabIndex = 47;
            // 
            // cmbIDDonatur
            // 
            this.cmbIDDonatur.FormattingEnabled = true;
            this.cmbIDDonatur.Location = new System.Drawing.Point(262, 101);
            this.cmbIDDonatur.Name = "cmbIDDonatur";
            this.cmbIDDonatur.Size = new System.Drawing.Size(192, 28);
            this.cmbIDDonatur.TabIndex = 48;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Diproses",
            "Dalam Pengiriman",
            "Terkirim"});
            this.cmbStatus.Location = new System.Drawing.Point(262, 289);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(192, 28);
            this.cmbStatus.TabIndex = 49;
            // 
            // cmbCocokBarang
            // 
            this.cmbCocokBarang.FormattingEnabled = true;
            this.cmbCocokBarang.Items.AddRange(new object[] {
            "Sesuai",
            "Tidak Sesuai"});
            this.cmbCocokBarang.Location = new System.Drawing.Point(262, 323);
            this.cmbCocokBarang.Name = "cmbCocokBarang";
            this.cmbCocokBarang.Size = new System.Drawing.Size(192, 28);
            this.cmbCocokBarang.TabIndex = 50;
            // 
            // cmbIDPenerima
            // 
            this.cmbIDPenerima.FormattingEnabled = true;
            this.cmbIDPenerima.Items.AddRange(new object[] {
            "Diproses",
            "Dalam Pengiriman",
            "Terkirim"});
            this.cmbIDPenerima.Location = new System.Drawing.Point(262, 248);
            this.cmbIDPenerima.Name = "cmbIDPenerima";
            this.cmbIDPenerima.Size = new System.Drawing.Size(192, 28);
            this.cmbIDPenerima.TabIndex = 52;
            // 
            // IDPenerima
            // 
            this.IDPenerima.AutoSize = true;
            this.IDPenerima.Location = new System.Drawing.Point(64, 256);
            this.IDPenerima.Name = "IDPenerima";
            this.IDPenerima.Size = new System.Drawing.Size(97, 20);
            this.IDPenerima.TabIndex = 51;
            this.IDPenerima.Text = "ID Penerima";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 682);
            this.Controls.Add(this.cmbIDPenerima);
            this.Controls.Add(this.IDPenerima);
            this.Controls.Add(this.cmbCocokBarang);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbIDDonatur);
            this.Controls.Add(this.cmbIDDonasi);
            this.Controls.Add(this.dtpDiterima);
            this.Controls.Add(this.dtpPengiriman);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pengiriman_Donasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPengiriman);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengiriman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvPengiriman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Pengiriman_Donasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPengiriman;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.DateTimePicker dtpPengiriman;
        private System.Windows.Forms.DateTimePicker dtpDiterima;
        private System.Windows.Forms.ComboBox cmbIDDonasi;
        private System.Windows.Forms.ComboBox cmbIDDonatur;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbCocokBarang;
        private System.Windows.Forms.ComboBox cmbIDPenerima;
        private System.Windows.Forms.Label IDPenerima;
    }
}