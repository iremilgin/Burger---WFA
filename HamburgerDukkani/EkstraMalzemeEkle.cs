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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
           
        }

        private void EkstraMalzemeEkle_Load(object sender, EventArgs e)
        {
         
        }

       
        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            EkstraMalzeme ekstra = new EkstraMalzeme();
            ekstra.Adi = comboBox1.Text;
            ekstra.Fiyat = (double)numericUpDown1.Value;
            MainMenu.EkstraMalzemeler.Add(ekstra);
            Helper.Temizle(this.Controls);
        }

        
    }
}
