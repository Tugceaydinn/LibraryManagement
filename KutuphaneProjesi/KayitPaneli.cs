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
    public partial class KayitPaneli : Form
    {
        public KayitPaneli()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Cursor = Cursors.Hand;
        }

        private void KayitPaneli_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

            //İPTAL DURUMU BUTONU
            DialogResult res = new DialogResult();
            res= MessageBox.Show("Emin Misiniz?","Çıkış",MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Çıkış Yapılamadı.");
            }


        }

        //KAYIT OL BUTONU 
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (tc_txtbox.Text == "" || adsoyad_txtbox.Text == "" || email_txtbox.Text == "" || sifre_txtbox.Text == "" ||
                tc_txtbox.Text == String.Empty|| adsoyad_txtbox.Text == String.Empty|| email_txtbox.Text == String.Empty || sifre_txtbox.Text == String.Empty)
            {

                tc_txtbox.BackColor = Color.LightSteelBlue;
                adsoyad_txtbox.BackColor = Color.LightSteelBlue;
                email_txtbox.BackColor = Color.LightSteelBlue;
                sifre_txtbox.BackColor = Color.LightSteelBlue;
                MessageBox.Show("Renkli Alanları Boş Bırakmayınız", "Boş Alan Hatası");
            }
            else {
                DialogResult kayitRes = new DialogResult();
                kayitRes = MessageBox.Show("Kaydınız Başarıyla Gerçekleşti.","OK",MessageBoxButtons.OK);
                if(kayitRes == DialogResult.OK)
                {
                    Close();
                } 
            }
            
        }
    }
}
