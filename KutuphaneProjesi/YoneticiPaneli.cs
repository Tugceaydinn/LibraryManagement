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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Cursor = Cursors.Hand;
        }

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            //KAYIT PANELİ
                KayitPaneli kayitPanel = new KayitPaneli();
                this.Hide();
                kayitPanel.ShowDialog();
                this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
