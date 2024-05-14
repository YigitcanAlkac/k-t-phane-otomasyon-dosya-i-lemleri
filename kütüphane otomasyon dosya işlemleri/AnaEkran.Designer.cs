namespace kütüphane_otomasyon_dosya_işlemleri
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.KitapTakipGiriş_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KitapTakipGiriş_btn
            // 
            this.KitapTakipGiriş_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.KitapTakipGiriş_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapTakipGiriş_btn.Location = new System.Drawing.Point(12, 12);
            this.KitapTakipGiriş_btn.Name = "KitapTakipGiriş_btn";
            this.KitapTakipGiriş_btn.Size = new System.Drawing.Size(362, 280);
            this.KitapTakipGiriş_btn.TabIndex = 0;
            this.KitapTakipGiriş_btn.Text = "KİTAP TAKİP SİSTEMİ";
            this.KitapTakipGiriş_btn.UseVisualStyleBackColor = false;
            this.KitapTakipGiriş_btn.Click += new System.EventHandler(this.KitapTakipGiriş_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(426, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 280);
            this.button1.TabIndex = 1;
            this.button1.Text = "STOK TAKİP SİSTEMİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(776, 104);
            this.button2.TabIndex = 2;
            this.button2.Text = "KAZANÇ TAKİP SİSTEMİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KitapTakipGiriş_btn);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaEkran_FormClosed);
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KitapTakipGiriş_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}