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
    
    public partial class Form4 : Form
    {
        private string connectionString = "Data source=LAPTOP-HV1LJOCH\\HAFIDZ;Initial Catalog=DonasiBarangBekas;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }
        private void Donasi_Load(object sender, EventArgs e)
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
                    string query = @"SELECT ID_Donasi AS [ID Donasi], ID_Donatur AS [ID Donatur], 
                                    Tanggal_Donasi AS [Tanggal Donasi], Jenis_Barang AS [Jenis Barang], 
                                    Jumlah FROM Donasi";
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
            txtJumlah.Clear();
            txtIDDonasi.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtIDDonasi.Text == "" || txtIDDonatur.Text == "" || txtJenisBarang.Text == "" || txtJumlah.Text == "")
            {
                MessageBox.Show("Harap isi semua data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Donasi (ID_Donasi, ID_Donatur, Tanggal_Donasi, Jenis_Barang, Jumlah) VALUES (@ID, @Donatur, @Tanggal, @Jenis, @Jumlah)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDDonasi.Text.Trim());
                    cmd.Parameters.AddWithValue("@Donatur", txtIDDonatur.Text.Trim());
                    cmd.Parameters.AddWithValue("@Jenis", txtJenisBarang.Text.Trim());
                    cmd.Parameters.AddWithValue("@Jumlah", txtJumlah.Text.Trim());

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
                MessageBox.Show("Isi ID Donasi terlebih dahulu.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Donasi SET ID_Donatur=@Donatur, Tanggal_Donasi=@Tanggal, Jenis_Barang=@Jenis, Jumlah=@Jumlah WHERE ID_Donasi=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", txtIDDonasi.Text);
                    cmd.Parameters.AddWithValue("@Donatur", txtIDDonatur.Text);
                    cmd.Parameters.AddWithValue("@Jenis", txtJenisBarang.Text);
                    cmd.Parameters.AddWithValue("@Jumlah", txtJumlah.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data Donasi berhasil diubah.");
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
            if (dgvDonasi.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            string id = dgvDonasi.SelectedRows[0].Cells["ID_Donasi"].Value.ToString();
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
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
