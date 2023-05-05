using HamburgerDukkani.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerDukkani
{
    public partial class TumSiparisler : Form
    {
        public TumSiparisler()
        {
            InitializeComponent();
        }

        private void TumSiparisler_Load(object sender, EventArgs e)
        {
            double ciro = 0;
            int toplamSiparis = 0;
            double ekstraMalzemeGeliri = 0;
            int satilanUrunAdedi = 0;
            foreach (Siparis siparis in MainMenu.Siparisler)
            {
                lboxTumSiparisler.Items.Add(siparis);   
                ciro += siparis.ToplamFiyat;
                ekstraMalzemeGeliri += siparis.EkstraMalzemeFiyatlari();
                satilanUrunAdedi += siparis.EkstraMalzemeler.Count;
                satilanUrunAdedi++;
            }
            toplamSiparis = MainMenu.Siparisler.Count;

            lblCiro.Text = ciro.ToString("C2");
            lblToplamSiparis.Text = toplamSiparis.ToString("C2");
            lblEkstraMalzeme.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatilanUrun.Text = satilanUrunAdedi.ToString("C2");
        }
    }
}
