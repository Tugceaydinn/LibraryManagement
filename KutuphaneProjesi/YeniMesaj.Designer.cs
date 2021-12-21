
namespace KutuphaneProjesi
{
    partial class YeniMesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniMesaj));
            this.gonderici_label = new System.Windows.Forms.Label();
            this.alici_label = new System.Windows.Forms.Label();
            this.gonderici_txtbox = new System.Windows.Forms.TextBox();
            this.alici_txtbox = new System.Windows.Forms.TextBox();
            this.mesajIcerik_txt = new System.Windows.Forms.RichTextBox();
            this.mesajGonder_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gonderici_label
            // 
            this.gonderici_label.AutoSize = true;
            this.gonderici_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gonderici_label.Location = new System.Drawing.Point(202, 37);
            this.gonderici_label.Name = "gonderici_label";
            this.gonderici_label.Size = new System.Drawing.Size(73, 17);
            this.gonderici_label.TabIndex = 0;
            this.gonderici_label.Text = "Gönderici:";
            // 
            // alici_label
            // 
            this.alici_label.AutoSize = true;
            this.alici_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alici_label.ForeColor = System.Drawing.Color.Black;
            this.alici_label.Location = new System.Drawing.Point(219, 90);
            this.alici_label.Name = "alici_label";
            this.alici_label.Size = new System.Drawing.Size(37, 17);
            this.alici_label.TabIndex = 1;
            this.alici_label.Text = "Alıcı:";
            // 
            // gonderici_txtbox
            // 
            this.gonderici_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gonderici_txtbox.Location = new System.Drawing.Point(373, 37);
            this.gonderici_txtbox.Name = "gonderici_txtbox";
            this.gonderici_txtbox.Size = new System.Drawing.Size(195, 22);
            this.gonderici_txtbox.TabIndex = 2;
            // 
            // alici_txtbox
            // 
            this.alici_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.alici_txtbox.ForeColor = System.Drawing.Color.Black;
            this.alici_txtbox.Location = new System.Drawing.Point(373, 85);
            this.alici_txtbox.Name = "alici_txtbox";
            this.alici_txtbox.Size = new System.Drawing.Size(195, 22);
            this.alici_txtbox.TabIndex = 3;
            // 
            // mesajIcerik_txt
            // 
            this.mesajIcerik_txt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mesajIcerik_txt.Location = new System.Drawing.Point(139, 140);
            this.mesajIcerik_txt.Name = "mesajIcerik_txt";
            this.mesajIcerik_txt.Size = new System.Drawing.Size(578, 248);
            this.mesajIcerik_txt.TabIndex = 4;
            this.mesajIcerik_txt.Text = "";
            // 
            // mesajGonder_btn
            // 
            this.mesajGonder_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesajGonder_btn.BackgroundImage = global::KutuphaneProjesi.Properties.Resources.send;
            this.mesajGonder_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mesajGonder_btn.Location = new System.Drawing.Point(642, 394);
            this.mesajGonder_btn.Name = "mesajGonder_btn";
            this.mesajGonder_btn.Size = new System.Drawing.Size(75, 54);
            this.mesajGonder_btn.TabIndex = 5;
            this.mesajGonder_btn.UseVisualStyleBackColor = false;
            this.mesajGonder_btn.Click += new System.EventHandler(this.mesajGonder_btn_Click);
            // 
            // YeniMesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneProjesi.Properties.Resources.message;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mesajGonder_btn);
            this.Controls.Add(this.mesajIcerik_txt);
            this.Controls.Add(this.alici_txtbox);
            this.Controls.Add(this.gonderici_txtbox);
            this.Controls.Add(this.alici_label);
            this.Controls.Add(this.gonderici_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YeniMesaj";
            this.Text = "YeniMesaj";
            this.Load += new System.EventHandler(this.YeniMesaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gonderici_label;
        private System.Windows.Forms.Label alici_label;
        private System.Windows.Forms.TextBox gonderici_txtbox;
        private System.Windows.Forms.TextBox alici_txtbox;
        private System.Windows.Forms.RichTextBox mesajIcerik_txt;
        private System.Windows.Forms.Button mesajGonder_btn;
    }
}