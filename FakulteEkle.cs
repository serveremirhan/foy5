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
    public partial class FakulteEkle : Form
    {
        public FakulteEkle()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FakulteEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FakultetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FakulteEklebutton_Click(object sender, EventArgs e)
        {
            string fakulteAdi = FakultetextBox1.Text.Trim();

            if (string.IsNullOrEmpty(fakulteAdi))
            {
                MessageBox.Show("Lütfen fakülte adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new OgrenciContext())
                {
                    var yeniFakulte = new Fakulte
                    {
                        FakulteAd = fakulteAdi
                    };

                    context.Fakulteler.Add(yeniFakulte);
                    context.SaveChanges();
                }

                MessageBox.Show("Fakülte başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FakultetextBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FakulteSilbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
