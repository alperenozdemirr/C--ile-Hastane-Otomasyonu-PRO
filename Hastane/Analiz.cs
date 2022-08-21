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
    public partial class Analiz : Form
    {
        public Analiz()
        {
            InitializeComponent();
        }

        private void Analiz_Load(object sender, EventArgs e)
        {
            using(HastaneContext veri =new HastaneContext())
            {
                Hastasayisi.Text = veri.TakeQueues.Count().ToString();
                Personelsayisi.Text = veri.Staffs.Count().ToString();
                Kayitlisayi.Text = veri.PatientSignups.Count().ToString();
            }
        }
    }
}
