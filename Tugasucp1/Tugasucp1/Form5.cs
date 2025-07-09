using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tugasucp1
{
    public partial class Form5 : Form
    {
        private string connectionString = koneksi.ConnectionString;
        public Form5()
        {
            InitializeComponent();
            this.Load += Form5_Load;
            cmbIDDonatur.SelectedIndexChanged += cmbIDDonatur_SelectedIndexChanged;
            dgvPengiriman.CellClick += dgvPengiriman_CellClick;
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnBACK.Click += btnBACK_Click;
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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Donatur FROM Donatur";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string idDonatur = reader["ID_Donatur"].ToString();
                        if (!string.IsNullOrEmpty(idDonatur))
                        {
                            cmbIDDonatur.Items.Add(idDonatur);
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat ID Donatur: " + ex.Message);
                }
            }
        }

        private void LoadPenerimaCombo()
        {
            cmbIDPenerima.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Penerima FROM Penerima";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbIDPenerima.Items.Add(reader["ID_Penerima"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat ID Penerima: " + ex.Message);
                }
            }
        }

        private void LoadComboStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Diterima");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Dibatalkan");
        }

        private void LoadComboKecocokan()
        {
            cmbCocokBarang.Items.Clear();
            cmbCocokBarang.Items.Add("Sesuai");
            cmbCocokBarang.Items.Add("Tidak Sesuai");
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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Donasi FROM Donasi WHERE ID_Donatur = @ID_Donatur";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_Donatur", idDonatur);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbIDDonasi.Items.Add(reader["ID_Donasi"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat ID Donasi: " + ex.Message);
                }
            }
        }

        private string GeneratePengirimanID(SqlConnection conn)
        {
            string query = "SELECT TOP 1 ID_Pengiriman FROM PengirimanDonasi ORDER BY ID_Pengiriman DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastId = result.ToString();
                int num = int.Parse(lastId.Substring(2)) + 1;
                return "PG" + num.ToString("D3");
            }
            else
            {
                return "PG001";
            }
        }

        private void dgvPengiriman_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cmbIDDonasi.SelectedItem == null || cmbIDDonatur.SelectedItem == null ||
                cmbIDPenerima.SelectedItem == null || cmbStatus.SelectedItem == null || cmbCocokBarang.SelectedItem == null)
            {
                MessageBox.Show("Semua field harus diisi.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string idPengiriman = GeneratePengirimanID(conn);
                    SqlCommand cmd = new SqlCommand("sp_InsertPengirimanDonasi", conn);
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
                    LoadData();
                    MessageBox.Show("Data berhasil ditambahkan.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan data: " + ex.Message);
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvPengiriman.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diubah.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string idPengiriman = dgvPengiriman.SelectedRows[0].Cells["ID_Pengiriman"].Value.ToString();
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
                    LoadData();
                    MessageBox.Show("Data berhasil diubah.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengubah data: " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPengiriman.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string idPengiriman = dgvPengiriman.SelectedRows[0].Cells["ID_Pengiriman"].Value.ToString();
                    SqlCommand cmd = new SqlCommand("sp_DeletePengirimanDonasi", conn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Pengiriman", idPengiriman);

                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                    LoadData();
                    MessageBox.Show("Data berhasil dihapus.");
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();

                    if (ex.Number == 547) 
                    {
                        MessageBox.Show("Data tidak bisa dihapus karena sedang digunakan oleh tabel lain (relasi foreign key).", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data: " + ex.Message);
                    }
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
            if (Application.OpenForms["Form3"] != null)
            {
                Application.OpenForms["Form3"].Show();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }
    }
}
