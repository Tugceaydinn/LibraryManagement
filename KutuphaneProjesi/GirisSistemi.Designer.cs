
namespace KutuphaneProjesi
{
    partial class GirisSistemi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSistemi));
            this.label1 = new System.Windows.Forms.Label();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.sifre_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.kullaniciIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.saat4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // email_txtbox
            // 
            this.email_txtbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.email_txtbox, "email_txtbox");
            this.email_txtbox.Name = "email_txtbox";
            // 
            // sifre_txtbox
            // 
            this.sifre_txtbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.sifre_txtbox, "sifre_txtbox");
            this.sifre_txtbox.Name = "sifre_txtbox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKullaniciGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnKullaniciGiris, "btnKullaniciGiris");
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.UseVisualStyleBackColor = false;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // kullaniciIcon
            // 
            this.kullaniciIcon.BackColor = System.Drawing.Color.White;
            this.kullaniciIcon.BackgroundImage = global::KutuphaneProjesi.Properties.Resources.kullaniciAdi;
            resources.ApplyResources(this.kullaniciIcon, "kullaniciIcon");
            this.kullaniciIcon.Name = "kullaniciIcon";
            this.kullaniciIcon.TabStop = false;
            this.kullaniciIcon.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::KutuphaneProjesi.Properties.Resources.sifre;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYoneticiGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnYoneticiGiris, "btnYoneticiGiris");
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.UseVisualStyleBackColor = false;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiPaneli_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KutuphaneProjesi.Properties.Resources.sifre;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // saat
            // 
            this.saat.Enabled = true;
            this.saat.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saat4
            // 
            resources.ApplyResources(this.saat4, "saat4");
            this.saat4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saat4.Name = "saat4";
            this.saat4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GirisSistemi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::KutuphaneProjesi.Properties.Resources.libraryblack;
            this.CausesValidation = false;
            this.Controls.Add(this.saat4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYoneticiGiris);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kullaniciIcon);
            this.Controls.Add(this.btnKullaniciGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifre_txtbox);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisSistemi";
            this.Load += new System.EventHandler(this.GirisSistemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox sifre_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.PictureBox kullaniciIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnYoneticiGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer saat;
        private System.Windows.Forms.Label saat4;
    }
}

