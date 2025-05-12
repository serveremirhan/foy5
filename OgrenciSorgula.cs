using foy5.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foy5
{
    public partial class OgrenciSorgula : Form
    {
        public OgrenciSorgula()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;  
        }

        private void OgrenciSorgula_Load(object sender, EventArgs e)
        {
            FakulteSorgulatextBox.Visible = false;
            BolumSorgulatextBox.Visible = false;
            FakulteSorgulalabel.Visible = false;
            BolumSorgulalabel.Visible = false;

            using (var context = new OgrenciContext())
            {
                var ogrenciler = context.Ogrenciler
                                         .Select(o => new
                                         {
                                             o.OgrenciID,
                                             AdSoyad = o.Ad + " " + o.Soyad // İsim ve Soyadı birleştir
                                         })
                                         .ToList();

                comboBox1.DataSource = ogrenciler;
                comboBox1.DisplayMember = "AdSoyad"; // ComboBox'ta ad ve soyadı göster
                comboBox1.ValueMember = "OgrenciID"; // Seçilen öğrencinin ID'sini al
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FakulteSorgulatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BolumSorgulatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sorgulabutton_Click(object sender, EventArgs e)
        {
            int selectedOgrenciId = (int)comboBox1.SelectedValue; // Seçilen öğrencinin ID'si

 // Sorgu ile öğrenci ve ilişkili bölüm-fakülte bilgilerini getirme
using (var context = new OgrenciContext())
{
        var ogrenci = context.Ogrenciler
               .Where(o => o.OgrenciID == selectedOgrenciId)
               .Include(o => o.Bolum) 
               .Include(o => o.Bolum.Fakulte) 
               .FirstOrDefault();


                if (ogrenci != null && ogrenci.Bolum != null)
    {
        BolumSorgulatextBox.Text = ogrenci.Bolum.BolumAd;
        FakulteSorgulatextBox.Text = ogrenci.Bolum.Fakulte.FakulteAd;

                    FakulteSorgulatextBox.Visible = true;
                    BolumSorgulatextBox.Visible = true;
                    FakulteSorgulalabel.Visible = true;
                    BolumSorgulalabel.Visible = true;
                }
    else
    {
        MessageBox.Show("Öğrenci, bölüm veya fakülte bilgisi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
        }

        private void FakulteSorgulalabel_Click(object sender, EventArgs e)
        {

        }

        private void BolumSorgulalabel_Click(object sender, EventArgs e)
        {

        }
    }
}
