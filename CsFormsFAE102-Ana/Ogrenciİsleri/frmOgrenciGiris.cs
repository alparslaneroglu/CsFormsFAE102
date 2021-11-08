using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsFAE102_Ana.Fonksiyonlar;
using CsFormsFAE102_Ana.Ogrenciİsleri.OgrEntity;
namespace CsFormsFAE102_Ana.Ogrenciİsleri
{
    public partial class frmOgrenciGiris : Form
    {
        readonly StudentsEntities1 sdb = new StudentsEntities1();
        private Mesajlar m = new Mesajlar();
        public int sehId = -1;
        public int bolId = -1;
        public int secimId = -1;
        public bool Edit = false;


        public frmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void frmOgrenciGiris_Load(object sender, EventArgs e)
        {
            
            Combolar();
            Temizle();
            Listele();
        }
        private void YeniKayit()
        {
            try
            {
                tblOgrenciBilgileri ogr = new tblOgrenciBilgileri();
                ogr.Ad = txtAd.Text;
                ogr.SoyAd = txtSoyad.Text;
                ogr.Tcno = mTxtTc.Text; // txtTc.Text; de yazılabilir.
                ogr.OgrNo = mTxtOgrNo.Text;
                //ogr.SehirId = sehId; // yukarda sehId -1 olarak tanımladık . Çünkü yeni kayıt ediyoruz.
                ogr.SehirId = sdb.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                ogr.BolumId = sdb.tblDepartments.First(x=>x.BolumAdı==txtBolum.Text).Id;
                ogr.isActive = true;
                sdb.tblOgrenciBilgileri.Add(ogr);
                sdb.SaveChanges();
                m.YeniKayit("Ogr Bilgileri Kaydedildi...");
                Listele();
                
            }   
            catch (Exception e)
            {

                m.Hata(e);
            }
        }

        private void Listele()
        {
           liste.Rows.Clear();
            int i = 0, sayi = 1;
            
            var lst = (from s in sdb.tblOgrenciBilgileri
                       where s.isActive==true       // lambda ve linq arasındaki fark linq de her bir şey arasında boşluk ile geçişler var .Lambdada notkalar vardır.
                       select new                  // varsayalım bir tablodaki belli başlı bilgilere ihtiyacımız varsa
                       {
                           id = s.Id,
                           ad = s.Ad,
                           soyad = s.SoyAd,
                           tc = s.Tcno,
                           ogrno = s.OgrNo,
                           sehir = s.tblSehirler.sehir,
                           bolum = s.tblDepartments.BolumAdı,
                           durum = s.isActive

                       }).ToList();
            foreach (var k in lst)
            {
               string sayi1 =DateTime.Now.Year + sayi.ToString().PadLeft(7, '0');
                liste.Rows.Add();
                liste.Rows[i].Cells["Id"].Value = k.id;
                liste.Rows[i].Cells[1].Value = sayi1;
                liste.Rows[i].Cells[2].Value = k.ad;
                liste.Rows[i].Cells[3].Value = k.soyad;
                liste.Rows[i].Cells[4].Value = k.tc;
                liste.Rows[i].Cells[5].Value = k.ogrno;
                liste.Rows[i].Cells[6].Value = k.sehir;
                liste.Rows[i].Cells[7].Value = k.bolum;
                liste.Rows[i].Cells[8].Value = k.durum;
                i++;
                sayi++;
            }
            liste.AllowUserToAddRows = false;
                    }

        private void Temizle()
        {
            //txtSehir.Items.Clear(); Bu işlem combobox ın içindeki bütün verileri sıfırlar.
            //txtSehir.Text = "";
            //txtBolum.Text = "";
            //txtAd.Clear();
            //txtSoyad.Clear();
            //txtOgrNo.Clear();
            //txtTc.Clear();

            foreach (Control ct in scOgr.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox || ct is MaskedTextBox)
                {
                    ct.Text = "";
                }
            }
            secimId = -1;
            Edit = false;
            sehId = -1;
            bolId = -1;
        }

        private void Combolar()
        {
            txtSehir.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection(); // Burada bir veri üreteceğiz
            var lst = sdb.tblSehirler.Select(x => x.sehir).Distinct(); // Tek bir veri alacağımız zaman kullanabiliyoruz.Bu yapıyı.


            foreach (string s in lst)
            {
                veri.Add(s);
                txtSehir.Items.Add(s); // Combobox içerisine atıyoruz. 
            }
            txtSehir.AutoCompleteCustomSource = veri;// Burada her bir harfe bastığımızda ilgili veriyi getiriyor.

            txtBolum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri1 = new AutoCompleteStringCollection(); // Burada bir veri üreteceğiz
            var lst1 = sdb.tblDepartments.Where(x=>x.isActive==true).Select(x=>x.BolumAdı).Distinct();


            foreach (string s in lst1)
            {
                veri1.Add(s);
                txtBolum.Items.Add(s);
            }
            txtBolum.AutoCompleteCustomSource = veri1;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secimId>0 && Edit==true && m.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else if (Edit == false)
            {
                YeniKayit();
            }
            Temizle();
            Listele();
        }

        private void Guncelle()
        {
            try
            {
                tblOgrenciBilgileri ogr = sdb.tblOgrenciBilgileri.Find(secimId);
                ogr.Ad = txtAd.Text;
                ogr.SoyAd = txtSoyad.Text;
                ogr.SehirId = sdb.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                ogr.BolumId = sdb.tblDepartments.First(x => x.BolumAdı == txtBolum.Text).Id;
                ogr.Tcno = mTxtTc.Text;
                ogr.OgrNo = mTxtOgrNo.Text;
                
                sdb.SaveChanges();
                m.Guncelle(true);
                Temizle();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Ac()
        {
            try
            {
                tblOgrenciBilgileri ogr = sdb.tblOgrenciBilgileri.Find(secimId);
                txtSehir.Text = ogr.tblSehirler.sehir;
                txtBolum.Text = ogr.tblDepartments.BolumAdı;
                txtAd.Text = ogr.Ad;
                txtSoyad.Text = ogr.SoyAd;
                mTxtOgrNo.Text = ogr.OgrNo;
                mTxtTc.Text = ogr.Tcno;
            }
            catch (Exception e)
            {

                m.Hata(e);
            }
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Edit = true;
                secimId = (int)liste.CurrentRow.Cells[0].Value;
                Ac();
            }
            catch (Exception)
            {

                secimId = -1;
                Edit = false;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            tblOgrenciBilgileri ogr = sdb.tblOgrenciBilgileri.Find(secimId);
            ogr.isActive = false;
            sdb.SaveChanges();
            m.Sil(true);
            //MessageBox.Show("Kayıt başarı ile silindi..");
            Temizle();
            Listele();
        }
    }
}
