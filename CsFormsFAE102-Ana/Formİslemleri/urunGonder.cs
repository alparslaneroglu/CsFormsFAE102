using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsFormsFAE102_Ana.Formİslemleri
{
    public partial class urunGonder : Form
    {
        public urunGonder()
        {
            InitializeComponent();
        }

        void Temizle()
        {
        
            
        }

       
        private void btnGonder_Click_1(object sender, EventArgs e)
        {
            urunSonuc ugndr1 = new urunSonuc();
            ugndr1.lblUrunAd.Text = txtUrunAd.Text;
            ugndr1.lblUrunFiyat.Text = txtUrunFiyat.Text;
            double Kdv = Convert.ToDouble(txtUrunFiyat.Text)*0.18;
            ugndr1.lblKdv.Text = Convert.ToString(Kdv);
            double sonFiyat = Convert.ToDouble(txtUrunFiyat.Text) +Kdv;
            ugndr1.lblKdvFiyat.Text = Convert.ToString(sonFiyat);
            ugndr1.Show();

        }
    }
}
