using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using foy5.Data;
using foy5.Models;


namespace foy5

{
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BolumEkle_Load(object sender, EventArgs e)
        {
            // Fakülteleri veritabanından alıp ComboBox'a ekleyelim.
            using (var context = new OgrenciContext())
            {
                var fakulteler = context.Fakulteler.ToList();
                FakulteSeccomboBox.DataSource = fakulteler;
                FakulteSeccomboBox.DisplayMember = "FakulteAd"; // ComboBox'ta gösterilecek isim
                FakulteSeccomboBox.ValueMember = "FakulteID"; // Seçilen fakültenin ID'si
            }
        }


        private void FakulteSeccomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BolumEkletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BolumEklebutton_Click(object sender, EventArgs e)
        {
            // Bölüm eklemek için kullanıcının girdiği değerler alınacak
            string bolumAd = BolumEkletextBox.Text;
            int fakulteId = (int)FakulteSeccomboBox.SelectedValue;

            using (var context = new OgrenciContext())
            {
                // Yeni bir bölüm oluşturuluyor
                var yeniBolum = new Bolum
                {
                    BolumAd = bolumAd,
                    FakulteID = fakulteId
                };

                // Veritabanına ekleniyor
                context.Bolumler.Add(yeniBolum);
                context.SaveChanges();

                MessageBox.Show("Bölüm başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ComboBox'ı ve textBox'ı sıfırlıyoruz
                FakulteSeccomboBox.SelectedIndex = -1;
                BolumEkletextBox.Clear();
            }

        }


    }

}
