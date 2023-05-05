namespace HamburgerDukkani
{
    partial class SiparisOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            this.cboxUrunler = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lboxUrunler = new System.Windows.Forms.ListBox();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnSiparisOnayla = new System.Windows.Forms.Button();
            this.clboxEkstraMalzemeler = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDownAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxUrunler
            // 
            this.cboxUrunler.FormattingEnabled = true;
            this.cboxUrunler.Location = new System.Drawing.Point(10, 217);
            this.cboxUrunler.Name = "cboxUrunler";
            this.cboxUrunler.Size = new System.Drawing.Size(181, 23);
            this.cboxUrunler.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lboxUrunler
            // 
            this.lboxUrunler.FormattingEnabled = true;
            this.lboxUrunler.ItemHeight = 15;
            this.lboxUrunler.Location = new System.Drawing.Point(241, 12);
            this.lboxUrunler.Name = "lboxUrunler";
            this.lboxUrunler.Size = new System.Drawing.Size(571, 409);
            this.lboxUrunler.TabIndex = 0;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(10, 447);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(58, 19);
            this.rbKucuk.TabIndex = 1;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Kücük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(95, 447);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(48, 19);
            this.rbOrta.TabIndex = 2;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(174, 447);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(58, 19);
            this.rbBuyuk.TabIndex = 3;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Buyuk";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adet";
            // 
            // nmrUpDownAdet
            // 
            this.nmrUpDownAdet.Location = new System.Drawing.Point(84, 490);
            this.nmrUpDownAdet.Name = "nmrUpDownAdet";
            this.nmrUpDownAdet.Size = new System.Drawing.Size(120, 23);
            this.nmrUpDownAdet.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(15, 519);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(194, 52);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplam";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplamFiyat.ForeColor = System.Drawing.Color.Red;
            this.lblToplamFiyat.Location = new System.Drawing.Point(340, 532);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(22, 25);
            this.lblToplamFiyat.TabIndex = 8;
            this.lblToplamFiyat.Text = "₺";
            // 
            // btnSiparisOnayla
            // 
            this.btnSiparisOnayla.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiparisOnayla.Location = new System.Drawing.Point(600, 436);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.Size = new System.Drawing.Size(193, 121);
            this.btnSiparisOnayla.TabIndex = 9;
            this.btnSiparisOnayla.Text = "Siparisi Onayla";
            this.btnSiparisOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);
            // 
            // clboxEkstraMalzemeler
            // 
            this.clboxEkstraMalzemeler.FormattingEnabled = true;
            this.clboxEkstraMalzemeler.Location = new System.Drawing.Point(10, 257);
            this.clboxEkstraMalzemeler.Name = "clboxEkstraMalzemeler";
            this.clboxEkstraMalzemeler.Size = new System.Drawing.Size(194, 166);
            this.clboxEkstraMalzemeler.TabIndex = 10;
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 587);
            this.Controls.Add(this.clboxEkstraMalzemeler);
            this.Controls.Add(this.cboxUrunler);
            this.Controls.Add(this.btnSiparisOnayla);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nmrUpDownAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbKucuk);
            this.Controls.Add(this.lboxUrunler);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisOlustur";
            this.Text = "SiparisEkrani";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDownAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cboxUrunler;
        private PictureBox pictureBox1;
        private ListBox lboxUrunler;
        private RadioButton rbKucuk;
        private RadioButton rbOrta;
        private RadioButton rbBuyuk;
        private Label label1;
        private NumericUpDown nmrUpDownAdet;
        private Button btnEkle;
        private Label label2;
        private Label lblToplamFiyat;
        private Button btnSiparisOnayla;
        private CheckedListBox clboxEkstraMalzemeler;
    }
}