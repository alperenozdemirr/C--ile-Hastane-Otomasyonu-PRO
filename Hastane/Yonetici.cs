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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            using (HastaneContext context = new HastaneContext())
            {
                dataKayit.DataSource = context.PatientSignups.ToList();
            }

            using (HastaneContext context = new HastaneContext())
            {
                dataPersonel.DataSource = context.Staffs.ToList();
            }

            using (HastaneContext context = new HastaneContext())
            {
                dataSira.DataSource = context.TakeQueues.ToList();
            }
        }
    }
}
