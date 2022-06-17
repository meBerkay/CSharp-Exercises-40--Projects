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
    public partial class Form6 : Form
    {
        public Form6()
        {
            /*
             * Form başlatılırken ilgili bileşenler çalıştırılıyor ve listBox2'ye
             * çizim özelliklerini tanımlıyoruz. (Satır renklendirme için.)
             */
            InitializeComponent();
            listBox2.DrawMode = DrawMode.OwnerDrawFixed;
            listBox2.DrawItem += new DrawItemEventHandler(listBox2_RenkAyarla);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void listBox2_RenkAyarla(object sender, DrawItemEventArgs e)
        {
            /*
             * Bu bölümde hata kontrolü ile birlikte(Try-Catch)
             * listBoxlarda olan satırın, textBox1 de bulunan değerden daha düşük olduğunda
             * kırmızı renkte görünmesini sağladık.
             * Bu sayede depodaki durum takibi kolayca yapılabilecek.
             */
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.White;

                int sayi = Convert.ToInt32(((ListBox)sender).Items[e.Index].ToString());
                if (sayi < Convert.ToInt32(textBox1.Text))
                {
                    myBrush = Brushes.Red;

                }
                else
                {
                    myBrush = Brushes.Green;
                }

                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch
            {

            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Değişikliklerin uygulanması için listBox2'yi tazeliyoruz.
             */
            listBox2.Refresh();
        }

  
    }
}
