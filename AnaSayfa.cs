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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;  
        }

        private void fakulte_Click(object sender, EventArgs e)
        {
            FakulteEkle fakulteEkle = new FakulteEkle();

            fakulteEkle.Show();
        }

        private void bolum_Click(object sender, EventArgs e)
        {
            BolumEkle bolumEkle = new BolumEkle();

            bolumEkle.Show();
        }

        private void ogrenci_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();

            ogrenciEkle.Show();
        }

        private void ogrenci_sorgula_Click(object sender, EventArgs e)
        {
            OgrenciSorgula ogrenciSorgula = new OgrenciSorgula();

            ogrenciSorgula.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
