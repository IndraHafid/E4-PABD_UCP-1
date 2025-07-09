namespace Tugasucp1
{
    partial class Form3
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
            this.btnFormDonatur = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormLaporan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormDonatur
            // 
            this.btnFormDonatur.Location = new System.Drawing.Point(349, 179);
            this.btnFormDonatur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFormDonatur.Name = "btnFormDonatur";
            this.btnFormDonatur.Size = new System.Drawing.Size(159, 29);
            this.btnFormDonatur.TabIndex = 0;
            this.btnFormDonatur.Text = "Form Donatur";
            this.btnFormDonatur.UseVisualStyleBackColor = true;
            this.btnFormDonatur.Click += new System.EventHandler(this.btnDonatur_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Form Donasi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDonasi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 251);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Form Pengiriman";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPengiriman_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 288);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Form Penerima";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnPenerima_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pilih Form ";
            // 
            // btnFormLaporan
            // 
            this.btnFormLaporan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnFormLaporan.Location = new System.Drawing.Point(349, 325);
            this.btnFormLaporan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFormLaporan.Name = "btnFormLaporan";
            this.btnFormLaporan.Size = new System.Drawing.Size(159, 29);
            this.btnFormLaporan.TabIndex = 5;
            this.btnFormLaporan.Text = "Form Laporan";
            this.btnFormLaporan.UseVisualStyleBackColor = false;
            this.btnFormLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnFormLaporan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFormDonatur);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormDonatur;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormLaporan;
    }
}