using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_otomasyon_dosya_işlemleri
{
    public partial class Kazanc : Form
    {
        public Kazanc()
        {
            InitializeComponent();
        }

        private void GeriAnaEkranDön_btn_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void Kazanc_Load(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\ahsenkazanc.txt"))
            {
                FileStream fs = new FileStream("C:\\ahsenkazanc.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("0" + ',' + "0");
                sw.Close();
            }
            else
            {
                StreamReader sr = new StreamReader("C:\\ahsenkazanc.txt");
                string[] dizi = sr.ReadLine().Split(',');
                Alım_lbl.Text = dizi[0];
                kazanc_lbl.Text = dizi[1];
                sr.Close();
            }
            if(!File.Exists("C:\\ahsenlog.txt"))
            {
                FileStream fs = new FileStream("C:\\ahsenlog.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Close();
            }
            List9.Columns.Add("Kitap Adı:", 150);
            List9.Columns.Add("Kişi Adı:", 130);
            List9.Columns.Add("Tel No:", 130);
            List9.Columns.Add("İade Tarihi:", 125);
            List9.Columns.Add("ISBN Numarası", 125);
            List9.Items.Clear();
            güncelle9();
        }
        private void güncelle9()
        {
            StreamReader sr = new StreamReader("C:\\ahsenlog.txt");
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
                    List9.Items.Add(temp);
                }
                else
                    break;
            }
            sr.Close();
            KayıtSayısı();
        }
        private void KayıtSayısı()
        {
            int KayıtSayı = List9.Items.Count;
            KayıtSayısı_Label9.Text = Convert.ToString(KayıtSayı);
        }
            private void KayıtSayısı_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Kazanc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
