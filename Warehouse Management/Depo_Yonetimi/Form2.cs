using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo_Yonetimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /*
             * Bu bölümde kullanıcı adı ve şifre alanlarını belirtiyoruz.
             * Eğer kullanıcı doğru girişi yaparsa anapanel adlı form değişkenine yönlendiriliyor.
             * Eğer kullanıcı adı ve şifresinden birini yanlış yaparsa hata mesajı çıkarak kullanıcıyı uyarır.
             */

            if (txtKullaniciAdi.Text=="berkay" && txtSifre.Text=="1234")
            {
                MessageBox.Show("Giriş Başarılı, Yönlendiriliyorsunuz!");
                Form3 anapanel = new Form3();
                anapanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız, Bilgilerinizi Kontrol Edin");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             * Formun FormClosing özelliğini kullanarak kullanıcıya X işaretine basıldığında
             * uygulamadan çıkış yaptırır. Programa ait tüm pencereler kapanır.
             */
            Application.Exit();
        }
    }
}
