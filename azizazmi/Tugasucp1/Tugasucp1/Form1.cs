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
    public partial class Form1 : Form
    {
        koneksi kn = new koneksi();
        string strKonek = "";
        public Form1()
        {
            InitializeComponent();
            strKonek = kn.connectionString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtNamaAdmin.Text.Trim();
            string passwd = txtPasswd.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passwd))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(strKonek))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Admin WHERE Username = @username AND Passwd = @passwd";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@passwd", passwd);

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form3 form3 = new Form3();
                            form3.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
