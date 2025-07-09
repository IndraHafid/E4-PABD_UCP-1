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
    public partial class Form6 : Form
    {
        private string connectionString = koneksi.ConnectionString;
        public Form6()
        {
            InitializeComponent();
        }
        private void Penerima_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT ID_Penerima AS [ID Penerima], Nama_Penerima AS [Nama Penerima], 
                            Alamat AS [Alamat], NoTelp AS [No Telp] FROM Penerima";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPenerima.AutoGenerateColumns = true;
                    dgvPenerima.DataSource = dt;

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
            txtIDPenerima.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtNoTelp.Clear();
            GenerateIDPenerimaBaru();
            txtNama.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtIDPenerima.Text == "" || txtNama.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show("Harap isi semua data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menambahkan data penerima ini?", "Konfirmasi Tambah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Penerima (ID_Penerima, Nama_Penerima, Alamat, NoTelp) VALUES (@ID, @Nama, @Alamat, @NoTelp)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDPenerima.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nama", txtNama.Text.Trim());
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoTelp", txtNoTelp.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Penerima berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(txtIDPenerima.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                string.IsNullOrWhiteSpace(txtNoTelp.Text))
            {
                MessageBox.Show("Harap isi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin mengubah data penerima ini?", "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Penerima SET Nama_Penerima = @Nama, Alamat = @Alamat, NoTelp = @NoTelp WHERE ID_Penerima = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtIDPenerima.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nama", txtNama.Text.Trim());
                        cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text.Trim());
                        cmd.Parameters.AddWithValue("@NoTelp", txtNoTelp.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Penerima berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan atau gagal diubah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPenerima.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            string id = dgvPenerima.SelectedRows[0].Cells["ID Penerima"].Value.ToString();
                            string query = "DELETE FROM Penerima WHERE ID_Penerima = @ID";

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
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data berhasil direfresh.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvPenerima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPenerima.Rows[e.RowIndex];

                txtIDPenerima.Text = row.Cells["ID Penerima"].Value?.ToString();
                txtNama.Text = row.Cells["Nama Penerima"].Value?.ToString();
                txtAlamat.Text = row.Cells["Alamat"].Value?.ToString();
                txtNoTelp.Text = row.Cells["No Telp"].Value?.ToString(); // Ini diperbaiki!
            }
        }

        private void GenerateIDPenerimaBaru()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TOP 1 ID_Penerima FROM Penerima ORDER BY ID_Penerima DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    int nextNumber = 1;

                    if (result != null)
                    {
                        string lastID = result.ToString(); // Contoh: "P005"
                        string numberPart = lastID.Substring(1); // ambil "005"
                        if (int.TryParse(numberPart, out int parsedNumber))
                        {
                            nextNumber = parsedNumber + 1;
                        }
                    }

                    txtIDPenerima.Text = "P" + nextNumber.ToString("D3"); // Format jadi "P001"
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal generate ID Penerima baru: " + ex.Message);
                }
            }
        }



    }
}
