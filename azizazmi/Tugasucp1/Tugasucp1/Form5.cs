using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tugasucp1
{
    public partial class Form5 : Form
    {
        koneksi kn = new koneksi();
        string strKonek = "";

        public Form5()
        {
            InitializeComponent();
            strKonek = kn.connectionString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDonaturCombo();
            LoadComboStatus();
            LoadComboKecocokan();
            LoadPenerimaCombo();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(strKonek))
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadDonaturCombo()
        {
            cmbIDDonatur.Items.Clear();
            using (SqlConnection conn = new SqlConnection(strKonek))
            {
                string query = "SELECT DISTINCT ID_Donatur FROM Donasi";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbIDDonatur.Items.Add(reader["ID_Donatur"].ToString());
                }
                reader.Close();
            }
        }

        private void LoadPenerimaCombo()
        {
            cmbIDPenerima.Items.Clear();
            using (SqlConnection conn = new SqlConnection(strKonek))
            {
                string query = "SELECT ID_Penerima FROM Penerima";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbIDPenerima.Items.Add(reader["ID_Penerima"].ToString());
                }
                reader.Close();
            }
        }

        private void LoadComboStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Diproses");
            cmbStatus.Items.Add("Dalam Pengiriman");
            cmbStatus.Items.Add("Terkirim");
        }

        private void LoadComboKecocokan()
        {
            cmbCocokBarang.Items.Clear();
            cmbCocokBarang.Items.Add("Cocok");
            cmbCocokBarang.Items.Add("Tidak Cocok");
        }

        private void cmbIDDonatur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIDDonasi.Items.Clear();
            if (cmbIDDonatur.SelectedItem != null)
            {
                LoadDonasiCombo(cmbIDDonatur.SelectedItem.ToString());
            }
        }

        private void LoadDonasiCombo(string idDonatur)
        {
            cmbIDDonasi.Items.Clear();

            using (SqlConnection conn = new SqlConnection(strKonek))
            {
                string query = "SELECT ID_Donasi FROM Donasi WHERE ID_Donatur = @ID_Donatur";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Donatur", idDonatur);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbIDDonasi.Items.Add(reader["ID_Donasi"].ToString());
                }
                reader.Close();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cmbIDDonatur.SelectedItem == null || cmbIDDonasi.SelectedItem == null ||
                cmbIDPenerima.SelectedItem == null || cmbStatus.SelectedItem == null || cmbCocokBarang.SelectedItem == null)
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menambahkan data ini?", "Konfirmasi Tambah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(strKonek))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertPengirimanDonasi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Donasi", cmbIDDonasi.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID_Donatur", cmbIDDonatur.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID_Penerima", cmbIDPenerima.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Tanggal_Pengiriman", dtpPengiriman.Value);
                    cmd.Parameters.AddWithValue("@Tanggal_Diterima", dtpDiterima.Value);
                    cmd.Parameters.AddWithValue("@Status_Pengiriman", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Kecocokan_Barang", cmbCocokBarang.SelectedItem.ToString());
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
            if (cmbIDDonatur.SelectedItem == null || cmbIDDonasi.SelectedItem == null ||
                cmbIDPenerima.SelectedItem == null || cmbStatus.SelectedItem == null || cmbCocokBarang.SelectedItem == null)
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin mengubah data ini?", "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(strKonek))
            {
                try
                {
                    string idPengiriman = dgvPengiriman.SelectedRows[0].Cells["ID_Pengiriman"].Value.ToString();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdatePengirimanDonasi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Pengiriman", idPengiriman);
                    cmd.Parameters.AddWithValue("@ID_Donasi", cmbIDDonasi.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID_Donatur", cmbIDDonatur.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID_Penerima", cmbIDPenerima.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Tanggal_Pengiriman", dtpPengiriman.Value);
                    cmd.Parameters.AddWithValue("@Tanggal_Diterima", dtpDiterima.Value);
                    cmd.Parameters.AddWithValue("@Status_Pengiriman", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Kecocokan_Barang", cmbCocokBarang.SelectedItem.ToString());
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

            using (SqlConnection conn = new SqlConnection(strKonek))
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

        private void dgvPengiriman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPengiriman.Rows[e.RowIndex];

                cmbIDDonasi.SelectedItem = row.Cells["ID_Donasi"].Value?.ToString();
                cmbIDDonatur.SelectedItem = row.Cells["ID_Donatur"].Value?.ToString();
                cmbIDPenerima.SelectedItem = row.Cells["ID_Penerima"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["Tanggal_Pengiriman"].Value?.ToString(), out DateTime tglKirim))
                    dtpPengiriman.Value = tglKirim;

                if (DateTime.TryParse(row.Cells["Tanggal_Diterima"].Value?.ToString(), out DateTime tglTerima))
                    dtpDiterima.Value = tglTerima;

                cmbStatus.SelectedItem = row.Cells["Status_Pengiriman"].Value?.ToString();
                cmbCocokBarang.SelectedItem = row.Cells["Kecocokan_Barang"].Value?.ToString();
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
    }
}
