using foy5.Data;
using foy5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foy5
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            using (var context = new OgrenciContext())
            {
                var bolumler = context.Bolumler.ToList();
                OgrenciBolumcomboBox.DataSource = bolumler;
                OgrenciBolumcomboBox.DisplayMember = "BolumAd";
                OgrenciBolumcomboBox.ValueMember = "BolumID";
            }
        }

        private void ogrenci_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogrenci_soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciBolumcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ogrenci_ekle_button_Click(object sender, EventArgs e)
        {
            string ogrenciAd = ogrenci_ad.Text;
            string ogrenciSoyad = ogrenci_soyad.Text;
            int bolumId = (int)OgrenciBolumcomboBox.SelectedValue;

            if (string.IsNullOrEmpty(ogrenciAd) || string.IsNullOrEmpty(ogrenciSoyad))
            {
                MessageBox.Show("Öğrenci adı ve soyadı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new OgrenciContext())
            {
                // Yeni öğrenci nesnesi oluştur
                var yeniOgrenci = new Ogrenci
                {
                    Ad = ogrenciAd,
                    Soyad = ogrenciSoyad,
                    BolumID = bolumId
                };

                // Öğrenciyi veritabanına ekle
                context.Ogrenciler.Add(yeniOgrenci);
                context.SaveChanges();

                // Başarı mesajı göster
                MessageBox.Show("Öğrenci başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                ogrenci_ad.Clear();
                ogrenci_soyad.Clear();
                OgrenciBolumcomboBox.SelectedIndex = -1;
            }
        }

        private void OgrenciSilbutton_Click(object sender, EventArgs e)
        {
            string ad = ogrenci_ad.Text.Trim();
            string soyad = ogrenci_soyad.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Lütfen silinecek öğrencinin adını ve soyadını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (OgrenciBolumcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir bölüm seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenBolumId = (int)OgrenciBolumcomboBox.SelectedValue;

            using (var context = new OgrenciContext())
            {
                // Ad ve soyadı eşleşen tüm öğrencileri getir
                var ogrenciListesi = context.Ogrenciler
                    .Where(o => o.Ad == ad && o.Soyad == soyad)
                    .ToList();

                if (ogrenciListesi.Count == 0)
                {
                    MessageBox.Show("Bu isim ve soyisimde bir öğrenci bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Seçilen bölümle eşleşen öğrenci var mı?
                var ogrenci = ogrenciListesi.FirstOrDefault(o => o.BolumID == secilenBolumId);

                if (ogrenci == null)
                {
                    MessageBox.Show("Bu isim ve soyisimde bir öğrenci var, ancak seçilen bölüm yanlış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Öğrenci bulundu ve bölüm doğruysa sil
                context.Ogrenciler.Remove(ogrenci);
                context.SaveChanges();

                MessageBox.Show("Öğrenci başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                ogrenci_ad.Clear();
                ogrenci_soyad.Clear();
                OgrenciBolumcomboBox.SelectedIndex = -1;
            }
        }
    }
}
