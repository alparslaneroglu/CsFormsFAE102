using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsFAE102_Ana.Entity;

namespace CsFormsFAE102_Ana.Formİslemleri
{
    public partial class frmGonderProp : Form
    {
        public frmGonderProp()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            frmAltProp frm = new frmAltProp();
            frm.elist = db.Employees.Select(x => new ModelKisi
            {

                Ad = x.FirstName,
                SoyAd = x.LastName
            }).ToList();
            frm.Show();             // x adında bir isim oluşturuyoruz.Bu property yöntemi ile çözümdür.Bize liste şeklinde gönderim yapmasını istiyoruz.
        
        }
    }
}
