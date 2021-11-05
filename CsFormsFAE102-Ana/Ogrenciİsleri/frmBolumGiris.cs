using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsFAE102_Ana.Fonksiyonlar;
using CsFormsFAE102_Ana.Ogrenciİsleri.OgrEntity;
namespace CsFormsFAE102_Ana.Ogrenciİsleri
{
    public partial class frmBolumGiris : Form
    {
        StudentsEntities1 sdb = new StudentsEntities1();
        Mesajlar m = new Mesajlar(); // Mesaj classından bir nesne türettik.

        private int secimId = -1;
        private bool edit = false;
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
            if (rbHepsi.Checked==true)
            {
                Liste.Rows.Clear();

                int i = 0;
                var lst = (from s in sdb.tblDepartments select s).ToList(); // Veri tabanındaki bilgileri al lst içine at.
                foreach (var k in lst) //lst nin içindekileri bir bir alıp k nın içine gönderiyor.
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id; // 0.Celline Id 1.Celline bolum adını yazıyor.
                    Liste.Rows[i].Cells[1].Value = k.BolumAdı;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;

                }
                Liste.AllowUserToAddRows = false;// Listenin altında boş satır olmasını engelliyor.
                Liste.AllowUserToDeleteRows = false;//Silmeyi  engelliyor.

                Liste.AllowUserToOrderColumns = false; 
            }
            else if (rbAktif.Checked==true)
            {
                Liste.Rows.Clear();

                int i = 0;
                var lst = (from s in sdb.tblDepartments where s.isActive == true select s).ToList(); // Veri tabanındaki bilgileri al lst içine at.
                foreach (var k in lst) //lst nin içindekileri bir bir alıp k nın içine gönderiyor.
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id; // 0.Celline Id 1.Celline bolum adını yazıyor.
                    Liste.Rows[i].Cells[1].Value = k.BolumAdı;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;

                }
                Liste.AllowUserToAddRows = false;// Listenin altında boş satır olmasını engelliyor.
                Liste.AllowUserToDeleteRows = false;//Silmeyi  engelliyor.

                Liste.AllowUserToOrderColumns = false;
            }
            else if (rbPasif.Checked==true)
            {
                Liste.Rows.Clear();

                int i = 0;
                var lst = (from s in sdb.tblDepartments where s.isActive == false select s).ToList(); // Veri tabanındaki bilgileri al lst içine at.
                foreach (var k in lst) //lst nin içindekileri bir bir alıp k nın içine gönderiyor.
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id; // 0.Celline Id 1.Celline bolum adını yazıyor.
                    Liste.Rows[i].Cells[1].Value = k.BolumAdı;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;

                }
                Liste.AllowUserToAddRows = false;// Listenin altında boş satır olmasını engelliyor.
                Liste.AllowUserToDeleteRows = false;//Silmeyi  engelliyor.

                Liste.AllowUserToOrderColumns = false;
            }
        }

        private void YeniKayit()
        {
            try
            {
                if (txtBolumAdi.Text!="")
                {

                    tblDepartments blm = new tblDepartments();
                    blm.BolumAdı = txtBolumAdi.Text; //Eşitlenme işi kayıt edildiği anlamına gelmez.Once ekrana getirmek sonra kaydetmek gerekir.
                    blm.isActive = true;
                    sdb.tblDepartments.Add(blm); // Önce veri tabanına ekledik fakat kayıt edilmiş olmuyor birde onay süreci var.
                    sdb.SaveChanges(); // Onay  süreci burada gerçekleşiyor.Bu komut ile
                                       // MessageBox.Show("Yeni kayıt oluşturuldu.."); // hata olması durmu için try bloğuna alıyoruz.Eğer hata oluşuyorsa sistemi çökertmemek için kullanıyoruz.
                    m.YeniKayit("Yeni kayıt oluşturuldu..");

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata : " + e);
                //Büyük projelerde kendimiz hata kodu oluşturuyoruz.Ve Kullanıcı bu kod ile araştırdığında kendi oluşturduğumuz katalogdan bu hatanın ne olduğunu bulabiliyor ve çözebiliyoruz.

            }

        }

        private void Guncelle()
        {
            try
            {
                tblDepartments blm = sdb.tblDepartments.First(x => x.Id == secimId); //olan bir veriyi nesneleştiriyoruz. ".First " ifadesi tek bir kayıt döndürmemizi sağlıyor.Burada gidip seçim Id Yi alıyoruz.
                                                                                     //tblDepartments blm = sdb.tblDepartments.Find(secimId); // yukarıdaki ile aynı işlemi yapıyor.Find ile sadece Id tarıyoruz.First ile farklı alanlarda arayabiliyoruz.
                blm.Id = 22222;//Hata alabilmek için değiştirdik.
                //blm.BolumAdı = txtBolumAdi.Text;
                sdb.SaveChanges();// olanı güncelliyoruz.
                m.Guncelle(true);
            }
            catch (Exception e)
            {

                m.Guncelle(false);
                m.Guncelle(e);
               // MessageBox.Show("" + e);
                Close();
            }

            //MessageBox.Show("Kayıt güncelleştirildi..");

        }

        


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secimId>0 && edit==true && m.Guncelle()==DialogResult.Yes)
            {
                Guncelle();

            }
            else if(edit ==false)
            {
                YeniKayit();

            }
            else
            {
                Temizle();
            }
            listele();// Form kapanmadan bi okadar daha boş satır atıyor bunun çözümü. listele metodunda boş satırları temizlemesini "Liste.Rows.Clear();"yazarak çözeriz.
            Temizle();
        }

        
        
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId=(int)Liste.CurrentRow.Cells[0].Value;  // Current row çift tıkladığımda o andaki seçtiğim şeyin ıd 'sini ver. Buradaki işlem convert değil testing işlemidir.Objeleri convert işlemi yapamayız.Ancak objeyi ilk string ondan sonra parse işlemi yapmamız gerekir.Gereksiz uzama olur.
            txtBolumAdi.Text = Liste.CurrentRow.Cells[1].Value.ToString();//Listenin 1.Cellindeki değeri bölüm adına yazıyor.

            if (secimId>0) edit = true;


            //MessageBox.Show(secimId.ToString()); Alıp alamadığımızı kontrol ediyoruz.
         }



        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            secimId = -1;
            edit = false;
            txtBolumAdi.Clear();
        }

        private void txtBolumAdi_TextChanged(object sender, EventArgs e)
        {
            //if (txtBolumAdi.Text=="")
            //{
            //    edit = false;

            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            Temizle();
            listele();  
        }

        private void Sil()
        {

            try

                 {
                
               tblDepartments blm = sdb.tblDepartments.Find(secimId);
                blm.isActive = false;
               
                blm.Id = 2222222;
                sdb.SaveChanges();
                m.Sil(true);
                
                 }

    catch (Exception c)
            {
                m.Sil(false);
                m.Sil(c);
                Close();
               
            }

        }

        
            private void btnTamSil_Click(object sender, EventArgs e)
        {
            try
            {
                sdb.tblDepartments.Remove(sdb.tblDepartments.Find(secimId));
                tblDepartments blm = sdb.tblDepartments.Find(secimId);
                blm.Id = 222222222;
                sdb.SaveChanges();
               
                Temizle();
                listele();
            }
            catch (Exception d )
            {

                m.TSil(false);
                m.Sil(d);
                Close();
            }
        }

        private void chkPasif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPasif.Checked == true)
            {
                Liste.Rows.Clear();// Boş satırları siliyor.

                int i = 0;
                var lst = (from s in sdb.tblDepartments where s.isActive == false select s).ToList(); // Veri tabanındaki bilgileri al lst içine at.
                foreach (var k in lst) //lst nin içindekileri bir bir alıp k nın içine gönderiyor.
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id; // 0.Celline Id 1.Celline bolum adını yazıyor.
                    Liste.Rows[i].Cells[1].Value = k.BolumAdı;
                    i++;

                }
                Liste.AllowUserToAddRows = false;


                
            }
            else
            {
                listele();
            }
        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void rbPasif_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }
    }
    }

