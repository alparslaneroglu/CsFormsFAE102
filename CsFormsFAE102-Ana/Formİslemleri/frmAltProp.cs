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
    public partial class frmAltProp : Form
    {
        public List<ModelKisi> elist { set { dataGridView1.DataSource = value; } }      //<> İşaretleri varsa bu generic tir.List adında bir yapı oluşturduk buna elist dedik datagride deger göndermek istiyoruz.
        public frmAltProp()
        {
            InitializeComponent();
        }

        private void frmAltProp_Load(object sender, EventArgs e)
        {

        }
    }
}
