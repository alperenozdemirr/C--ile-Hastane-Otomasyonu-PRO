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
    public partial class Sira : Form
    {
        public Sira()
        {
            InitializeComponent();
        }
        void Add(TakeQueue takeQueue)
        {
            using (HastaneContext context = new HastaneContext())
            {
                context.TakeQueues.Add(takeQueue);
                context.SaveChanges();
            }
        }
        private void Sira_Load(object sender, EventArgs e)
        {

        }

        private void butonKaydet_Click(object sender, EventArgs e)
        {
            Add(new TakeQueue { 
            AdSoyad = textAd.Text,
            Kimlik = textKimlik.Text,
            Polikinik = textPolikinik.Text,
            DoktorAdi = textDoktorAd.Text
            });
            MessageBox.Show("Sıra Alındı");
        }
    }
}
