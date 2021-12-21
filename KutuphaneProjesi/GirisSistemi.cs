using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class GirisSistemi : Form
    {
        public GirisSistemi()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Cursor = Cursors.Hand;

            saat.Interval = 100;
            saat.Enabled  = true;
        }

        //KULLANICI PANELİ 
        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            if (email_txtbox.Text == "" || sifre_txtbox.Text == "" || email_txtbox.Text == String.Empty || sifre_txtbox.Text == String.Empty)
            {
                email_txtbox.BackColor = Color.Pink;
                sifre_txtbox.BackColor = Color.Pink;
                MessageBox.Show("Renkli Alanları Boş Bırakmayınız", "Boş Alan Hatası");
            }
            else { 
            KullaniciPaneli kullaniciPanel = new KullaniciPaneli();
            this.Hide();
            kullaniciPanel.ShowDialog();
            this.Show();
            }
        }

        //YONETİCİ PANELİ
        private void btnYoneticiPaneli_Click(object sender, EventArgs e)
        {

            if (email_txtbox.Text == "" || sifre_txtbox.Text == "" || email_txtbox.Text == String.Empty || sifre_txtbox.Text == String.Empty)
            {
                email_txtbox.BackColor = Color.Orchid;
                sifre_txtbox.BackColor = Color.Orchid;
                MessageBox.Show("Renkli Alanları Boş Bırakmayınız", "Boş Alan Hatası");
            }
            else
            {

                YoneticiPaneli yoneticiPanel = new YoneticiPaneli();
                this.Hide();
                yoneticiPanel.ShowDialog();
                this.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GirisSistemi_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat4.Text = DateTime.Now.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
