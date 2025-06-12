using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tugasucp1
{
    public partial class Form5 : Form
    {
        private string connectionString = "Data source=DESKTOP-IPMTL32;Initial Catalog=DonasiBarangBekas;Integrated Security=True";

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
            dtpPengiriman.Value = DateTime.Now;
            dtpDiterima.Value = DateTime.Now;
            txtStatus.Clear();
            txtCocokBarang.Clear();
            txtIDPengiriman.Focus();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetAllPengirimanDonasi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPengiriman.DataSource = dt;
                    dgvPengiriman.Refresh();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Validasi kolom kosong
            if (string.IsNullOrWhiteSpace(txtIDPengiriman.Text) ||
                string.IsNullOrWhiteSpace(txtIDDonasi.Text) ||
                string.IsNullOrWhiteSpace(txtIDDonatur.Text) ||
                string.IsNullOrWhiteSpace(txtIDPenerima.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text) ||
                string.IsNullOrWhiteSpace(txtCocokBarang.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menambahkan data ini?", "Konfirmasi Tambah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertPengirimanDonasi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Pengiriman", txtIDPengiriman.Text);
                    cmd.Parameters.AddWithValue("@ID_Donasi", txtIDDonasi.Text);
                    cmd.Parameters.AddWithValue("@ID_Donatur", txtIDDonatur.Text);
                    cmd.Parameters.AddWithValue("@ID_Penerima", txtIDPenerima.Text);
                    cmd.Parameters.AddWithValue("@Tanggal_Pengiriman", dtpPengiriman.Value);
                    cmd.Parameters.AddWithValue("@Tanggal_Diterima", dtpDiterima.Value);
                    cmd.Parameters.AddWithValue("@Status_Pengiriman", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@Kecocokan_Barang", txtCocokBarang.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan: " + ex.Message);
                }
            }
        }


        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDPengiriman.Text) ||
             string.IsNullOrWhiteSpace(txtIDDonasi.Text) ||
             string.IsNullOrWhiteSpace(txtIDDonatur.Text) ||
             string.IsNullOrWhiteSpace(txtIDPenerima.Text) ||
             string.IsNullOrWhiteSpace(txtStatus.Text) ||
             string.IsNullOrWhiteSpace(txtCocokBarang.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin mengubah data ini?", "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdatePengirimanDonasi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Pengiriman", txtIDPengiriman.Text);
                    cmd.Parameters.AddWithValue("@ID_Donasi", txtIDDonasi.Text);
                    cmd.Parameters.AddWithValue("@ID_Donatur", txtIDDonatur.Text);
                    cmd.Parameters.AddWithValue("@ID_Penerima", txtIDPenerima.Text);
                    cmd.Parameters.AddWithValue("@Tanggal_Pengiriman", dtpPengiriman.Value);
                    cmd.Parameters.AddWithValue("@Tanggal_Diterima", dtpDiterima.Value);
                    cmd.Parameters.AddWithValue("@Status_Pengiriman", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@Kecocokan_Barang", txtCocokBarang.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diubah!");
                    LoadData();
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
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string id = dgvPengiriman.SelectedRows[0].Cells["ID_Pengiriman"].Value.ToString();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeletePengirimanDonasi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Pengiriman", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data berhasil direfresh.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void dgvPengiriman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPengiriman.Rows[e.RowIndex];

                txtIDPengiriman.Text = row.Cells["ID_Pengiriman"].Value?.ToString();
                txtIDDonasi.Text = row.Cells["ID_Donasi"].Value?.ToString();
                txtIDDonatur.Text = row.Cells["ID_Donatur"].Value?.ToString();
                txtIDPenerima.Text = row.Cells["ID_Penerima"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["Tanggal_Pengiriman"].Value?.ToString(), out DateTime tglKirim))
                    dtpPengiriman.Value = tglKirim;

                if (DateTime.TryParse(row.Cells["Tanggal_Diterima"].Value?.ToString(), out DateTime tglTerima))
                    dtpDiterima.Value = tglTerima;

                txtStatus.Text = row.Cells["Status_Pengiriman"].Value?.ToString();
                txtCocokBarang.Text = row.Cells["Kecocokan_Barang"].Value?.ToString();
            }
        }
    }
}
