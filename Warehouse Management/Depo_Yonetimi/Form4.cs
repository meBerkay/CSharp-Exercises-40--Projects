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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string[] kategori = new string[50];
        string[] barkod = new string[50];
        string[] stok = new string[50];
        int sayi;
        int a1, a2, a3;
        private void Form4_Load(object sender, EventArgs e)
        {
            /*
             * Form yüklenirken, aşağıdaki değişkenleri tanımlayarak
             * 0'a eşitliyoruz.
             */
            a1 = 0; 
            a2 = 0; 
            a3 = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2; //yerel değişkenlerimizi tanımlıyoruz.
            Form5 teklif = new Form5();  //form5'i tanımlıyoruz.
            teklif.Show(); //form5'ı(teklif) açtık.

            /*
             * Bu bölümde basla1 ve b2 değişkenleriyle for döngüsüne sokarak
             * dizinde bulunan verileri comboBox nesnelerine aktarır.
             */
            for (b1 = 0; b1 < a1; b1++) 
                teklif.comboBox1.Items.Add(kategori[b1]); 

            for (b2 = 0; b2 < a2; b2++)
                teklif.comboBox2.Items.Add(barkod[b2]);           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text); //textbox1 deki veriyi listBox1'e ekler.
                listBox2.Items.Add(textBox2.Text); //textbox2 deki veriyi listBox2'e ekler.
                listBox3.Items.Add(textBox3.Text); //textbox3 deki veriyi listBox3'e ekler.
                listBox4.Items.Add(DateTime.Now); //o anki tarihi listbox4'e ekler.

                kategori[a1] = textBox1.Text; //kategori dizisinin içine textbox1deki veriyi aktarıyoruz.
                barkod[a2] = textBox2.Text; //barkod dizisinin içine textbox2deki veriyi aktarıyoruz.
                stok[a3] = textBox3.Text; //stok dizisinin içine textbox3deki veriyi aktarıyoruz.
                                           
                a1++; // a1'i arttırıyoruz.
                a2++; // a2'yi arttırıyoruz.
                a3++; // a3'yi arttırıyoruz.

                /*
                 * TextBox içlerindeki değerleri temizliyoruz.
                 */
                textBox1.Text = ""; 
                textBox2.Text = ""; 
                textBox3.Text = ""; 
                               

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
            *Try - Catch ile hata kontrolü sağlanmıştır.
            */
            try
            {

                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, textBox1.Text);
                listBox2.Items.RemoveAt(index);
                listBox2.Items.Insert(index, textBox2.Text);
                listBox3.Items.RemoveAt(index);
                listBox3.Items.Insert(index, textBox3.Text);
                /*
                 * TextBox içlerindeki değerleri temizliyoruz.
                 */
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";


            }
            catch
            {
                MessageBox.Show("Lütfen listeden eleman seçin!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {


            int basla1, basla2; //yerel değişkenlerimizi tanımlıyoruz.
            Form6 analiz = new Form6(); //form6'ü tanımlıyoruz.
            analiz.Show(); //form6'yı açtık.

            for (basla1 = 0; basla1 < a1; basla1++) 
                analiz.listBox1.Items.Add(barkod[basla1]); 

            for (basla2 = 0; basla2 < a2; basla2++)
                analiz.listBox2.Items.Add(stok[basla2]);
   

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
             * Seçilen itemleri listboxlardan kaldırır.
             */
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
            listBox4.Items.Remove(listBox4.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                 * Bu bölümde IndexOf ile seçili itemin sırasını belirleyerek
                 * listBox2 ve listBox3'te sıra eşitlemesi yapmaya yarar.
                 * Try-Catch ile hata kontrolü sağlanmıştır.
                 */
            try
            {                
                sayi = listBox1.Items.IndexOf(listBox1.SelectedItem); 
                listBox2.SelectedIndex = sayi; 
                listBox3.SelectedIndex = sayi;
                listBox4.SelectedIndex = sayi;

            }
            catch
            {
               
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
               * Bu bölümde IndexOf ile seçili itemin sırasını belirleyerek
               * listBox1 ve listBox3'te sıra eşitlemesi yapmaya yarar.
               * Try-Catch ile hata kontrolü sağlanmıştır.
               */
            try
            {               
                sayi = listBox2.Items.IndexOf(listBox2.SelectedItem); 
                listBox1.SelectedIndex = sayi; 
                listBox3.SelectedIndex = sayi;
                listBox4.SelectedIndex = sayi;
            }
            catch
            {
               
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * Stok adedi girilmesini sağlayan textBox3'e sadece sayı girilmesini
             * keyPress eventi ile sağlandı.
             */
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             * Formun FormClosing özelliğini kullanarak kullanıcıya X işaretine basıldığında
             * uygulamadan çıkış yaptırır. Programa ait tüm pencereler kapanır.
             */
            Application.Exit();                       
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                * Bu bölümde IndexOf ile seçili itemin sırasını belirleyerek
                * listBox1 ve listBox2'te sıra eşitlemesi yapmaya yarar.
                * Try-Catch ile hata kontrolü sağlanmıştır.
                */
            try
            {                
                sayi = listBox3.Items.IndexOf(listBox3.SelectedItem); 
                listBox1.SelectedIndex = sayi; 
                listBox2.SelectedIndex = sayi;
                listBox4.SelectedIndex = sayi;
            }
            catch
            {
               
            }

        }

     
        private void button6_Click(object sender, EventArgs e)
        {
            /*
                * Bu bölümde selectedItem ile listBoxlardkai seçili olan nesnesleri
                * textBoxlara yazdırır.
                * Try-Catch ile hata kontrolü sağlanmıştır.
                */
            try
            {
               
                textBox1.Text = (string)listBox1.SelectedItem;
                textBox2.Text = (string)listBox2.SelectedItem;
                textBox3.Text = (string)listBox3.SelectedItem;

            }
            catch
            {
                MessageBox.Show("Lütfen eleman seçin");
            }

        }
    }
}
