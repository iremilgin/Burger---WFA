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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
            
        }

        
        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            
            menu.Adi = txtMenuAdi.Text;
            menu.Fiyat = (double)nmrcMenuEkleFiyat.Value;
            MainMenu.Menuler.Add(menu);
            Helper.Temizle(this.Controls);
            
        }
    }
}
