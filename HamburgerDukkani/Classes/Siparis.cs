using HamburgerDukkani.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerDukkani.Classes
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzeme>();
        }

        public Menu Menu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public Boy Boy { get; set; }
        public int Adet { get; set; }

        private double toplamFiyat;

        public double ToplamFiyat
        {
            get
            {

                toplamFiyat = Menu.Fiyat;
                if (this.Boy == Boy.Orta)
                {
                    toplamFiyat *= 1.1;
                }
                else if (this.Boy == Boy.Büyük)
                {
                    toplamFiyat *= 1.2;
                }

                foreach (EkstraMalzeme ekstraMalzeme in this.EkstraMalzemeler)
                {
                    toplamFiyat *= this.Adet;
                }
                    return toplamFiyat;

            }
        }

        public double EkstraMalzemeFiyatlari()
        {
            double toplam = 0;
            foreach (EkstraMalzeme ekstraMalzeme in this.EkstraMalzemeler)
            {
                toplam += ekstraMalzeme.Fiyat;

            }
            return toplam;
        }

        public override string ToString()
        {
            string ekstraMalzemeIsimleri = string.Empty;
            foreach (EkstraMalzeme ekstraMalzeme in this.EkstraMalzemeler)
            {
                ekstraMalzemeIsimleri += ekstraMalzeme.Adi + " ";
            }
            string bilgi = $"{this.Adet} Adet {this.Menu.Adi}, {ekstraMalzemeIsimleri}, {this.Boy} => Toplam : {this.ToplamFiyat.ToString("C2")}";
            return bilgi;
        }

    }

}
