using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CsFormsFAE102_Ana.Fonksiyonlar
{
    class Mesajlar   // Classlar fiziksel özellikerli olmadığı için form özelliklerini kullanmazlar. Bu yüzden windows forms kütüphanesi ekleniyor.Burada public class yapmadık çünkü sadece bilen biri ulaşsın.
    {
        public void YeniKayit(string mesaj) // Burada void olduğu için bizden geri dönüş beklemiyor.
        {
            MessageBox.Show(mesaj,"Yeni Kayit Giris",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()  // Guncelle bizden geri dönüş beklediği için bu işlemler return ile yapılıyor.

        {
            return MessageBox.Show("Secili olam kayit güncellenecektir..\n Güncelleme işlemini onaylıyormusunuz ?","Güncelleme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Secili olan kayit silinmiştir..\n Silme işlemini onaylıyormusunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool guncelleme)
        {

            if (guncelleme==true)
            {
                MessageBox.Show("Kayıt Güncellenmiştir.", "Kayıt Guncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.Kayıt Güncellenemedi.", "Kayıt Guncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void Guncelle(Exception e)
        {
            MessageBox.Show("" + e, "Kayıt Guncelleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "Isler yolunda gitmiyor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sil(bool sil)
        {
            if (sil==true)
            {
                MessageBox.Show("Kayıt Silinmiştir","Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.Kayıt Silinemedi.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Sil(Exception e)
        {
            MessageBox.Show("" + e, "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void TSil(bool sil)
        {
            if (sil == true)
            {
                MessageBox.Show("Tam Silinmiştir", "Tam Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.Kayıt Silinemedi.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void TSil(Exception e)
        {
            MessageBox.Show("" + e, "Tam Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
