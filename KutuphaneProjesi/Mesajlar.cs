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
    public partial class Mesajlar : Form
    {
        public Mesajlar()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Cursor = Cursors.Hand;

        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Control)
            {
                // perform copy
                e.Handled = true;
            }
        }

        private void Mesajlar_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnYeniMesaj_Click(object sender, EventArgs e)
        {
            YeniMesaj yenimesaj = new YeniMesaj();
            this.Hide();
            yenimesaj.ShowDialog();
            this.Show();
        }
    }
}
