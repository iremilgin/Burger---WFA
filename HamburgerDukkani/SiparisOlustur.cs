using HamburgerDukkani.Classes;
using HamburgerDukkani.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = HamburgerDukkani.Classes.Menu;

namespace HamburgerDukkani
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
            yeniSiparisler = new List<Siparis>();
        }

        List<Siparis> yeniSiparisler;
        double toplam = 0;
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (Menu  menu in MainMenu.Menuler)
            {
                cboxUrunler.Items.Add(menu);
            }

            foreach (EkstraMalzeme ekstraMalzeme in MainMenu.EkstraMalzemeler )
            {
                CheckBox cbox = new CheckBox();
                cbox.Text = ekstraMalzeme.Adi;
                cbox.Tag = ekstraMalzeme;
                clboxEkstraMalzemeler.Items.Add(cbox);
            }

            cboxUrunler.SelectedIndex = 0;
            rbKucuk.Checked = true;
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.Menu = (Menu)cboxUrunler.SelectedItem;

            foreach (CheckBox cbox in clboxEkstraMalzemeler.CheckedItems)
            {
                siparis.EkstraMalzemeler.Add((EkstraMalzeme)cbox.Tag);                                                                                             
            }

            if (rbOrta.Checked)
                siparis.Boy = Boy.Orta;
            else if (rbBuyuk.Checked)
                siparis.Boy = Boy.Büyük;
            else siparis.Boy = Boy.Küçük;

            siparis.Adet =(int)nmrUpDownAdet.Value;
            toplam += siparis.ToplamFiyat;
            lblToplamFiyat.Text = toplam.ToString("C2");
            
            yeniSiparisler.Add(siparis);
            lboxUrunler.Items.Add(siparis);
            Helper.Temizle(this.Controls);
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {

           DialogResult dr = MessageBox.Show("Siparisi onaylıyor musunuz?", "Onay", MessageBoxButtons.OKCancel);
            if(dr == DialogResult.OK)
            {
                MainMenu.Siparisler.AddRange(yeniSiparisler);
                lboxUrunler.Items.Clear();
                toplam = 0;
                yeniSiparisler.Clear();
            }

        }    
            
        
    }
}
