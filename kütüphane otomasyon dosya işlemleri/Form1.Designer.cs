namespace kütüphane_otomasyon_dosya_işlemleri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KitapAdi_txt = new System.Windows.Forms.TextBox();
            this.KütüphaneAd_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ISBN_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.İadeTarihi_Date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.GünlükÜcret_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.İade_label = new System.Windows.Forms.Label();
            this.KişiAd_label = new System.Windows.Forms.Label();
            this.KitapAd_label = new System.Windows.Forms.Label();
            this.KişiAdı_txt = new System.Windows.Forms.TextBox();
            this.Ekle_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GecikmeÜcreti_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.KişiAdİade_txt = new System.Windows.Forms.TextBox();
            this.KitapAdİade_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.İade_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UzatmaÜcret_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Güncelle_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UzatmaTarih_Date = new System.Windows.Forms.DateTimePicker();
            this.KişiAdGüncelleme_txt = new System.Windows.Forms.TextBox();
            this.KitapAdGüncelleme_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SorguTxt = new System.Windows.Forms.TextBox();
            this.SorguSayısı = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.SorguList = new System.Windows.Forms.ListView();
            this.SorguBox1 = new System.Windows.Forms.ComboBox();
            this.sorguBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.KayıtSayısı_Label = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.GeriAnaEkranDön_btn = new System.Windows.Forms.Button();
            this.geri_lbl = new System.Windows.Forms.Label();
            this.TelNo_txt = new System.Windows.Forms.MaskedTextBox();
            this.msksorgutel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // KitapAdi_txt
            // 
            this.KitapAdi_txt.Location = new System.Drawing.Point(181, 47);
            this.KitapAdi_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KitapAdi_txt.Name = "KitapAdi_txt";
            this.KitapAdi_txt.Size = new System.Drawing.Size(203, 34);
            this.KitapAdi_txt.TabIndex = 1;
            // 
            // KütüphaneAd_lbl
            // 
            this.KütüphaneAd_lbl.AutoSize = true;
            this.KütüphaneAd_lbl.BackColor = System.Drawing.SystemColors.Desktop;
            this.KütüphaneAd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KütüphaneAd_lbl.ForeColor = System.Drawing.Color.LightCoral;
            this.KütüphaneAd_lbl.Location = new System.Drawing.Point(717, 23);
            this.KütüphaneAd_lbl.Name = "KütüphaneAd_lbl";
            this.KütüphaneAd_lbl.Size = new System.Drawing.Size(391, 38);
            this.KütüphaneAd_lbl.TabIndex = 2;
            this.KütüphaneAd_lbl.Text = "AHSEN KÜTÜPHANESİ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.TelNo_txt);
            this.groupBox1.Controls.Add(this.ISBN_txt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.İadeTarihi_Date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.GünlükÜcret_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.İade_label);
            this.groupBox1.Controls.Add(this.KişiAd_label);
            this.groupBox1.Controls.Add(this.KitapAd_label);
            this.groupBox1.Controls.Add(this.KişiAdı_txt);
            this.groupBox1.Controls.Add(this.Ekle_btn);
            this.groupBox1.Controls.Add(this.KitapAdi_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(43, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(435, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Alımı Ekle";
            // 
            // ISBN_txt
            // 
            this.ISBN_txt.Location = new System.Drawing.Point(179, 94);
            this.ISBN_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBN_txt.Name = "ISBN_txt";
            this.ISBN_txt.Size = new System.Drawing.Size(205, 34);
            this.ISBN_txt.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(14, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 29);
            this.label12.TabIndex = 13;
            this.label12.Text = "ISBN No :";
            // 
            // İadeTarihi_Date
            // 
            this.İadeTarihi_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İadeTarihi_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İadeTarihi_Date.Location = new System.Drawing.Point(181, 294);
            this.İadeTarihi_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.İadeTarihi_Date.Name = "İadeTarihi_Date";
            this.İadeTarihi_Date.Size = new System.Drawing.Size(245, 27);
            this.İadeTarihi_Date.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(13, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tel No :";
            // 
            // GünlükÜcret_txt
            // 
            this.GünlükÜcret_txt.Location = new System.Drawing.Point(181, 243);
            this.GünlükÜcret_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GünlükÜcret_txt.Name = "GünlükÜcret_txt";
            this.GünlükÜcret_txt.Size = new System.Drawing.Size(203, 34);
            this.GünlükÜcret_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Günlük Ücret :";
            // 
            // İade_label
            // 
            this.İade_label.AutoSize = true;
            this.İade_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.İade_label.Location = new System.Drawing.Point(9, 292);
            this.İade_label.Name = "İade_label";
            this.İade_label.Size = new System.Drawing.Size(140, 29);
            this.İade_label.TabIndex = 8;
            this.İade_label.Text = "İade Tarihi :";
            // 
            // KişiAd_label
            // 
            this.KişiAd_label.AutoSize = true;
            this.KişiAd_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KişiAd_label.Location = new System.Drawing.Point(13, 145);
            this.KişiAd_label.Name = "KişiAd_label";
            this.KişiAd_label.Size = new System.Drawing.Size(106, 29);
            this.KişiAd_label.TabIndex = 7;
            this.KişiAd_label.Text = "Kişi Adı :";
            // 
            // KitapAd_label
            // 
            this.KitapAd_label.AutoSize = true;
            this.KitapAd_label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.KitapAd_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KitapAd_label.Location = new System.Drawing.Point(14, 47);
            this.KitapAd_label.Name = "KitapAd_label";
            this.KitapAd_label.Size = new System.Drawing.Size(121, 29);
            this.KitapAd_label.TabIndex = 6;
            this.KitapAd_label.Text = "Kitap Adı :";
            // 
            // KişiAdı_txt
            // 
            this.KişiAdı_txt.Location = new System.Drawing.Point(181, 142);
            this.KişiAdı_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KişiAdı_txt.Name = "KişiAdı_txt";
            this.KişiAdı_txt.Size = new System.Drawing.Size(203, 34);
            this.KişiAdı_txt.TabIndex = 2;
            // 
            // Ekle_btn
            // 
            this.Ekle_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ekle_btn.Location = new System.Drawing.Point(19, 335);
            this.Ekle_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ekle_btn.Name = "Ekle_btn";
            this.Ekle_btn.Size = new System.Drawing.Size(387, 33);
            this.Ekle_btn.TabIndex = 6;
            this.Ekle_btn.Text = "Ekle ve Ücret Hesapla";
            this.Ekle_btn.UseVisualStyleBackColor = false;
            this.Ekle_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GecikmeÜcreti_txt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.KişiAdİade_txt);
            this.groupBox3.Controls.Add(this.KitapAdİade_txt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.İade_btn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(43, 462);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(429, 183);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap İade";
            // 
            // GecikmeÜcreti_txt
            // 
            this.GecikmeÜcreti_txt.Location = new System.Drawing.Point(297, 135);
            this.GecikmeÜcreti_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GecikmeÜcreti_txt.Name = "GecikmeÜcreti_txt";
            this.GecikmeÜcreti_txt.Size = new System.Drawing.Size(100, 34);
            this.GecikmeÜcreti_txt.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(9, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Günlük Gecikme Ücreti :";
            // 
            // KişiAdİade_txt
            // 
            this.KişiAdİade_txt.Location = new System.Drawing.Point(136, 92);
            this.KişiAdİade_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KişiAdİade_txt.Name = "KişiAdİade_txt";
            this.KişiAdİade_txt.Size = new System.Drawing.Size(100, 34);
            this.KişiAdİade_txt.TabIndex = 8;
            // 
            // KitapAdİade_txt
            // 
            this.KitapAdİade_txt.Location = new System.Drawing.Point(136, 42);
            this.KitapAdİade_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KitapAdİade_txt.Name = "KitapAdİade_txt";
            this.KitapAdİade_txt.Size = new System.Drawing.Size(100, 34);
            this.KitapAdİade_txt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kişi Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap Adı :";
            // 
            // İade_btn
            // 
            this.İade_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.İade_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İade_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.İade_btn.Location = new System.Drawing.Point(260, 31);
            this.İade_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.İade_btn.Name = "İade_btn";
            this.İade_btn.Size = new System.Drawing.Size(155, 94);
            this.İade_btn.TabIndex = 10;
            this.İade_btn.Text = "İade Al ve Ek Ücret Hesapla";
            this.İade_btn.UseVisualStyleBackColor = false;
            this.İade_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Controls.Add(this.UzatmaÜcret_txt);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Güncelle_btn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.UzatmaTarih_Date);
            this.groupBox4.Controls.Add(this.KişiAdGüncelleme_txt);
            this.groupBox4.Controls.Add(this.KitapAdGüncelleme_txt);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(43, 661);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(435, 296);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap Tarih Uzat";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // UzatmaÜcret_txt
            // 
            this.UzatmaÜcret_txt.Location = new System.Drawing.Point(179, 181);
            this.UzatmaÜcret_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UzatmaÜcret_txt.Name = "UzatmaÜcret_txt";
            this.UzatmaÜcret_txt.Size = new System.Drawing.Size(100, 34);
            this.UzatmaÜcret_txt.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(5, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Günlük Ücret :";
            // 
            // Güncelle_btn
            // 
            this.Güncelle_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Güncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Güncelle_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Güncelle_btn.Location = new System.Drawing.Point(19, 236);
            this.Güncelle_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Güncelle_btn.Name = "Güncelle_btn";
            this.Güncelle_btn.Size = new System.Drawing.Size(387, 33);
            this.Güncelle_btn.TabIndex = 15;
            this.Güncelle_btn.Text = "Güncelle ve Ücret Hesapla";
            this.Güncelle_btn.UseVisualStyleBackColor = false;
            this.Güncelle_btn.Click += new System.EventHandler(this.Güncelle_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(5, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Yeni Tarih :";
            // 
            // UzatmaTarih_Date
            // 
            this.UzatmaTarih_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UzatmaTarih_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UzatmaTarih_Date.Location = new System.Drawing.Point(179, 139);
            this.UzatmaTarih_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UzatmaTarih_Date.Name = "UzatmaTarih_Date";
            this.UzatmaTarih_Date.Size = new System.Drawing.Size(245, 27);
            this.UzatmaTarih_Date.TabIndex = 13;
            // 
            // KişiAdGüncelleme_txt
            // 
            this.KişiAdGüncelleme_txt.Location = new System.Drawing.Point(179, 86);
            this.KişiAdGüncelleme_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KişiAdGüncelleme_txt.Name = "KişiAdGüncelleme_txt";
            this.KişiAdGüncelleme_txt.Size = new System.Drawing.Size(100, 34);
            this.KişiAdGüncelleme_txt.TabIndex = 12;
            // 
            // KitapAdGüncelleme_txt
            // 
            this.KitapAdGüncelleme_txt.Location = new System.Drawing.Point(179, 38);
            this.KitapAdGüncelleme_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KitapAdGüncelleme_txt.Name = "KitapAdGüncelleme_txt";
            this.KitapAdGüncelleme_txt.Size = new System.Drawing.Size(100, 34);
            this.KitapAdGüncelleme_txt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(5, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kişi Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kitap Adı :";
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.List.GridLines = true;
            this.List.HideSelection = false;
            this.List.Location = new System.Drawing.Point(6, 63);
            this.List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(884, 352);
            this.List.TabIndex = 6;
            this.List.TabStop = false;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox5.Controls.Add(this.msksorgutel);
            this.groupBox5.Controls.Add(this.SorguTxt);
            this.groupBox5.Controls.Add(this.SorguSayısı);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.SorguList);
            this.groupBox5.Controls.Add(this.SorguBox1);
            this.groupBox5.Controls.Add(this.sorguBtn);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(568, 541);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(890, 416);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sorgu Yap";
            // 
            // SorguTxt
            // 
            this.SorguTxt.Location = new System.Drawing.Point(179, 60);
            this.SorguTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SorguTxt.Name = "SorguTxt";
            this.SorguTxt.Size = new System.Drawing.Size(195, 34);
            this.SorguTxt.TabIndex = 21;
            this.SorguTxt.Visible = false;
            // 
            // SorguSayısı
            // 
            this.SorguSayısı.AutoSize = true;
            this.SorguSayısı.BackColor = System.Drawing.SystemColors.ControlText;
            this.SorguSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SorguSayısı.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.SorguSayısı.LinkColor = System.Drawing.Color.Red;
            this.SorguSayısı.Location = new System.Drawing.Point(685, 103);
            this.SorguSayısı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SorguSayısı.Name = "SorguSayısı";
            this.SorguSayısı.Size = new System.Drawing.Size(22, 33);
            this.SorguSayısı.TabIndex = 20;
            this.SorguSayısı.TabStop = true;
            this.SorguSayısı.Text = "0";
            this.SorguSayısı.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(540, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Kayıt Sayısı: ";
            // 
            // SorguList
            // 
            this.SorguList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SorguList.GridLines = true;
            this.SorguList.HideSelection = false;
            this.SorguList.Location = new System.Drawing.Point(6, 137);
            this.SorguList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SorguList.Name = "SorguList";
            this.SorguList.Size = new System.Drawing.Size(878, 252);
            this.SorguList.TabIndex = 18;
            this.SorguList.TabStop = false;
            this.SorguList.UseCompatibleStateImageBehavior = false;
            this.SorguList.View = System.Windows.Forms.View.Details;
            // 
            // SorguBox1
            // 
            this.SorguBox1.FormattingEnabled = true;
            this.SorguBox1.Items.AddRange(new object[] {
            "Kitap Adı",
            "Tel No"});
            this.SorguBox1.Location = new System.Drawing.Point(20, 57);
            this.SorguBox1.Name = "SorguBox1";
            this.SorguBox1.Size = new System.Drawing.Size(121, 37);
            this.SorguBox1.TabIndex = 17;
            this.SorguBox1.SelectedIndexChanged += new System.EventHandler(this.SorguBox1_SelectedIndexChanged);
            // 
            // sorguBtn
            // 
            this.sorguBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.sorguBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorguBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sorguBtn.Location = new System.Drawing.Point(19, 99);
            this.sorguBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sorguBtn.Name = "sorguBtn";
            this.sorguBtn.Size = new System.Drawing.Size(228, 33);
            this.sorguBtn.TabIndex = 16;
            this.sorguBtn.Text = "Sorgula";
            this.sorguBtn.UseVisualStyleBackColor = false;
            this.sorguBtn.Click += new System.EventHandler(this.sorguBtn1_Click_1);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox6.Controls.Add(this.List);
            this.groupBox6.Controls.Add(this.KayıtSayısı_Label);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(562, 63);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(896, 427);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alınan Kitaplar";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // KayıtSayısı_Label
            // 
            this.KayıtSayısı_Label.AutoSize = true;
            this.KayıtSayısı_Label.BackColor = System.Drawing.SystemColors.ControlText;
            this.KayıtSayısı_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtSayısı_Label.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.KayıtSayısı_Label.LinkColor = System.Drawing.Color.Red;
            this.KayıtSayısı_Label.Location = new System.Drawing.Point(705, 28);
            this.KayıtSayısı_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KayıtSayısı_Label.Name = "KayıtSayısı_Label";
            this.KayıtSayısı_Label.Size = new System.Drawing.Size(22, 33);
            this.KayıtSayısı_Label.TabIndex = 8;
            this.KayıtSayısı_Label.TabStop = true;
            this.KayıtSayısı_Label.Text = "9";
            this.KayıtSayısı_Label.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(560, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kayıt Sayısı: ";
            // 
            // GeriAnaEkranDön_btn
            // 
            this.GeriAnaEkranDön_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.GeriAnaEkranDön_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeriAnaEkranDön_btn.BackgroundImage")));
            this.GeriAnaEkranDön_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriAnaEkranDön_btn.Location = new System.Drawing.Point(156, 12);
            this.GeriAnaEkranDön_btn.Name = "GeriAnaEkranDön_btn";
            this.GeriAnaEkranDön_btn.Size = new System.Drawing.Size(69, 46);
            this.GeriAnaEkranDön_btn.TabIndex = 9;
            this.GeriAnaEkranDön_btn.UseVisualStyleBackColor = false;
            this.GeriAnaEkranDön_btn.Click += new System.EventHandler(this.GeriAnaEkranDön_btn_Click);
            // 
            // geri_lbl
            // 
            this.geri_lbl.AutoSize = true;
            this.geri_lbl.BackColor = System.Drawing.Color.Orange;
            this.geri_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_lbl.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.geri_lbl.Location = new System.Drawing.Point(35, 12);
            this.geri_lbl.Name = "geri_lbl";
            this.geri_lbl.Size = new System.Drawing.Size(117, 46);
            this.geri_lbl.TabIndex = 10;
            this.geri_lbl.Text = "GERİ";
            // 
            // TelNo_txt
            // 
            this.TelNo_txt.Location = new System.Drawing.Point(181, 191);
            this.TelNo_txt.Name = "TelNo_txt";
            this.TelNo_txt.Size = new System.Drawing.Size(203, 34);
            this.TelNo_txt.TabIndex = 15;
            // 
            // msksorgutel
            // 
            this.msksorgutel.Location = new System.Drawing.Point(179, 60);
            this.msksorgutel.Name = "msksorgutel";
            this.msksorgutel.Size = new System.Drawing.Size(203, 34);
            this.msksorgutel.TabIndex = 22;
            this.msksorgutel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.geri_lbl);
            this.Controls.Add(this.GeriAnaEkranDön_btn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KütüphaneAd_lbl);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kitap Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox KitapAdi_txt;
        private System.Windows.Forms.Label KütüphaneAd_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox KişiAdı_txt;
        private System.Windows.Forms.Button Ekle_btn;
        private System.Windows.Forms.Label KitapAd_label;
        private System.Windows.Forms.Label KişiAd_label;
        private System.Windows.Forms.Label İade_label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox KişiAdİade_txt;
        private System.Windows.Forms.TextBox KitapAdİade_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button İade_btn;
        private System.Windows.Forms.TextBox GünlükÜcret_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox KişiAdGüncelleme_txt;
        private System.Windows.Forms.TextBox KitapAdGüncelleme_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Güncelle_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GecikmeÜcreti_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UzatmaÜcret_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.LinkLabel KayıtSayısı_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker İadeTarihi_Date;
        private System.Windows.Forms.DateTimePicker UzatmaTarih_Date;
        private System.Windows.Forms.Button GeriAnaEkranDön_btn;
        private System.Windows.Forms.Label geri_lbl;
        private System.Windows.Forms.Button sorguBtn;
        private System.Windows.Forms.ComboBox SorguBox1;
        private System.Windows.Forms.ListView SorguList;
        private System.Windows.Forms.LinkLabel SorguSayısı;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SorguTxt;
        private System.Windows.Forms.TextBox ISBN_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox TelNo_txt;
        private System.Windows.Forms.MaskedTextBox msksorgutel;
    }
}

