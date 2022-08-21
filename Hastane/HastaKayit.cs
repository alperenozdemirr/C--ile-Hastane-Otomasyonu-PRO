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
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        
        private void HastaKayit_Load(object sender, EventArgs e)
        {

        }
        void Add(PatientSignup patientSignup)
        {
            using (HastaneContext context = new HastaneContext())
            {
                context.PatientSignups.Add(patientSignup);
                context.SaveChanges();
            }
        }
        private void butonKaydet_Click(object sender, EventArgs e)
        {
            Add(new PatientSignup
            {
                AdSoyad = textAd.Text,
                Kimlik = textKimlik.Text,
                AnneAdi = textAnneAdi.Text,
                BabaAdi = textBabaAdi.Text,
                KanGrubu = textKan.Text
            });
            MessageBox.Show("Kayıt Başarılı");
        }
    }
}
