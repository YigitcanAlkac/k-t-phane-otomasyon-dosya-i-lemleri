using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kütüphane_otomasyon_dosya_işlemleri
{
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }

        private void stok_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GeriAnaEkranDön_btn_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void stok_Load(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\ahsenstok.txt"))
            {
                FileStream fs = new FileStream("C:\\ahsenstok.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Close();
            }
            ListStok.Columns.Add("Yazar Adı:", 150);
            ListStok.Columns.Add("Kitap Adı:", 150);
            ListStok.Columns.Add("Adedi:", 150);
            ListStok.Columns.Add("Kitap Türü:", 150);
            ListStok.Columns.Add("Yayınevi:", 125);
            ListStok.Columns.Add("Yayın Yılı:", 150);
            ListStok.Columns.Add("Raf Bilgisi:", 125);
            ListStok.Columns.Add("ISBN Numarası:", 135);
            StreamReader sr = new StreamReader("C:\\ahsenstok.txt");
            while (true)
            {
                string[] bilgiler = new string[8];
                string satır = sr.ReadLine();
                if (satır != null)
                {
                    string[] dizi = satır.Split(',');
                    bilgiler[0] = dizi[0];
                    bilgiler[1] = dizi[1];
                    bilgiler[2] = dizi[2];
                    bilgiler[3] = dizi[3];
                    bilgiler[4] = dizi[4];
                    bilgiler[5] = dizi[5];
                    bilgiler[6] = dizi[6];
                    bilgiler[7] = dizi[7];
                    ListViewItem temp = new ListViewItem(bilgiler);
                    ListStok.Items.Add(temp);
                }
                else
                    break;
            }
            sr.Close();
            KayıtSayısıStok();
        }
        private void KayıtSayısıStok()
        {
            int KayıtSayı = ListStok.Items.Count;
            StokSayısı_Label.Text = Convert.ToString(KayıtSayı);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ekle_btn_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kayıt oluşturmak istiyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (YazarAdi_txt.Text == "" || KitapAdı_txt.Text == "" || KitapTürü_txt.Text == "" || Adet_txt.Text=="" || Yayınevi_txt.Text == "" || YayınYılı__txt.Text == "" || Raf_txt.Text == "" || ISBN_txt.Text == "")
                {
                    MessageBox.Show("Eksik Bilgi Girdiniz!");
                    return;
                }
                else
                {
                    FileStream fs = new FileStream("C:\\ahsenstok.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(YazarAdi_txt.Text + ',' + KitapAdı_txt.Text + ',' + Adet_txt.Text + ','+ KitapTürü_txt.Text + ',' + Yayınevi_txt.Text + ',' + YayınYılı__txt.Text + ',' + Raf_txt.Text + ',' + ISBN_txt.Text);
                    sw.Close();
                    ListStok.Clear();
                    stok_Load(sender, new EventArgs());
                }
            }
        }

        private void ListStok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
