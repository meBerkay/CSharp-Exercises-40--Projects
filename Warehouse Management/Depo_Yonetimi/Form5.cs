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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 stok = new Form4();
            stok.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sayi;
            
            /*
             *  comboBox1 ve comboBox2 ' nin eşit biçimde ayarlanmasını sağlıyoruz.
             */
            sayi = comboBox1.Items.IndexOf(comboBox1.SelectedItem); 
            comboBox2.SelectedIndex = sayi; 
        }
      
     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * CheckBox eğer işaretlendiyse comboBox3'in görünürlüğünü true
             * değilse false yapar.
             */
            if (checkBox1.Checked == true)
                comboBox3.Visible = true;
            else
                comboBox3.Visible = false;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fiyat, adet, taksit;
             fiyat = int.Parse(textBox1.Text);
                adet = int.Parse(textBox2.Text);

            /*
            * CheckBox eğer taksit hesabı yapar.
            * Değilse, taksitsiz fiyat teklifini hesaplar.
            * Hata kontrolü Try-Catch ile sağlandı.
            */
            
            try
            {
                fiyat = int.Parse(textBox1.Text);
                adet = int.Parse(textBox2.Text);


                if (checkBox1.Checked == true)
                {
                    taksit = int.Parse(comboBox3.Text);
                    label7.Text = (fiyat * adet + (fiyat * adet * taksit * 5 / 100)).ToString();
                }
                else
                    label7.Text = (fiyat * adet).ToString();
            }
            catch
            {

                MessageBox.Show("Lütfen girdiğiniz değeri kontrol ediniz.");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       
    }
}