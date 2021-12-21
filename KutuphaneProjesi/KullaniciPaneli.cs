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
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Cursor = Cursors.Hand;
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_mesajlar_Click(object sender, EventArgs e)
        {
            Mesajlar mesaj = new Mesajlar();
            this.Hide();
            mesaj.ShowDialog();
            this.Show();

        }

        private void btnRenk1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleVioletRed;
        }

        private void btnRenk2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSteelBlue;
        }
    }
}
