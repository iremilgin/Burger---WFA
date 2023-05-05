namespace HamburgerDukkani
{
    partial class MenuEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.nmrcMenuEkleFiyat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMenuEkleFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(129, 104);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(120, 23);
            this.txtMenuAdi.TabIndex = 3;
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuEkle.Location = new System.Drawing.Point(129, 214);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(120, 43);
            this.btnMenuEkle.TabIndex = 5;
            this.btnMenuEkle.Text = "Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // nmrcMenuEkleFiyat
            // 
            this.nmrcMenuEkleFiyat.Location = new System.Drawing.Point(129, 158);
            this.nmrcMenuEkleFiyat.Name = "nmrcMenuEkleFiyat";
            this.nmrcMenuEkleFiyat.Size = new System.Drawing.Size(120, 23);
            this.nmrcMenuEkleFiyat.TabIndex = 6;
            // 
            // MenuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 313);
            this.Controls.Add(this.nmrcMenuEkleFiyat);
            this.Controls.Add(this.btnMenuEkle);
            this.Controls.Add(this.txtMenuAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuEkle";
            this.Text = "UrunEkle";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMenuEkleFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMenuAdi;
        private Button btnMenuEkle;
        private NumericUpDown nmrcMenuEkleFiyat;
    }
}