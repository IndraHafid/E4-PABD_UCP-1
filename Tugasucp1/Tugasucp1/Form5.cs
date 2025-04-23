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
    public partial class Form5 : Form
    {
        private string connectionString = "Data source=LAPTOP-HV1LJOCH\\HAFIDZ;Initial Catalog=DonasiBarangBekas;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void Pengirim_Donasi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearForm()
        {
            txtIDPengiriman.Clear();
            txtIDDonasi.Clear();
            txtIDDonatur.Clear();
            txtIDPenerima.Clear();
            txtTglPengiriman.Value = DateTime.Now; 
            txtTglDiterima.Value = DateTime.Now;
            txtStatus.Clear();
            txtCocokBarang.Clear();
            txtIDPengiriman.Focus();
        }

        private void Pengiriman_Donasi_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT ID_Pengiriman AS [ID Pengiriman], ID_Donasi AS [ID Donasi], ID_Donatur AS [ID_Donatur], ID_Penerima AS [ID_Penerima],
                                    Tanggal_Kirim AS [Tanggal Kirim], Tanggal_Terima AS [Tanggal_Terima], 
                                    Status_Pengiriman AS [Status Pengiriman], Kecocokan_Barang AS [Kecocokan Barang] FROM PengirimanDonasi";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPengiriman.AutoGenerateColumns = true;
                    dgvPengiriman.DataSource = dt;

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtIDPengiriman.Text == "" || txtIDDonasi.Text == "" || txtIDDonatur.Text == "" ||
                txtIDPenerima.Text == "" || txtTanggalKirim.Text == "" || txtTanggalTerima.Text == "" ||
                txtStatus.Text == "" || txtCocokBarang.Text == "")
            {
                MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO PengirimanDonasi 
                                    (ID_Pengiriman, ID_Donasi, ID_Donatur, ID_Penerima, 
                                     Tanggal_Kirim, Tanggal_Terima, Status_Kirim, Cocok_Barang) 
                                     VALUES 
                                    (@ID, @Donasi, @Donatur, @Penerima, @TglKirim, @TglTerima, @Status, @Cocok)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", txtIDPengiriman.Text.Trim());
                    cmd.Parameters.AddWithValue("@Donasi", txtIDDonasi.Text.Trim());
                    cmd.Parameters.AddWithValue("@Donatur", txtIDDonatur.Text.Trim());
                    cmd.Parameters.AddWithValue("@Penerima", txtIDPenerima.Text.Trim());
                    cmd.Parameters.AddWithValue("@TglKirim", txtTglPengiriman.Value);
                    cmd.Parameters.AddWithValue("@TglTerima", txtTglDiterima.Value);
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text.Trim());
                    cmd.Parameters.AddWithValue("@Cocok", txtCocokBarang.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil ditambahkan!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan data.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan: " + ex.Message);
                }
            }
        }
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDPengiriman.Text))
            {
                MessageBox.Show("Isi ID Pengiriman terlebih dahulu!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE PengirimanDonasi SET 
                                        ID_Donasi = @Donasi,
                                        ID_Donatur = @Donatur,
                                        ID_Penerima = @Penerima,
                                        Tanggal_Kirim = @TglKirim,
                                        Tanggal_Terima = @TglTerima,
                                        Status_Kirim = @Status,
                                        Cocok_Barang = @Cocok
                                     WHERE ID_Pengiriman = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", txtIDPengiriman.Text);
                    cmd.Parameters.AddWithValue("@Donasi", txtIDDonasi.Text);
                    cmd.Parameters.AddWithValue("@Donatur", txtIDDonatur.Text);
                    cmd.Parameters.AddWithValue("@Penerima", txtIDPenerima.Text);
                    cmd.Parameters.AddWithValue("@TglKirim", txtTglPengiriman.Value); 
                    cmd.Parameters.AddWithValue("@TglTerima", txtTglDiterima.Value);
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@Cocok", txtCocokBarang.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil diubah!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan!");
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
            if (dgvPengiriman.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus!");
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        string id = dgvPengiriman.SelectedRows[0].Cells["ID_Pengiriman"].Value.ToString();
                        conn.Open();
                        string query = "DELETE FROM PengirimanDonasi WHERE ID_Pengiriman = @ID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }



        }
    }
}
