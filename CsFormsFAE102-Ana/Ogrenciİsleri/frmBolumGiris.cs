using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsFAE102_Ana.Ogrenciİsleri.OgrEntity;
namespace CsFormsFAE102_Ana.Ogrenciİsleri
{
    public partial class frmBolumGiris : Form
    {
        StudentsEntities1 sdb = new StudentsEntities1();
        public frmBolumGiris()
        {
            InitializeComponent();
        }

        private void frmBolumGiris_Load(object sender, EventArgs e)
        {

            listele();

        }

        private void listele()
        {
            int i = 0;
            var lst = (from s in sdb.tblDepartments select s).ToList(); // Veri tabanındaki bilgileri al lst içine at.
            foreach (var k in lst) //lst nin içindekileri bir bir alıp k nın içine gönderiyor.
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id; // 0.Celline Id 1.Celline bolum adını yazıyor.
                Liste.Rows[i].Cells[1].Value = k.BolumAdı;
                i++;

            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.AllowUserToOrderColumns = false;
        }


    }
}
