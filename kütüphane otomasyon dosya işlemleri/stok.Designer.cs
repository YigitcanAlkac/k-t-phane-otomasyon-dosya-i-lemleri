namespace kütüphane_otomasyon_dosya_işlemleri
{
    partial class stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stok));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Adet_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBN_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Raf_txt = new System.Windows.Forms.TextBox();
            this.Raf_Label = new System.Windows.Forms.Label();
            this.YayınYılı__txt = new System.Windows.Forms.TextBox();
            this.Ekle_btn = new System.Windows.Forms.Button();
            this.Yayınevi_txt = new System.Windows.Forms.TextBox();
            this.KitapTürü_txt = new System.Windows.Forms.TextBox();
            this.Yayınevi_Label = new System.Windows.Forms.Label();
            this.KitapTürü_Label = new System.Windows.Forms.Label();
            this.YayınYılı_Label = new System.Windows.Forms.Label();
            this.StokKişiAd_Label = new System.Windows.Forms.Label();
            this.YazarAd_Label = new System.Windows.Forms.Label();
            this.KitapAdı_txt = new System.Windows.Forms.TextBox();
            this.YazarAdi_txt = new System.Windows.Forms.TextBox();
            this.geri_lbl = new System.Windows.Forms.Label();
            this.GeriAnaEkranDön_btn = new System.Windows.Forms.Button();
            this.ListStok = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StokSayısı_Label = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.Adet_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ISBN_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Raf_txt);
            this.groupBox1.Controls.Add(this.Raf_Label);
            this.groupBox1.Controls.Add(this.YayınYılı__txt);
            this.groupBox1.Controls.Add(this.Ekle_btn);
            this.groupBox1.Controls.Add(this.Yayınevi_txt);
            this.groupBox1.Controls.Add(this.KitapTürü_txt);
            this.groupBox1.Controls.Add(this.Yayınevi_Label);
            this.groupBox1.Controls.Add(this.KitapTürü_Label);
            this.groupBox1.Controls.Add(this.YayınYılı_Label);
            this.groupBox1.Controls.Add(this.StokKişiAd_Label);
            this.groupBox1.Controls.Add(this.YazarAd_Label);
            this.groupBox1.Controls.Add(this.KitapAdı_txt);
            this.groupBox1.Controls.Add(this.YazarAdi_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(45, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(440, 476);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekle";
            // 
            // Adet_txt
            // 
            this.Adet_txt.Location = new System.Drawing.Point(228, 133);
            this.Adet_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Adet_txt.Name = "Adet_txt";
            this.Adet_txt.Size = new System.Drawing.Size(195, 34);
            this.Adet_txt.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adedi :";
            // 
            // ISBN_txt
            // 
            this.ISBN_txt.Location = new System.Drawing.Point(227, 366);
            this.ISBN_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBN_txt.Name = "ISBN_txt";
            this.ISBN_txt.Size = new System.Drawing.Size(195, 34);
            this.ISBN_txt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "ISN Numarası :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Raf_txt
            // 
            this.Raf_txt.Location = new System.Drawing.Point(228, 313);
            this.Raf_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Raf_txt.Name = "Raf_txt";
            this.Raf_txt.Size = new System.Drawing.Size(195, 34);
            this.Raf_txt.TabIndex = 16;
            // 
            // Raf_Label
            // 
            this.Raf_Label.AutoSize = true;
            this.Raf_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Raf_Label.Location = new System.Drawing.Point(14, 318);
            this.Raf_Label.Name = "Raf_Label";
            this.Raf_Label.Size = new System.Drawing.Size(133, 29);
            this.Raf_Label.TabIndex = 15;
            this.Raf_Label.Text = "Raf Bilgisi :";
            // 
            // YayınYılı__txt
            // 
            this.YayınYılı__txt.Location = new System.Drawing.Point(228, 267);
            this.YayınYılı__txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YayınYılı__txt.Name = "YayınYılı__txt";
            this.YayınYılı__txt.Size = new System.Drawing.Size(195, 34);
            this.YayınYılı__txt.TabIndex = 14;
            // 
            // Ekle_btn
            // 
            this.Ekle_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ekle_btn.Location = new System.Drawing.Point(19, 422);
            this.Ekle_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ekle_btn.Name = "Ekle_btn";
            this.Ekle_btn.Size = new System.Drawing.Size(403, 33);
            this.Ekle_btn.TabIndex = 6;
            this.Ekle_btn.Text = "Kitap Ekle";
            this.Ekle_btn.UseVisualStyleBackColor = false;
            this.Ekle_btn.Click += new System.EventHandler(this.Ekle_btn_Click);
            // 
            // Yayınevi_txt
            // 
            this.Yayınevi_txt.Location = new System.Drawing.Point(228, 221);
            this.Yayınevi_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Yayınevi_txt.Name = "Yayınevi_txt";
            this.Yayınevi_txt.Size = new System.Drawing.Size(195, 34);
            this.Yayınevi_txt.TabIndex = 13;
            // 
            // KitapTürü_txt
            // 
            this.KitapTürü_txt.Location = new System.Drawing.Point(228, 175);
            this.KitapTürü_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KitapTürü_txt.Name = "KitapTürü_txt";
            this.KitapTürü_txt.Size = new System.Drawing.Size(195, 34);
            this.KitapTürü_txt.TabIndex = 3;
            // 
            // Yayınevi_Label
            // 
            this.Yayınevi_Label.AutoSize = true;
            this.Yayınevi_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Yayınevi_Label.Location = new System.Drawing.Point(14, 226);
            this.Yayınevi_Label.Name = "Yayınevi_Label";
            this.Yayınevi_Label.Size = new System.Drawing.Size(115, 29);
            this.Yayınevi_Label.TabIndex = 12;
            this.Yayınevi_Label.Text = "Yayınevi :";
            // 
            // KitapTürü_Label
            // 
            this.KitapTürü_Label.AutoSize = true;
            this.KitapTürü_Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.KitapTürü_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KitapTürü_Label.Location = new System.Drawing.Point(14, 180);
            this.KitapTürü_Label.Name = "KitapTürü_Label";
            this.KitapTürü_Label.Size = new System.Drawing.Size(136, 29);
            this.KitapTürü_Label.TabIndex = 10;
            this.KitapTürü_Label.Text = "Kitap Türü :";
            // 
            // YayınYılı_Label
            // 
            this.YayınYılı_Label.AutoSize = true;
            this.YayınYılı_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YayınYılı_Label.Location = new System.Drawing.Point(14, 271);
            this.YayınYılı_Label.Name = "YayınYılı_Label";
            this.YayınYılı_Label.Size = new System.Drawing.Size(124, 29);
            this.YayınYılı_Label.TabIndex = 8;
            this.YayınYılı_Label.Text = "Yayın Yılı :";
            // 
            // StokKişiAd_Label
            // 
            this.StokKişiAd_Label.AutoSize = true;
            this.StokKişiAd_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StokKişiAd_Label.Location = new System.Drawing.Point(13, 86);
            this.StokKişiAd_Label.Name = "StokKişiAd_Label";
            this.StokKişiAd_Label.Size = new System.Drawing.Size(121, 29);
            this.StokKişiAd_Label.TabIndex = 7;
            this.StokKişiAd_Label.Text = "Kitap Adı :";
            // 
            // YazarAd_Label
            // 
            this.YazarAd_Label.AutoSize = true;
            this.YazarAd_Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.YazarAd_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YazarAd_Label.Location = new System.Drawing.Point(13, 42);
            this.YazarAd_Label.Name = "YazarAd_Label";
            this.YazarAd_Label.Size = new System.Drawing.Size(207, 29);
            this.YazarAd_Label.TabIndex = 6;
            this.YazarAd_Label.Text = "Yazar Adı Soyadı :";
            // 
            // KitapAdı_txt
            // 
            this.KitapAdı_txt.Location = new System.Drawing.Point(227, 86);
            this.KitapAdı_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KitapAdı_txt.Name = "KitapAdı_txt";
            this.KitapAdı_txt.Size = new System.Drawing.Size(195, 34);
            this.KitapAdı_txt.TabIndex = 2;
            // 
            // YazarAdi_txt
            // 
            this.YazarAdi_txt.Location = new System.Drawing.Point(227, 42);
            this.YazarAdi_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YazarAdi_txt.Name = "YazarAdi_txt";
            this.YazarAdi_txt.Size = new System.Drawing.Size(195, 34);
            this.YazarAdi_txt.TabIndex = 1;
            // 
            // geri_lbl
            // 
            this.geri_lbl.AutoSize = true;
            this.geri_lbl.BackColor = System.Drawing.Color.Orange;
            this.geri_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_lbl.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.geri_lbl.Location = new System.Drawing.Point(37, 23);
            this.geri_lbl.Name = "geri_lbl";
            this.geri_lbl.Size = new System.Drawing.Size(117, 46);
            this.geri_lbl.TabIndex = 12;
            this.geri_lbl.Text = "GERİ";
            // 
            // GeriAnaEkranDön_btn
            // 
            this.GeriAnaEkranDön_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.GeriAnaEkranDön_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeriAnaEkranDön_btn.BackgroundImage")));
            this.GeriAnaEkranDön_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriAnaEkranDön_btn.Location = new System.Drawing.Point(157, 23);
            this.GeriAnaEkranDön_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GeriAnaEkranDön_btn.Name = "GeriAnaEkranDön_btn";
            this.GeriAnaEkranDön_btn.Size = new System.Drawing.Size(69, 46);
            this.GeriAnaEkranDön_btn.TabIndex = 11;
            this.GeriAnaEkranDön_btn.UseVisualStyleBackColor = false;
            this.GeriAnaEkranDön_btn.Click += new System.EventHandler(this.GeriAnaEkranDön_btn_Click);
            // 
            // ListStok
            // 
            this.ListStok.GridLines = true;
            this.ListStok.HideSelection = false;
            this.ListStok.Location = new System.Drawing.Point(8, 59);
            this.ListStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListStok.Name = "ListStok";
            this.ListStok.Size = new System.Drawing.Size(1518, 395);
            this.ListStok.TabIndex = 13;
            this.ListStok.UseCompatibleStateImageBehavior = false;
            this.ListStok.View = System.Windows.Forms.View.Details;
            this.ListStok.SelectedIndexChanged += new System.EventHandler(this.ListStok_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.StokSayısı_Label);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ListStok);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(508, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1532, 476);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok Listesi";
            // 
            // StokSayısı_Label
            // 
            this.StokSayısı_Label.AutoSize = true;
            this.StokSayısı_Label.BackColor = System.Drawing.SystemColors.ControlText;
            this.StokSayısı_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokSayısı_Label.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.StokSayısı_Label.LinkColor = System.Drawing.Color.Red;
            this.StokSayısı_Label.Location = new System.Drawing.Point(387, 28);
            this.StokSayısı_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StokSayısı_Label.Name = "StokSayısı_Label";
            this.StokSayısı_Label.Size = new System.Drawing.Size(22, 33);
            this.StokSayısı_Label.TabIndex = 22;
            this.StokSayısı_Label.TabStop = true;
            this.StokSayısı_Label.Text = "0";
            this.StokSayısı_Label.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(241, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Kayıt Sayısı: ";
            // 
            // stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.geri_lbl);
            this.Controls.Add(this.GeriAnaEkranDön_btn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "stok";
            this.Text = "stok";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.stok_FormClosed);
            this.Load += new System.EventHandler(this.stok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox KitapTürü_txt;
        private System.Windows.Forms.Label Yayınevi_Label;
        private System.Windows.Forms.Label KitapTürü_Label;
        private System.Windows.Forms.Label YayınYılı_Label;
        private System.Windows.Forms.Label StokKişiAd_Label;
        private System.Windows.Forms.Label YazarAd_Label;
        private System.Windows.Forms.TextBox KitapAdı_txt;
        private System.Windows.Forms.Button Ekle_btn;
        private System.Windows.Forms.TextBox YazarAdi_txt;
        private System.Windows.Forms.Label geri_lbl;
        private System.Windows.Forms.Button GeriAnaEkranDön_btn;
        private System.Windows.Forms.TextBox YayınYılı__txt;
        private System.Windows.Forms.TextBox Yayınevi_txt;
        private System.Windows.Forms.ListView ListStok;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel StokSayısı_Label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Raf_txt;
        private System.Windows.Forms.Label Raf_Label;
        private System.Windows.Forms.TextBox ISBN_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adet_txt;
        private System.Windows.Forms.Label label2;
    }
}