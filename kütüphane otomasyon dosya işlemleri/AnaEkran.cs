using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_otomasyon_dosya_işlemleri
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void KitapTakipGiriş_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void AnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stok stok = new stok();
            stok.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kazanc kazanc = new Kazanc();
            kazanc.Show();
            this.Hide();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
