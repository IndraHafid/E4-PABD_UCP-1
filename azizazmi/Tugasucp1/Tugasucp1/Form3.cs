using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugasucp1
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void btnDonatur_Click(object sender, EventArgs e)
        {
            // Pindah ke Form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnDonasi_Click(object sender, EventArgs e)
        {
            // Pindah ke Form4
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnPengiriman_Click(object sender, EventArgs e)
        {
            // Pindah ke Form5
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnPenerima_Click(object sender, EventArgs e)
        {
            // Pindah ke Form6
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }


        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();

        }
    }
}
