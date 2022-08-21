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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }
        void Add(Staff staff)
        {
            using (HastaneContext context = new HastaneContext())
            {
                context.Staffs.Add(staff);
                context.SaveChanges();
            }
        }

        private void butonKaydet_Click(object sender, EventArgs e)
        {
            Add(new Staff
            {
                PersonelAdSoyad = textAd.Text,
                Iban = textiban.Text,
                PersonelKimlik = textKimlik.Text,
                PersonelTel = textTel.Text,
                PersonelBirim = textBirim.Text,
                PersonelMaas = textMaas.Text,
                PersonelDiploma = textDiploma.Text,
                PersonelAdres = textDiploma.Text
            });
            MessageBox.Show("Kayıt Başarılı");
        }
    }
}
