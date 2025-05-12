namespace foy5
{
    partial class AnaSayfa
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
            this.fakulte = new System.Windows.Forms.Button();
            this.bolum = new System.Windows.Forms.Button();
            this.ogrenci = new System.Windows.Forms.Button();
            this.ogrenci_sorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fakulte
            // 
            this.fakulte.Location = new System.Drawing.Point(87, 109);
            this.fakulte.Name = "fakulte";
            this.fakulte.Size = new System.Drawing.Size(151, 46);
            this.fakulte.TabIndex = 0;
            this.fakulte.Text = "Fakülte Ekle";
            this.fakulte.UseVisualStyleBackColor = true;
            this.fakulte.Click += new System.EventHandler(this.fakulte_Click);
            // 
            // bolum
            // 
            this.bolum.Location = new System.Drawing.Point(87, 161);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(151, 46);
            this.bolum.TabIndex = 1;
            this.bolum.Text = "Bölüm Ekle";
            this.bolum.UseVisualStyleBackColor = true;
            this.bolum.Click += new System.EventHandler(this.bolum_Click);
            // 
            // ogrenci
            // 
            this.ogrenci.Location = new System.Drawing.Point(87, 213);
            this.ogrenci.Name = "ogrenci";
            this.ogrenci.Size = new System.Drawing.Size(151, 46);
            this.ogrenci.TabIndex = 2;
            this.ogrenci.Text = "Öğrenci Ekle";
            this.ogrenci.UseVisualStyleBackColor = true;
            this.ogrenci.Click += new System.EventHandler(this.ogrenci_Click);
            // 
            // ogrenci_sorgula
            // 
            this.ogrenci_sorgula.Location = new System.Drawing.Point(87, 265);
            this.ogrenci_sorgula.Name = "ogrenci_sorgula";
            this.ogrenci_sorgula.Size = new System.Drawing.Size(151, 46);
            this.ogrenci_sorgula.TabIndex = 3;
            this.ogrenci_sorgula.Text = "Öğrenci Sorgula";
            this.ogrenci_sorgula.UseVisualStyleBackColor = true;
            this.ogrenci_sorgula.Click += new System.EventHandler(this.ogrenci_sorgula_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.ogrenci_sorgula);
            this.Controls.Add(this.ogrenci);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.fakulte);
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fakulte;
        private System.Windows.Forms.Button bolum;
        private System.Windows.Forms.Button ogrenci;
        private System.Windows.Forms.Button ogrenci_sorgula;
    }
}

