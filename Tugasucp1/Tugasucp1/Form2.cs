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
        private string connectionString = koneksi.ConnectionString;
        public Form2()


        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
            txtIDDonatur.Text = GenerateNextDonaturID(); // isi otomatis
            txtIDDonatur.Enabled = false; // disable input manual
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtIDDonatur.Text == "" || txtNamaDonatur.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show("Harap isi semua data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin menambahkan data ini?", "Konfirmasi Tambah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Donatur (ID_Donatur, Nama_Donatur, Alamat, Notelp) VALUES (@ID, @Nama, @Alamat, @Notelp)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDDonatur.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nama", txtNamaDonatur.Text.Trim());
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoTelp", txtNoTelp.Text.Trim());

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
                            string id = dgvDonatur.SelectedRows[0].Cells["ID Donatur"].Value.ToString(); // sesuai alias di SELECT
                            string query = "DELETE FROM Donatur WHERE ID_Donatur = @ID";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID", id); // perbaikan di sini
                                conn.Open();
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

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDDonatur.Text))
            {
                MessageBox.Show("Isi ID Donatur terlebih dahulu.");
                return;
            }

            string noTelp = txtNoTelp.Text.Trim();
            if (!noTelp.StartsWith("08") || noTelp.Length < 10 || noTelp.Length > 14)
            {
                MessageBox.Show("Nomor telepon harus dimulai dengan '08' dan panjangnya antara 10 hingga 14 digit.",
                                "Nomor Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Donatur SET Nama_Donatur=@Nama, Alamat=@Alamat, NoTelp=@NoTelp WHERE ID_Donatur=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", txtIDDonatur.Text);
                    cmd.Parameters.AddWithValue("@Nama", txtNamaDonatur.Text);
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@NoTelp", noTelp);

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

        private string GenerateNextDonaturID()
        {
            string newID = "D0001";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(ID_Donatur) FROM Donatur";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    string lastID = result.ToString(); // D0005
                    int number = int.Parse(lastID.Substring(1)) + 1;
                    newID = "D" + number.ToString("D4");
                }
            }
            return newID;
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}