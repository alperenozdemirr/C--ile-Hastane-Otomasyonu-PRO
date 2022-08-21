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
    public partial class YöneticiGiris : Form
    {
        public YöneticiGiris()
        {
            InitializeComponent();
        }
        string sifre = "admin";

        Yonetici yonetici = new Yonetici();
        private void giris_Click(object sender, EventArgs e)
        {
            if(textAd.Text ==sifre  && textpassword.Text == sifre)
            {
                yonetici.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yanlış şifre");
            }
        }
    }
}
