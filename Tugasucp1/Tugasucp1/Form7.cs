using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugasucp1
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
        }
        private string connectionString = koneksi.ConnectionString;

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_LaporanDonasi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                        saveFileDialog.Title = "Simpan Laporan Donasi sebagai CSV";
                        saveFileDialog.FileName = "LaporanDonasi.csv";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                            {
                                // Tulis header
                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    sw.Write(dt.Columns[i]);
                                    if (i < dt.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();

                                // Tulis data
                                foreach (DataRow row in dt.Rows)
                                {
                                    for (int i = 0; i < dt.Columns.Count; i++)
                                    {
                                        sw.Write(row[i].ToString());
                                        if (i < dt.Columns.Count - 1)
                                            sw.Write(",");
                                    }
                                    sw.WriteLine();
                                }
                            }

                            MessageBox.Show("Laporan berhasil diekspor ke CSV!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data kosong!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat export: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide(); // Sembunyikan form saat ini
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}