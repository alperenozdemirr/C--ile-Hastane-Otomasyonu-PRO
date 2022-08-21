using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        HastaKayit hastaKayit = new HastaKayit();
        Personel personel = new Personel();
        Sira sira = new Sira();
        YöneticiGiris yonetici = new YöneticiGiris();
        Analiz analiz = new Analiz();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butonHasta_Click(object sender, EventArgs e)
        {
            hastaKayit.ShowDialog();
        }

        private void butonPersonel_Click(object sender, EventArgs e)
        {
            personel.ShowDialog();
        }

        private void butonSira_Click(object sender, EventArgs e)
        {
            sira.ShowDialog();
        }

        private void butonAdmin_Click(object sender, EventArgs e)
        {
            yonetici.ShowDialog();
        }

        private void Analiz_Click(object sender, EventArgs e)
        {
            analiz.ShowDialog();
        }
    }
}
