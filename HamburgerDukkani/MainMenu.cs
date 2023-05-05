using HamburgerDukkani.Classes;

namespace HamburgerDukkani
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {

            InitializeComponent();
            Siparisler = new List<Siparis>();

        }

        public static List<Siparis> Siparisler;
        public static List<Menu> Menuler = new List<Menu>()
        {

            new Menu{Adi = "Whopper", Fiyat=125},
            new Menu{Adi = "King Chicken", Fiyat = 90}
        };

        public static List<EkstraMalzeme> EkstraMalzemeler = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{Adi="Ket�ap", Fiyat=11},
            new EkstraMalzeme{Adi="Mayonez", Fiyat=11}

        };

        private void MainMenu_Load(object sender, EventArgs e)
        {
            YeniFormEkle(new SiparisOlustur());
        }

        private void sipari�Olu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new SiparisOlustur());
        }

        private void t�mSipari�lerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            YeniFormEkle(new TumSiparisler());
        }

        private void men�EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            YeniFormEkle(new MenuEkle());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            YeniFormEkle(new EkstraMalzemeEkle());

        }
        private void FormlariKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }

        private void YeniFormEkle(Form form)
        {
            FormlariKapat();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            this.Width = form.Width + 50;
            this.Height = form.Height + 90;
            form.Show();
        }
    }
}
