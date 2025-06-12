using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tugasucp1
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data source=DESKTOP-IPMTL32;Initial Catalog=DonasiBarangBekas;Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void Donasi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AnalyzeQuery(string sqlQuery)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.InfoMessage += (s, e) => MessageBox.Show(e.Message, "STATISTICS INFO");
                conn.Open();
                var wrapped = $@"
                SET STATISTICS IO ON;
                SET STATISTICS TIME ON;
                {sqlQuery};
                SET STATISTICS IO OFF;
                SET STATISTICS TIME OFF;";
                using (var cmd = new SqlCommand(wrapped, conn))
                {
                    cmd.ExecuteNonQuery();
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
                                     Jenis_Barang AS [Jenis Barang] FROM Donasi";
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
            txtIDDonatur.Clear();
            txtJenisBarang.Clear();
            txtIDDonasi.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtIDDonasi.Text == "" || txtIDDonatur.Text == "" || txtJenisBarang.Text == "")
            {
                MessageBox.Show("Harap isi semua data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string query = "INSERT INTO Donasi (ID_Donasi, ID_Donatur, Jenis_Barang) VALUES (@ID, @Donatur, @Jenis)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDDonasi.Text.Trim());
                    cmd.Parameters.AddWithValue("@Donatur", txtIDDonatur.Text.Trim());
                    cmd.Parameters.AddWithValue("@Jenis", txtJenisBarang.Text.Trim());

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
            if (string.IsNullOrWhiteSpace(txtIDDonasi.Text))
            {
                MessageBox.Show("Isi ID Donasi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string query = "UPDATE Donasi SET ID_Donatur=@Donatur, Jenis_Barang=@Jenis WHERE ID_Donasi=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDDonasi.Text);
                    cmd.Parameters.AddWithValue("@Donatur", txtIDDonatur.Text);
                    cmd.Parameters.AddWithValue("@Jenis", txtJenisBarang.Text);

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

        private void dgvDonasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvDonasi.Rows[e.RowIndex];

                txtIDDonasi.Text = row.Cells["ID Donasi"].Value.ToString();
                txtIDDonatur.Text = row.Cells["ID Donatur"].Value.ToString();
                txtJenisBarang.Text = row.Cells["Jenis Barang"].Value.ToString();
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data berhasil direfresh.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
