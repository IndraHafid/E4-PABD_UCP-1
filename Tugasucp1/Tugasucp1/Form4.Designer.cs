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
            this.Status = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.Jumlah = new System.Windows.Forms.Label();
            this.Jenis_Barang = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtJenisBarang = new System.Windows.Forms.TextBox();
            this.txtIDDonatur = new System.Windows.Forms.TextBox();
            this.IDDonatur = new System.Windows.Forms.Label();
            this.IDDonasi = new System.Windows.Forms.Label();
            this.txtIDDonasi = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnAnalis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonasi
            // 
            this.dgvDonasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonasi.Location = new System.Drawing.Point(66, 352);
            this.dgvDonasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDonasi.Name = "dgvDonasi";
            this.dgvDonasi.RowHeadersWidth = 51;
            this.dgvDonasi.RowTemplate.Height = 24;
            this.dgvDonasi.Size = new System.Drawing.Size(379, 188);
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
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(140, 305);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 20);
            this.Status.TabIndex = 29;
            this.Status.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(210, 298);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(235, 26);
            this.txtStatus.TabIndex = 28;
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSize = true;
            this.Jumlah.Location = new System.Drawing.Point(140, 238);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(60, 20);
            this.Jumlah.TabIndex = 27;
            this.Jumlah.Text = "Jumlah";
            // 
            // Jenis_Barang
            // 
            this.Jenis_Barang.AutoSize = true;
            this.Jenis_Barang.Location = new System.Drawing.Point(99, 182);
            this.Jenis_Barang.Name = "Jenis_Barang";
            this.Jenis_Barang.Size = new System.Drawing.Size(102, 20);
            this.Jenis_Barang.TabIndex = 26;
            this.Jenis_Barang.Text = "Jenis Barang";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(210, 238);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(235, 26);
            this.txtJumlah.TabIndex = 25;
            // 
            // txtJenisBarang
            // 
            this.txtJenisBarang.Location = new System.Drawing.Point(210, 175);
            this.txtJenisBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJenisBarang.Name = "txtJenisBarang";
            this.txtJenisBarang.Size = new System.Drawing.Size(235, 26);
            this.txtJenisBarang.TabIndex = 24;
            // 
            // txtIDDonatur
            // 
            this.txtIDDonatur.Location = new System.Drawing.Point(210, 120);
            this.txtIDDonatur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDDonatur.Name = "txtIDDonatur";
            this.txtIDDonatur.Size = new System.Drawing.Size(235, 26);
            this.txtIDDonatur.TabIndex = 23;
            // 
            // IDDonatur
            // 
            this.IDDonatur.AutoSize = true;
            this.IDDonatur.Location = new System.Drawing.Point(117, 128);
            this.IDDonatur.Name = "IDDonatur";
            this.IDDonatur.Size = new System.Drawing.Size(88, 20);
            this.IDDonatur.TabIndex = 22;
            this.IDDonatur.Text = "ID Donatur";
            // 
            // IDDonasi
            // 
            this.IDDonasi.AutoSize = true;
            this.IDDonasi.Location = new System.Drawing.Point(122, 74);
            this.IDDonasi.Name = "IDDonasi";
            this.IDDonasi.Size = new System.Drawing.Size(80, 20);
            this.IDDonasi.TabIndex = 21;
            this.IDDonasi.Text = "ID Donasi";
            // 
            // txtIDDonasi
            // 
            this.txtIDDonasi.Location = new System.Drawing.Point(210, 66);
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
            // btnAnalis
            // 
            this.btnAnalis.Location = new System.Drawing.Point(729, 234);
            this.btnAnalis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnalis.Name = "btnAnalis";
            this.btnAnalis.Size = new System.Drawing.Size(84, 29);
            this.btnAnalis.TabIndex = 33;
            this.btnAnalis.Text = "Analiyz";
            this.btnAnalis.UseVisualStyleBackColor = true;
            this.btnAnalis.Click += new System.EventHandler(this.BtnAnalisis_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnAnalis);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.dgvDonasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.Jenis_Barang);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtJenisBarang);
            this.Controls.Add(this.txtIDDonatur);
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
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label Jumlah;
        private System.Windows.Forms.Label Jenis_Barang;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtJenisBarang;
        private System.Windows.Forms.TextBox txtIDDonatur;
        private System.Windows.Forms.Label IDDonatur;
        private System.Windows.Forms.Label IDDonasi;
        private System.Windows.Forms.TextBox txtIDDonasi;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnAnalis;
    }
}