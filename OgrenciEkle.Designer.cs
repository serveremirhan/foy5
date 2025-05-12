namespace foy5
{
    partial class OgrenciEkle
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
            this.ogrenci_ekle_button = new System.Windows.Forms.Button();
            this.ogrenci_ad = new System.Windows.Forms.TextBox();
            this.ogrenci_soyad = new System.Windows.Forms.TextBox();
            this.ogrenci_ad_label = new System.Windows.Forms.Label();
            this.ogrenci_soyad_label = new System.Windows.Forms.Label();
            this.ogrenci_bolum_label = new System.Windows.Forms.Label();
            this.OgrenciBolumcomboBox = new System.Windows.Forms.ComboBox();
            this.OgrenciSilbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogrenci_ekle_button
            // 
            this.ogrenci_ekle_button.Location = new System.Drawing.Point(168, 266);
            this.ogrenci_ekle_button.Name = "ogrenci_ekle_button";
            this.ogrenci_ekle_button.Size = new System.Drawing.Size(75, 23);
            this.ogrenci_ekle_button.TabIndex = 0;
            this.ogrenci_ekle_button.Text = "Ekle";
            this.ogrenci_ekle_button.UseVisualStyleBackColor = true;
            this.ogrenci_ekle_button.Click += new System.EventHandler(this.ogrenci_ekle_button_Click);
            // 
            // ogrenci_ad
            // 
            this.ogrenci_ad.Location = new System.Drawing.Point(88, 201);
            this.ogrenci_ad.Name = "ogrenci_ad";
            this.ogrenci_ad.Size = new System.Drawing.Size(155, 20);
            this.ogrenci_ad.TabIndex = 1;
            this.ogrenci_ad.TextChanged += new System.EventHandler(this.ogrenci_ad_TextChanged);
            // 
            // ogrenci_soyad
            // 
            this.ogrenci_soyad.Location = new System.Drawing.Point(88, 240);
            this.ogrenci_soyad.Name = "ogrenci_soyad";
            this.ogrenci_soyad.Size = new System.Drawing.Size(155, 20);
            this.ogrenci_soyad.TabIndex = 2;
            this.ogrenci_soyad.TextChanged += new System.EventHandler(this.ogrenci_soyad_TextChanged);
            // 
            // ogrenci_ad_label
            // 
            this.ogrenci_ad_label.AutoSize = true;
            this.ogrenci_ad_label.Location = new System.Drawing.Point(85, 185);
            this.ogrenci_ad_label.Name = "ogrenci_ad_label";
            this.ogrenci_ad_label.Size = new System.Drawing.Size(25, 13);
            this.ogrenci_ad_label.TabIndex = 4;
            this.ogrenci_ad_label.Text = "İsim";
            // 
            // ogrenci_soyad_label
            // 
            this.ogrenci_soyad_label.AutoSize = true;
            this.ogrenci_soyad_label.Location = new System.Drawing.Point(85, 224);
            this.ogrenci_soyad_label.Name = "ogrenci_soyad_label";
            this.ogrenci_soyad_label.Size = new System.Drawing.Size(42, 13);
            this.ogrenci_soyad_label.TabIndex = 5;
            this.ogrenci_soyad_label.Text = "Soyisim";
            // 
            // ogrenci_bolum_label
            // 
            this.ogrenci_bolum_label.AutoSize = true;
            this.ogrenci_bolum_label.Location = new System.Drawing.Point(85, 145);
            this.ogrenci_bolum_label.Name = "ogrenci_bolum_label";
            this.ogrenci_bolum_label.Size = new System.Drawing.Size(36, 13);
            this.ogrenci_bolum_label.TabIndex = 6;
            this.ogrenci_bolum_label.Text = "Bölüm";
            // 
            // OgrenciBolumcomboBox
            // 
            this.OgrenciBolumcomboBox.FormattingEnabled = true;
            this.OgrenciBolumcomboBox.Location = new System.Drawing.Point(88, 162);
            this.OgrenciBolumcomboBox.Name = "OgrenciBolumcomboBox";
            this.OgrenciBolumcomboBox.Size = new System.Drawing.Size(155, 21);
            this.OgrenciBolumcomboBox.TabIndex = 7;
            this.OgrenciBolumcomboBox.SelectedIndexChanged += new System.EventHandler(this.OgrenciBolumcomboBox_SelectedIndexChanged);
            // 
            // OgrenciSilbutton
            // 
            this.OgrenciSilbutton.Location = new System.Drawing.Point(88, 266);
            this.OgrenciSilbutton.Name = "OgrenciSilbutton";
            this.OgrenciSilbutton.Size = new System.Drawing.Size(75, 23);
            this.OgrenciSilbutton.TabIndex = 8;
            this.OgrenciSilbutton.Text = "Sil";
            this.OgrenciSilbutton.UseVisualStyleBackColor = true;
            this.OgrenciSilbutton.Click += new System.EventHandler(this.OgrenciSilbutton_Click);
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.OgrenciSilbutton);
            this.Controls.Add(this.OgrenciBolumcomboBox);
            this.Controls.Add(this.ogrenci_bolum_label);
            this.Controls.Add(this.ogrenci_soyad_label);
            this.Controls.Add(this.ogrenci_ad_label);
            this.Controls.Add(this.ogrenci_soyad);
            this.Controls.Add(this.ogrenci_ad);
            this.Controls.Add(this.ogrenci_ekle_button);
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogrenci_ekle_button;
        private System.Windows.Forms.TextBox ogrenci_ad;
        private System.Windows.Forms.TextBox ogrenci_soyad;
        private System.Windows.Forms.Label ogrenci_ad_label;
        private System.Windows.Forms.Label ogrenci_soyad_label;
        private System.Windows.Forms.Label ogrenci_bolum_label;
        private System.Windows.Forms.ComboBox OgrenciBolumcomboBox;
        private System.Windows.Forms.Button OgrenciSilbutton;
    }
}