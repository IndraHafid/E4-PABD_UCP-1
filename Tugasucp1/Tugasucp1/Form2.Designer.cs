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
            this.txtIDDonatur.Location = new System.Drawing.Point(171, 79);
            this.txtIDDonatur.Name = "txtIDDonatur";
            this.txtIDDonatur.Size = new System.Drawing.Size(270, 22);
            this.txtIDDonatur.TabIndex = 0;
            // 
            // txtNamaDonatur
            // 
            this.txtNamaDonatur.Location = new System.Drawing.Point(171, 130);
            this.txtNamaDonatur.Name = "txtNamaDonatur";
            this.txtNamaDonatur.Size = new System.Drawing.Size(270, 22);
            this.txtNamaDonatur.TabIndex = 1;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(171, 185);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(270, 22);
            this.txtAlamat.TabIndex = 2;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(171, 234);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(270, 22);
            this.txtNoTelp.TabIndex = 3;
            // 
            // NamaDonatur
            // 
            this.NamaDonatur.AutoSize = true;
            this.NamaDonatur.Location = new System.Drawing.Point(42, 136);
            this.NamaDonatur.Name = "NamaDonatur";
            this.NamaDonatur.Size = new System.Drawing.Size(94, 16);
            this.NamaDonatur.TabIndex = 4;
            this.NamaDonatur.Text = "Nama Donatur";
            // 
            // IDDonatur
            // 
            this.IDDonatur.AutoSize = true;
            this.IDDonatur.Location = new System.Drawing.Point(42, 85);
            this.IDDonatur.Name = "IDDonatur";
            this.IDDonatur.Size = new System.Drawing.Size(70, 16);
            this.IDDonatur.TabIndex = 5;
            this.IDDonatur.Text = "lD Donatur";
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Location = new System.Drawing.Point(42, 188);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(49, 16);
            this.Alamat.TabIndex = 6;
            this.Alamat.Text = "Alamat";
            // 
            // NoTelp
            // 
            this.NoTelp.AutoSize = true;
            this.NoTelp.Location = new System.Drawing.Point(42, 240);
            this.NoTelp.Name = "NoTelp";
            this.NoTelp.Size = new System.Drawing.Size(79, 16);
            this.NoTelp.TabIndex = 7;
            this.NoTelp.Text = "No Telepon";
            // 
            // dgvDonatur
            // 
            this.dgvDonatur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonatur.Location = new System.Drawing.Point(45, 278);
            this.dgvDonatur.Name = "dgvDonatur";
            this.dgvDonatur.RowHeadersWidth = 51;
            this.dgvDonatur.RowTemplate.Height = 24;
            this.dgvDonatur.Size = new System.Drawing.Size(400, 150);
            this.dgvDonatur.TabIndex = 8;
            // 
            // Donatur
            // 
            this.Donatur.AutoSize = true;
            this.Donatur.Location = new System.Drawing.Point(292, 39);
            this.Donatur.Name = "Donatur";
            this.Donatur.Size = new System.Drawing.Size(54, 16);
            this.Donatur.TabIndex = 9;
            this.Donatur.Text = "Donatur";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(589, 78);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Add";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(589, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(589, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(589, 198);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(589, 260);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(75, 23);
            this.btnBACK.TabIndex = 14;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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