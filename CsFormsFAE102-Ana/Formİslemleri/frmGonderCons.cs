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
    public partial class frmGonderCons : Form
    {
        public frmGonderCons()
        {
            InitializeComponent();
        }

        private void frmGonderCons_Load(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();

            List<ModelKisi> elist = db.Employees.Select(x => new ModelKisi
            {
                Ad = x.FirstName,
                SoyAd = x.LastName

            }).ToList();
            frmAlCons frm = new frmAlCons(elist);
            frm.Show();
           

        }
    }
}
