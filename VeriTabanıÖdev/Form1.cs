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
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersEkle frmDersEkle = new frmDersEkle();
            frmDersEkle.MdiParent = this;
            frmDersEkle.Show();
        }

        private void dersSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersSil frmDersSil = new frmDersSil();
            frmDersSil.MdiParent = this;
            frmDersSil.Show();
        }

        private void transkriptGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTranskriptGoruntule frmTranskriptGoruntule = new frmTranskriptGoruntule();
            frmTranskriptGoruntule.MdiParent = this;
            frmTranskriptGoruntule.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersGuncelle frmDersGuncelle = new frmDersGuncelle();
            frmDersGuncelle.MdiParent = this;
            frmDersGuncelle.Show();
        }
    }
}
