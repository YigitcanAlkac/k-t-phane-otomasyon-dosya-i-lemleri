using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace kütüphane_otomasyon_dosya_işlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TelNo_txt.Mask = @"\0(000) 000-00-00";
            msksorgutel.Mask = @"\0(000) 000-00-00";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool stoktavarmı = false;
            DialogResult secenek = MessageBox.Show("Kayıt oluşturmak istiyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                string arındırılmış = new string(TelNo_txt.Text.Where(char.IsDigit).ToArray());
                if (arındırılmış.Length != 11)
                {
                    MessageBox.Show("Eksik bilgi girdiniz!");
                    return;
                }
                if (KitapAdi_txt.Text == "" || KişiAdı_txt.Text == "" || GünlükÜcret_txt.Text == "" || TelNo_txt.Text == "" || ISBN_txt.Text == "")
                {
                    MessageBox.Show("Eksik Bilgi Girdiniz!");
                    return;
                }
                bool ÜcretSayısalmı = false;
                ÜcretSayısalmı = Int32.TryParse(GünlükÜcret_txt.Text, out int dönüş);
                if (!ÜcretSayısalmı)
                {
                    MessageBox.Show("Ücret sayısal olmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                StreamReader sr = new StreamReader("C:\\ahsenstok.txt");
                while (true)
                {
                    string satır2 = sr.ReadLine();
                    if (satır2 != null)
                    {
                        string[] dizi1 = satır2.Split(',');
                        int adettut = Int32.Parse(dizi1[2]);
                        if (dizi1[1]==KitapAdi_txt.Text&& dizi1[7]==ISBN_txt.Text && adettut>0 )
                        {
                            stoktavarmı = true;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                sr.Close();
                if (stoktavarmı)
                {
                    FileStream fs = new FileStream("C:\\ahsen.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(KitapAdi_txt.Text + ',' + KişiAdı_txt.Text + ',' + TelNo_txt.Text + ',' + İadeTarihi_Date.Value + ',' + ISBN_txt.Text);
                    sw.Close();
                    List.Items.Clear();
                    güncelle();
                    System.TimeSpan a = İadeTarihi_Date.Value - DateTime.Now;
                    int Ücret = Int32.Parse(GünlükÜcret_txt.Text) * (a.Days + 1);
                    MessageBox.Show("Kayıt eklendi, ücret miktarı =" + Ücret);
                    StreamReader sr1 = new StreamReader("C:\\ahsenkazanc.txt");
                    string satır = sr1.ReadLine();
                    string[] dizi = satır.Split(',');
                    int temp = Int32.Parse(dizi[0]);
                    int temp2 = Int32.Parse(dizi[1]);
                    sr1.Close();
                    StreamWriter sw1 = new StreamWriter("C:\\ahsenkazanc.txt");
                    int adet = temp + 1;
                    int yeniücret = temp2 + Ücret;
                    sw1.WriteLine(adet + "," + yeniücret);
                    sw1.Close();
                    KayıtSayısı();
                    stoksil(KitapAdi_txt.Text, ISBN_txt.Text);

                    FileStream fs2 = new FileStream("C:\\ahsenlog.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    StreamWriter sw2 = new StreamWriter(fs2);
                    sw2.WriteLine(KitapAdi_txt.Text + ',' + KişiAdı_txt.Text + ',' + TelNo_txt.Text + ',' + İadeTarihi_Date.Value + ',' + ISBN_txt.Text);
                    sw2.Close();

                }
                else
                {
                    MessageBox.Show("Stokta Kitap Mevcut Değil");
                }
            }
        }
        public void stoksil(string kitapadi_txt, string ISBN_TXT)
        {
            bool bulundu = false;
            StreamWriter sw2 = new StreamWriter("C:\\temp.txt");
            StreamReader sr3 = new StreamReader("C:\\ahsenstok.txt");
            while (true)
            {
                string satır = sr3.ReadLine();
                if (satır != null)
                {
                    string[] dizi = satır.Split(',');
                    if (bulundu == false && dizi[1] == kitapadi_txt && dizi[7] == ISBN_TXT)
                    {
                        int yeniadet = Int32.Parse(dizi[2]);
                        yeniadet -= 1;
                        bulundu = true;
                        if (yeniadet > -1)
                            sw2.WriteLine(dizi[0] + "," + dizi[1] + "," + yeniadet + "," + dizi[3] + "," + dizi[4] + "," + dizi[5] + "," + dizi[6] + "," + dizi[7]);
                    }
                    else
                    {
                        sw2.WriteLine(satır);
                    }
                }
                else
                {
                    sw2.Close();
                    sr3.Close();
                    File.Delete("C:\\ahsenstok.txt");
                    File.Move("C:\\temp.txt", "C:\\ahsenstok.txt");
                    break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("İade işlemi yapmak istiyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                int GecikmeÜcret = 0;
                bool KitapVarmıKontrol = false;
                bool KitapAdKontrol = false;
                bool KişiAdKontrol = false;
                if (KitapAdİade_txt.Text == "" || KişiAdİade_txt.Text == "" || GecikmeÜcreti_txt.Text == "")
                {
                    MessageBox.Show("Kitap adı Kişi adı ve Gecikme Ücreti boş geçilemez");
                    return;
                }
                bool GecikmeÜcSayısalmı = false;
                GecikmeÜcSayısalmı = Int32.TryParse(GecikmeÜcreti_txt.Text, out int dönüş2);
                if (!GecikmeÜcSayısalmı)
                {
                    MessageBox.Show("Gecikme Ücreti sayısal olmalı");
                    return;
                }
                StreamWriter sw2 = new StreamWriter("C:\\temp.txt");
                StreamReader sr = new StreamReader("C:\\ahsen.txt");
                bool durma = false;
                while (true)
                {
                    string satır = sr.ReadLine();
                    if (satır != null)
                    {
                        string[] dizi = satır.Split(',');
                        if (dizi[0] == KitapAdİade_txt.Text)
                        {
                            KitapAdKontrol = true;
                        }
                        if (dizi[1] == KişiAdİade_txt.Text)
                        {
                            KişiAdKontrol = true;
                        }
                        if (KitapAdKontrol && KişiAdKontrol &&durma==false)
                        {
                            System.TimeSpan GünFarkı = DateTime.Now - DateTime.Parse(dizi[3]);
                            GecikmeÜcret = Int32.Parse(GecikmeÜcreti_txt.Text) * GünFarkı.Days;
                            KitapVarmıKontrol = true;
                            KişiAdKontrol = false;
                            KitapAdKontrol = false;
                            durma = true;
                            StreamReader sr4 = new StreamReader("C:\\ahsenstok.txt");
                            StreamWriter sw4 = new StreamWriter("C:\\temp2.txt");
                            while (true)
                            {
                                string satır3 = sr4.ReadLine();
                                if(satır3!=null)
                                {
                                    string[] dizi3 = satır3.Split(',');
                                    if (dizi3[1] == KitapAdİade_txt.Text)
                                    {
                                        int yeniadet2 = Int32.Parse(dizi3[2]);
                                        yeniadet2 += 1;
                                        sw4.WriteLine(dizi3[0] + "," + dizi3[1] + "," + yeniadet2 + "," + dizi3[3] + "," + dizi3[4] + "," + dizi3[5] + "," + dizi3[6] + "," + dizi3[7]);
                                    }
                                    else
                                    {
                                        sw4.WriteLine(satır3);
                                    }
                                }
                                else
                                {
                                    break;
                                }

                            }
                            sw4.Close();
                            sr4.Close();
                            File.Delete("C:\\ahsenstok.txt");
                            File.Move("C:\\temp2.txt", "C:\\ahsenstok.txt");

                        }
                        else
                        {
                            sw2.WriteLine(satır);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                sw2.Close();
                sr.Close();
                if (KitapVarmıKontrol)
                {
                    MessageBox.Show("Geçikme Ücreti" + GecikmeÜcret);
                    KitapVarmıKontrol = false;
                }
                else
                {
                    MessageBox.Show("Kayıtta böyle bir kitap yok");
                }
                KayıtSayısı();
                File.Delete("C:\\ahsen.txt");
                File.Move("C:\\temp.txt", "C:\\ahsen.txt");
                List.Items.Clear();
                güncelle();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void Güncelle_btn_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Tarihte güncelleme yapmak istiyor musunuz?=", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                int UzatmaÜcret = 0;
                bool KitapVarmıKontrol = false;
                bool KitapAdKontrol = false;
                bool KişiAdKontrol = false;
                if (KitapAdGüncelleme_txt.Text == "" || KişiAdGüncelleme_txt.Text == "" || UzatmaÜcret_txt.Text == "")
                {
                    MessageBox.Show("Kitap adı Kişi adı ve günlük ücret boş geçilemez");
                    return;
                }
                {
                    StreamWriter sw2 = new StreamWriter("C:\\temp.txt");
                    StreamReader sr = new StreamReader("C:\\ahsen.txt");
                    while (true)
                    {
                        string satır = sr.ReadLine();
                        if (satır != null)
                        {
                            string[] dizi = satır.Split(',');
                            if (dizi[0] == KitapAdGüncelleme_txt.Text)
                            {
                                KitapAdKontrol = true;
                                if (dizi[1] == KişiAdGüncelleme_txt.Text)
                                {
                                    KişiAdKontrol = true;
                                    if (KitapAdKontrol && KişiAdKontrol)
                                    {
                                        string EskiTarih = dizi[3];
                                        System.TimeSpan GünFarkı = UzatmaTarih_Date.Value - DateTime.Parse(EskiTarih);
                                        UzatmaÜcret = Int32.Parse(UzatmaÜcret_txt.Text) * GünFarkı.Days;
                                        KitapVarmıKontrol = true;
                                        sw2.WriteLine(dizi[0] + ',' + dizi[1] + ',' + dizi[2] + ',' + UzatmaTarih_Date.Value + ',' + dizi[4]);
                                        KişiAdKontrol = false;
                                        KitapAdKontrol = false;
                                    }
                                }
                            }
                            else
                            {
                                sw2.WriteLine(dizi[0] + ',' + dizi[1] + ',' + dizi[2] + ',' + dizi[3] + ',' + dizi[4]);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    sw2.Close();
                    sr.Close();
                    File.Delete("C:\\ahsen.txt");
                    File.Move("C:\\temp.txt", "C:\\ahsen.txt");
                    List.Items.Clear();
                    güncelle();
                    if (KitapVarmıKontrol)
                    {
                        MessageBox.Show("Tarih Uzatıldı Ek ücret: " + UzatmaÜcret);
                    }
                    else
                    {
                        MessageBox.Show("Kayıtta böyle bir kitap yok");
                    }
                }
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\ahsen.txt"))
            {
                FileStream fs = new FileStream("C:\\ahsen.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Close();
            }
            if (!File.Exists("C:\\ahsenkazanc.txt"))
            {
                FileStream fs = new FileStream("C:\\ahsenkazanc.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("0" + ',' + "0");
                sw.Close();
            }
            List.Columns.Add("Kitap Adı:", 150);
            List.Columns.Add("Kişi Adı:", 130);
            List.Columns.Add("Tel No:", 130);
            List.Columns.Add("İade Tarihi:", 125);
            List.Columns.Add("ISBN Numarası", 125);
            SorguList.Columns.Add("Kitap Adı:", 150);
            SorguList.Columns.Add("Kişi Adı:", 120);
            SorguList.Columns.Add("Tel No:", 150);
            SorguList.Columns.Add("İade Tarihi:", 125);
            SorguList.Columns.Add("ISBN Numarası", 125);
            güncelle();

        }
        private void güncelle()
        {
            StreamReader sr = new StreamReader("C:\\ahsen.txt");
            while (true)
            {
                string[] bilgiler = new string[5];
                string satır = sr.ReadLine();
                if (satır != null)
                {
                    string[] dizi = satır.Split(',');
                    bilgiler[0] = dizi[0];
                    bilgiler[1] = dizi[1];
                    bilgiler[2] = dizi[2];
                    DateTime temptarih = DateTime.Parse(dizi[3]);
                    bilgiler[3] = temptarih.Day + "/" + temptarih.Month + "/" + temptarih.Year;
                    bilgiler[4] = dizi[4];
                    ListViewItem temp = new ListViewItem(bilgiler);
                    List.Items.Add(temp);
                }
                else
                    break;
            }
            sr.Close();
            KayıtSayısı();
        }
        private void KayıtSayısı()
        {
            int KayıtSayı = List.Items.Count;
            KayıtSayısı_Label.Text = Convert.ToString(KayıtSayı);
        }
        private void KayıtSayısıSorgu()
        {
            int KayıtSayıS = SorguList.Items.Count;
            SorguSayısı.Text = Convert.ToString(KayıtSayıS);


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GeriAnaEkranDön_btn_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void sorguBtn1_Click_1(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Sorgu yapmak istiyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                SorguList.Items.Clear();

                if (SorguBox1.SelectedItem == null)
                {
                    MessageBox.Show("Sorgu türü boş geçilemez", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SorguBox1.SelectedItem.ToString() == "Kitap Adı")
                {
                    StreamReader sr = new StreamReader("C:\\ahsen.txt");
                    while (true)
                    {
                        string satır = sr.ReadLine();
                        if (satır != null)
                        {
                            string[] dizi = satır.Split(',');
                            if (dizi[0] == SorguTxt.Text)
                            {
                                string[] bilgiler = new string[5];
                                bilgiler[0] = dizi[0];
                                bilgiler[1] = dizi[1];
                                bilgiler[2] = dizi[2];
                                bilgiler[3] = dizi[3];
                                bilgiler[4] = dizi[4];
                                ListViewItem temp = new ListViewItem(bilgiler);
                                SorguList.Items.Add(temp);
                            }
                        }
                        else
                            break;
                    }
                    sr.Close();
                }
                else if (SorguBox1.SelectedItem.ToString() == "Tel No")
                {
                    StreamReader sr = new StreamReader("C:\\ahsen.txt");
                    while (true)
                    {
                        string satır = sr.ReadLine();
                        if (satır != null)
                        {
                            string[] dizi = satır.Split(',');
                            if (dizi[2] == msksorgutel.Text)
                            {
                                string[] bilgiler = new string[5];
                                bilgiler[0] = dizi[0];
                                bilgiler[1] = dizi[1];
                                bilgiler[2] = dizi[2];
                                bilgiler[3] = dizi[3];
                                bilgiler[4] = dizi[4];
                                ListViewItem temp = new ListViewItem(bilgiler);
                                SorguList.Items.Add(temp);
                            }
                        }
                        else
                            break;
                    }
                    sr.Close();
                }
            }
            KayıtSayısıSorgu();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void SorguBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = SorguBox1.SelectedItem.ToString();
            if (sec == "Kitap Adı")
            {
                msksorgutel.Visible = false;
                SorguTxt.Visible = true;
            }
            if (sec == "Tel No")
            {
                msksorgutel.Visible = true;
                SorguTxt.Visible = false;
            }
        }
    }
}
