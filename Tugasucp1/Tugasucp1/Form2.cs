using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugasucp1
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data source=LAPTOP-HV1LJOCH\\HAFIDZ;Initial Catalog=DonasiBarangBekas;Integrated Security=True";
        public Form2()


        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ClearForm()
        {
            txtIDDonatur.Clear();
            txtNamaDonatur.Clear();
            txtAlamat.Clear();
            txtNoTelp.Clear();
            txtIDDonatur.Focus();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Donatur AS [ID Donatur], Nama_Donatur AS [Nama Donatur], Alamat AS [Alamat], NoTelp AS[NoTelp] FROM Donatur";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDonatur.AutoGenerateColumns = true;
                    dgvDonatur.DataSource = dt;

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDDonatur.Text))
            {
                MessageBox.Show("Isi ID Donatur terlebih dahulu.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Donatur SET Nama_Donatur=@Nama, Alamat=@Alamat WHERE ID_Donatur=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", txtIDDonatur.Text);
                    cmd.Parameters.AddWithValue("@Nama", txtNamaDonatur.Text);
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@NoTelp", txtNoTelp.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data Donatur berhasil diubah.");
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan: " + ex.Message);
                }
            }
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDonatur.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            string id = dgvDonatur.SelectedRows[0].Cells["ID_Donatur"].Value.ToString();
                            string query = "DELETE FROM Donatur WHERE ID_Donatur = @ID";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                conn.Open();
                                cmd.Parameters.AddWithValue("@ID_Donatur", id);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearForm();
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Data tidak ditemukan atau gagal dihapus!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnRefresh_click(object sender, EventArgs e)
        {
            LoadData();

            // Debugging: Cek jumlah kolom dan baris (opsional, bisa dihapus jika tidak perlu)
            MessageBox.Show($"Jumlah Kolom: {dgvDonatur.ColumnCount}\nJumlah Baris: {dgvDonatur.RowCount}",
                "Debugging DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtIDDonatur.Text == "" || txtNamaDonatur.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show("Harap isi semua data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Donatur (ID_Donatur, Nama_Donatur, Alamat) VALUES (@ID, @Nama, @Alamat)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDDonatur.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nama", txtNamaDonatur.Text.Trim());
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Donatur berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal ditambahkan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}