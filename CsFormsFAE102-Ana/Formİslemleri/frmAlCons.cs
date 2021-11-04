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
    public partial class frmAlCons : Form
    {
        public frmAlCons()
        {
            InitializeComponent();
        }

        public frmAlCons(List<ModelKisi> elist)
        {
            InitializeComponent();
            dataGridView1.DataSource = elist;    // Data grid kısmını elistten gelen bilgi ile dolduracak.Const yapısı ilk olarak çalışmasını istediğimiz şeyler varsa orada çalışıyor. İki tane yapıcı metod olduğunda hangisi önce olacak karar veremiyor.Compenentler eksik olduğu için açamıyor.
        }

        private void frmAlCons_Load(object sender, EventArgs e)
        {

        }
    }
}
