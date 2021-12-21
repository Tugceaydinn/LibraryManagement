
namespace KutuphaneProjesi
{
    partial class KullaniciPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciPaneli));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_mesajlar = new System.Windows.Forms.Button();
            this.btn_okunan = new System.Windows.Forms.Button();
            this.btnRenk2 = new System.Windows.Forms.Button();
            this.btnRenk1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KutuphaneProjesi.Properties.Resources.kullaniciAdi;
            this.pictureBox1.Location = new System.Drawing.Point(324, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_mesajlar
            // 
            this.btn_mesajlar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_mesajlar.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mesajlar.Location = new System.Drawing.Point(83, 210);
            this.btn_mesajlar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_mesajlar.Name = "btn_mesajlar";
            this.btn_mesajlar.Size = new System.Drawing.Size(95, 118);
            this.btn_mesajlar.TabIndex = 1;
            this.btn_mesajlar.Text = "Mesajlar";
            this.btn_mesajlar.UseVisualStyleBackColor = false;
            this.btn_mesajlar.Click += new System.EventHandler(this.btn_mesajlar_Click);
            // 
            // btn_okunan
            // 
            this.btn_okunan.BackColor = System.Drawing.Color.MistyRose;
            this.btn_okunan.Location = new System.Drawing.Point(648, 210);
            this.btn_okunan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_okunan.Name = "btn_okunan";
            this.btn_okunan.Size = new System.Drawing.Size(97, 116);
            this.btn_okunan.TabIndex = 2;
            this.btn_okunan.Text = "Okunanlar";
            this.btn_okunan.UseVisualStyleBackColor = false;
            this.btn_okunan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRenk2
            // 
            this.btnRenk2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRenk2.Location = new System.Drawing.Point(470, 381);
            this.btnRenk2.Name = "btnRenk2";
            this.btnRenk2.Size = new System.Drawing.Size(84, 41);
            this.btnRenk2.TabIndex = 3;
            this.btnRenk2.Text = "Tema 2";
            this.btnRenk2.UseVisualStyleBackColor = false;
            this.btnRenk2.Click += new System.EventHandler(this.btnRenk2_Click);
            // 
            // btnRenk1
            // 
            this.btnRenk1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnRenk1.Location = new System.Drawing.Point(271, 381);
            this.btnRenk1.Name = "btnRenk1";
            this.btnRenk1.Size = new System.Drawing.Size(87, 41);
            this.btnRenk1.TabIndex = 4;
            this.btnRenk1.Text = "Tema 1";
            this.btnRenk1.UseVisualStyleBackColor = false;
            this.btnRenk1.Click += new System.EventHandler(this.btnRenk1_Click);
            // 
            // KullaniciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.btnRenk1);
            this.Controls.Add(this.btnRenk2);
            this.Controls.Add(this.btn_okunan);
            this.Controls.Add(this.btn_mesajlar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KullaniciPaneli";
            this.Text = "KullaniciPaneli";
            this.Load += new System.EventHandler(this.KullaniciPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_mesajlar;
        private System.Windows.Forms.Button btn_okunan;
        private System.Windows.Forms.Button btnRenk2;
        private System.Windows.Forms.Button btnRenk1;
    }
}