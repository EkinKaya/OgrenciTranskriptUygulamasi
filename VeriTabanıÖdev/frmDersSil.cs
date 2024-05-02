using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanıÖdev
{
    public partial class frmDersSil : Form
    {
        public frmDersSil()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbders; user ID=postgres; password=33337069396");
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutsilme = new NpgsqlCommand("Delete From ders where \"DERS_KODU\" =@derskodu", baglanti);
            komutsilme.Parameters.AddWithValue("@derskodu", txtSilmeKodu.Text);
            if (MessageBox.Show("Silme işleminde devam etmek ister misiniz?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                komutsilme.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün silme işlemi gerçekleşti.");
            }
            else
            { 
                MessageBox.Show("Silme işlemi iptal edildi.");
                baglanti.Close();
            }
        }
    }
}
