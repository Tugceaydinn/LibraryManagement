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
    public partial class YeniMesaj : Form
    {
        public YeniMesaj()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Cursor = Cursors.Hand;
        }

        private void YeniMesaj_Load(object sender, EventArgs e)
        {

        }

        private void mesajGonder_btn_Click(object sender, EventArgs e)
        {
            if (alici_txtbox.Text == "" || alici_txtbox.Text == String.Empty)
            {

                alici_txtbox.BackColor = Color.LightSteelBlue;
                MessageBox.Show("Alici Alanını Doldurun", "Boş Alan Hatası");
            }
            else
            {
                DialogResult mesajGonderRes = new DialogResult();
                mesajGonderRes = MessageBox.Show("Mesajınız Başarıyla Gönderildi.", "OK", MessageBoxButtons.OK);
                if (mesajGonderRes == DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
}
