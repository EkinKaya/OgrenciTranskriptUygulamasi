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
    public partial class frmTranskriptGoruntule : Form
    {
        public frmTranskriptGoruntule()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbders; user ID=postgres; password=33337069396");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from ders";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        double ganohesap = 0, ganosonuc = 0;
        int toplamkredi = 0;
        private void btnGano_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutGano = new NpgsqlCommand("select \"HARF_NOTU\", \"DERS_KREDI\" from ders where \"HARF_NOTU\" is not null", baglanti);
            NpgsqlDataReader dr = komutGano.ExecuteReader();
            while (dr.Read())
            { 
                
                if (dr[0].ToString() == "AA")
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 4;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
                else if (dr[0].ToString() == "BA")
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 3.5;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
                else if (dr[0].ToString() == "BB")
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 3;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
                else if (dr[0].ToString() == "CB")
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 2.5;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
                else if (dr[0].ToString() == "CC")
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 2;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
                else if (dr[0].ToString() == "DC")
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 1.5;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
                else if (dr[0].ToString() == "DD")
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 1;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
                else if (dr[0].ToString() == "FD")
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 0.5;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
                else
                {
                    ganohesap += Convert.ToDouble(dr[1]) * 0;
                    toplamkredi += Convert.ToInt32(dr[1]);
                }
            }
            baglanti.Close();
            ganosonuc = ganohesap / toplamkredi;
            lblSonuc.Text = ganosonuc.ToString();
        }
    }
}
