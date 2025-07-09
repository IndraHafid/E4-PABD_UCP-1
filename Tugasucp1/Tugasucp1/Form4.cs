using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tugasucp1
{
    public partial class Form4 : Form
    {
        private string connectionString = koneksi.ConnectionString;

        public Form4()
        {
            InitializeComponent();
            this.Load += Donasi_Load;
        }

        private void Donasi_Load(object sender, EventArgs e)
        {
            cmbJenisBarang.Items.Clear();
            cmbJenisBarang.Items.AddRange(new string[] { "Elektronik", "Pakaian", "Perabotan", "Lain-lain" });
            LoadIDDonaturToComboBox();
            LoadData();
        }

        private void LoadIDDonaturToComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ID_Donatur FROM Donatur", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbIDDonatur.Items.Clear();
                    while (reader.Read())
                    {
                        cmbIDDonatur.Items.Add(reader["ID_Donatur"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat ID Donatur: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT ID_Donasi AS [ID Donasi], ID_Donatur AS [ID Donatur], 
                                     Nama_Barang AS [Nama Barang], Jenis_Barang AS [Jenis Barang],
                                     Jumlah_Barang AS [Jumlah Barang] FROM Donasi";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDonasi.AutoGenerateColumns = true;
                    dgvDonasi.DataSource = dt;

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            txtIDDonasi.Clear();
            txtNamaBarang.Clear();
            txtJumlahBarang.Clear();
            cmbIDDonatur.SelectedIndex = -1;
            cmbJenisBarang.SelectedIndex = -1;
            txtIDDonasi.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtIDDonasi.Text == "" || cmbIDDonatur.SelectedIndex == -1 || cmbJenisBarang.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtNamaBarang.Text) || string.IsNullOrWhiteSpace(txtJumlahBarang.Text))
            {
                MessageBox.Show("Harap isi semua data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtJumlahBarang.Text, out int jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah barang harus berupa angka positif", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin menambahkan data donasi ini?",
                                                   "Konfirmasi Tambah",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Donasi (ID_Donasi, ID_Donatur, Nama_Barang, Jenis_Barang, Jumlah_Barang) VALUES (@ID, @Donatur, @Nama, @Jenis, @Jumlah)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDDonasi.Text.Trim());
                    cmd.Parameters.AddWithValue("@Donatur", cmbIDDonatur.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Nama", txtNamaBarang.Text.Trim());
                    cmd.Parameters.AddWithValue("@Jenis", cmbJenisBarang.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Jumlah", jumlah);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Donasi berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDDonasi.Text) || cmbIDDonatur.SelectedIndex == -1 ||
                cmbJenisBarang.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtNamaBarang.Text) ||
                string.IsNullOrWhiteSpace(txtJumlahBarang.Text))
            {
                MessageBox.Show("Harap isi semua data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtJumlahBarang.Text, out int jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah barang harus berupa angka positif", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin mengubah data donasi ini?",
                                                   "Konfirmasi Ubah",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Donasi SET ID_Donatur=@Donatur, Nama_Barang=@Nama, Jenis_Barang=@Jenis, Jumlah_Barang=@Jumlah WHERE ID_Donasi=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDDonasi.Text);
                    cmd.Parameters.AddWithValue("@Donatur", cmbIDDonatur.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Nama", txtNamaBarang.Text.Trim());
                    cmd.Parameters.AddWithValue("@Jenis", cmbJenisBarang.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Jumlah", jumlah);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data Donasi berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDonasi.SelectedRows.Count > 0)
            {
                string id = dgvDonasi.SelectedRows[0].Cells["ID Donasi"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Yakin ingin menghapus data Donasi dengan ID '{id}'?",
                                                        "Konfirmasi Hapus",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        string query = "DELETE FROM Donasi WHERE ID_Donasi = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            conn.Open();
                            cmd.Parameters.AddWithValue("@ID", id);
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
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDonasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvDonasi.Rows[e.RowIndex];

                txtIDDonasi.Text = row.Cells["ID Donasi"].Value.ToString();
                cmbIDDonatur.SelectedItem = row.Cells["ID Donatur"].Value.ToString();
                cmbJenisBarang.SelectedItem = row.Cells["Jenis Barang"].Value.ToString();
                txtNamaBarang.Text = row.Cells["Nama Barang"].Value.ToString();
                txtJumlahBarang.Text = row.Cells["Jumlah Barang"].Value.ToString();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
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

        private void BtnAnalisis_Click(object sender, EventArgs e)
        {
            TampilHasilAnalisis();

            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"
            SET STATISTICS IO ON;
            SET STATISTICS TIME ON;
            EXEC sp_AnalisisDonasi;
            SET STATISTICS IO OFF;
            SET STATISTICS TIME OFF;";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.InfoMessage += (s, ev) =>
                    {
                        MessageBox.Show(ev.Message, "STATISTICS INFO");
                    };
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan saat analisis: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TampilHasilAnalisis()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_AnalisisDonasi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDonasi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan hasil analisis: " + ex.Message);
                }
            }
        }

    }
}
