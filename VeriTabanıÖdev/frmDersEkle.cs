using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanıÖdev
{
    public partial class frmDersEkle : Form
    {
        public frmDersEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbders; user ID=postgres; password=33337069396");
        private void frmDersEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutekleme = new NpgsqlCommand("insert into ders (\"DERS_KODU\", \"DERS_ADI\", \"DERS_KREDI\", \"AKTS\", \"OGR_UYESI\", \"DONEM\", \"HARF_NOTU\") values (@derskodu, @dersad, @derskredi, @dersakts, @ogruyesi, @donem, @harfnotu)", baglanti);
            komutekleme.Parameters.AddWithValue("@derskodu", txtID.Text);
            komutekleme.Parameters.AddWithValue("@dersad", txtAd.Text);
            komutekleme.Parameters.AddWithValue("@derskredi", int.Parse( numericUpDownKredi.Value.ToString()));
            komutekleme.Parameters.AddWithValue("@dersakts", int.Parse( numericUpDownAKTS.Value.ToString()));
            komutekleme.Parameters.AddWithValue("@ogruyesi", txtOgr.Text);
            komutekleme.Parameters.AddWithValue("@donem", txtDonem.Text);
            komutekleme.Parameters.AddWithValue("@harfnotu", txtNot.Text);
            komutekleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders ekleme başarılı");
        }
    }
}
