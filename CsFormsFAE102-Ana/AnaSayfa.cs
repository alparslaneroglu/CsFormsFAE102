using CsFormsFAE102_Ana.Formİslemleri;
using CsFormsFAE102_Ana.Ogrenciİsleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsFormsFAE102_Ana
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        #region PnlUst Paneli
        private void button1_Click(object sender, EventArgs e)
        {
            gbSol.Text = button1.Text;
            Paneller();
            pnl1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSol.Text = button2.Text;
            Paneller();
            pnl2.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbSol.Text = button3.Text;
            Paneller();
            pnl3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbSol.Text = button4.Text;
            Paneller();
            pnl4.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            gbSol.Text = button5.Text;
            Paneller();
            pnl5.Visible = true;

           
        }
        private void button6_Click(object sender, EventArgs e)
        {
            gbSol.Text = button6.Text;
            Paneller();
            pnl6.Visible = true;

        }
        private void button7_Click(object sender, EventArgs e)
        {
            gbSol.Text = button7.Text;
            Paneller();
            pnl7.Visible = true;
        }
        void Paneller()
        {
            gbSol.Visible = true;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        #region From İslemleri
        private void btnGonderProp_Click(object sender, EventArgs e)
        {
            frmGonderProp frm = new frmGonderProp();
            frm.MdiParent = Form.ActiveForm; // anasayfa frm nin parent'ı oluyor.
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnGonderCons_Click(object sender, EventArgs e)
        {
            frmGonderCons frm = new frmGonderCons();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btnCollaps_Click(object sender, EventArgs e)
        {
            if (gbSol.Visible == true)
            {
                gbSol.Visible = false;
                btnCollaps.Text = "GOSTER";

            }
            else if (gbSol.Visible == false)
            {
                gbSol.Visible = true;
                btnCollaps.Text = "GIZLE";
            }
        }

        #endregion

        private void urunGonder_Click(object sender, EventArgs e)
        {
            urunGonder ugndr = new urunGonder();
            ugndr.MdiParent = Application.OpenForms["Anasayfa"] as AnaSayfa;
            ugndr.WindowState = FormWindowState.Maximized;
            ugndr.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            frmBolumGiris frm = new frmBolumGiris();
            frm.ShowDialog();
        }
    }
}
