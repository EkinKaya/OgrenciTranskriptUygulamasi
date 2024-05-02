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
    public partial class frmDersGuncelle : Form
    {
        public frmDersGuncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbders; user ID=postgres; password=33337069396");
        private void frmDersGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from ders where \"DERS_KODU\"= @derskodu";
            NpgsqlCommand komut3 = new NpgsqlCommand(sorgu, baglanti);
            komut3.Parameters.AddWithValue("@derskodu", txtGuncellenecekDers.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewGüncelleme.DataSource = dt;
            MessageBox.Show("Güncelleme ekranını otomatik doldurmak için listeleme ekranındaki oka tıklayabilirsiniz.");
            baglanti.Close();
        }
        int i = 0;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutguncelle = new NpgsqlCommand("Update ders set \"DERS_ADI\"=@dersad, \"DERS_KREDI\"=@derskredi, \"AKTS\"=@dersakts, \"OGR_UYESI\"=@ogruye, \"DONEM\"=@donem, \"HARF_NOTU\"=@harfnot where \"DERS_KODU\"= @derskodu ", baglanti);
            komutguncelle.Parameters.AddWithValue("@derskodu", txtKod.Text);
            komutguncelle.Parameters.AddWithValue("@dersad", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@derskredi", int.Parse(numericUpDownKredi.Value.ToString()));
            komutguncelle.Parameters.AddWithValue("@dersakts", int.Parse(numericUpDownAKTS.Value.ToString()));
            komutguncelle.Parameters.AddWithValue("@ogruye", txtOgr.Text);
            komutguncelle.Parameters.AddWithValue("@donem", txtDonem.Text);
            komutguncelle.Parameters.AddWithValue("@harfnot", txtNot.Text);
            komutguncelle.Parameters.AddWithValue("derskodu",dataGridViewGüncelleme.Rows[i].Cells[0].Value);
            if (MessageBox.Show("Güncelleme işleminde devam etmek ister misiniz?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                komutguncelle.ExecuteNonQuery();
                MessageBox.Show("Kayıt güncelleme başarı ile tamamlandı.");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi iptal edildi.");
                baglanti.Close();
            }
        }

        private void dataGridViewGüncelleme_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txtKod.Text = dataGridViewGüncelleme.Rows[i].Cells[0].Value.ToString();
            txtAd.Text = dataGridViewGüncelleme.Rows[i].Cells[1].Value.ToString();
            txtOgr.Text = dataGridViewGüncelleme.Rows[i].Cells[4].Value.ToString();
            txtDonem.Text = dataGridViewGüncelleme.Rows[i].Cells[5].Value.ToString();
            txtNot.Text = dataGridViewGüncelleme.Rows[i].Cells[6].Value.ToString();
        }
    }
}
