namespace Tugasucp1
{
    partial class Form7
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(24, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(605, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(670, 172);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(96, 45);
            this.btnExportCSV.TabIndex = 1;
            this.btnExportCSV.Text = "EXPORT";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(694, 399);
            this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(84, 29);
            this.btnBACK.TabIndex = 33;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnBACK;
    }
}