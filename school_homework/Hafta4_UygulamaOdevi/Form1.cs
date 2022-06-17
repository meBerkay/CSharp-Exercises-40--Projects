using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4_UygulamaOdevi
{
    public partial class Form1 : Form
    {
        string metin, karsilasilan, deger;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label4.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Büyük Harfe Dönüştür")
            {
               
            }
            if (comboBox1.Text == "Küçük Harfe Dönüştür")
            {
               

            }
            if (comboBox1.Text == "İlk Karşılaşılan Metnin Yeri")
            {
                if (textBox2.Visible == true)
                    textBox3.Visible = false;
                else
                    textBox2.Visible = true;


            }
            if (comboBox1.Text == "Son Karşılaşılan Metnin Yeri")
            {
                if (textBox2.Visible == true)
                    textBox3.Visible = false;
                else
                    textBox2.Visible = true;

            }
            if (comboBox1.Text == "Değer Değiştir")
            {
                if (textBox2.Visible == true)
                    textBox2.Visible = true;
                
                else
                    textBox2.Visible = true;
                textBox3.Visible = true;

            }
            if (comboBox1.Text == "Metni Sil")
            {
                if (textBox2.Visible == true)
                    textBox2.Visible = true;

                else
                    textBox2.Visible = true;
                textBox3.Visible = true;

            }
            if (comboBox1.Text == "Metnin Parçasını Al")
            {
                if (textBox2.Visible == true)
                    textBox2.Visible = true;

                else
                    textBox2.Visible = true;
                textBox3.Visible = true;



            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Büyük Harfe Dönüştür")
            {
                metin = textBox1.Text;
                label4.Text = metin.ToUpper();
                
            }
            if (comboBox1.Text == "Küçük Harfe Dönüştür")
            {
                metin = textBox1.Text;
                label4.Text = metin.ToLower();

            }
            if (comboBox1.Text == "İlk Karşılaşılan Metnin Yeri")
            {
                metin = textBox1.Text;

                if (textBox2.Text == "")
                {

                    MessageBox.Show("Değer 1 boş geçilemez.");

                    return;

                }

                string ara = textBox2.Text;
                int sonuc;
                sonuc = metin.IndexOf(ara, 0, metin.Length - 1);
                if (sonuc == -1)
                {
                    MessageBox.Show("Aradığınız Değer Bulunamadı");
                }
                else
                {
                    label4.Text = sonuc.ToString() + ". karakterden itibaren " + textBox2.Text + " harfi var.";

                }

            }
            if (comboBox1.Text == "Son Karşılaşılan Metnin Yeri")
            {
                metin = textBox1.Text;
                if (textBox2.Text == "")
                {

                    MessageBox.Show("Değer 1 boş geçilemez.");

                    return;

                }
                string ara = textBox2.Text;
                int sonuc;
                sonuc = metin.LastIndexOf(ara, metin.Length - 1, metin.Length);
                if (sonuc == -1)
                {
                    MessageBox.Show("Aradığınız Değer Bulunamadı");
                }
                else
                {
                    label4.Text = sonuc.ToString() + ". karakterden itibaren sondan " + textBox2.Text + " harfi var.";
                }

            }
            if (comboBox1.Text == "Değer Değiştir")
            {
                metin = textBox1.Text;
                if (textBox2.Text == "")
                {

                    MessageBox.Show("Değer 1 boş geçilemez.");

                    return;

                }
                if (textBox3.Text == "")
                {

                    MessageBox.Show("Değer 2 boş geçilemez.");

                    return;

                }
                metin = metin.Replace(textBox2.Text, textBox3.Text);
                label4.Text = metin;

            }
            if (comboBox1.Text == "Metni Sil")
            {
                metin = textBox1.Text;
                if (textBox2.Text == "")
                {

                    MessageBox.Show("Değer 1 boş geçilemez.");

                    return;

                }
                if (textBox3.Text == "")
                {

                    MessageBox.Show("Değer 2 boş geçilemez.");

                    return;

                }

                label4.Text = metin.Remove(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

            }
            if (comboBox1.Text == "Metnin Parçasını Al")
            {
                metin = textBox1.Text;
                if (textBox2.Text == "")
                {

                    MessageBox.Show("Değer 1 boş geçilemez.");

                    return;

                }
                if (textBox3.Text == "")
                {

                    MessageBox.Show("Değer 2 boş geçilemez.");

                    return;

                }
                else
                {
                    label4.Text = metin.Substring(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                }
            }

        

        //private void comboBox1_TextChanged(object sender, EventArgs e)
        //{
        //    //if (comboBox1.Text== "Büyük Harfe Dönüştür")
        //    //{
        //    //    metin = textBox1.Text;
        //    //    label6.Text = metin.ToUpper();
        //    //    button3.
        //    //}
        //    //if (comboBox1.Text == "Küçük Harfe Dönüştür")
        //    //{
        //    //    metin = textBox1.Text;
        //    //    label4.Text = metin.ToLower();

        //    //}
        //    //if (comboBox1.Text == "İlk Karşılaşılan Metnin Yeri")
        //    //{
        //    //    metin = textBox1.Text;


                
        //    //    string ara = textBox2.Text;
        //    //    int sonuc;
        //    //    sonuc = metin.IndexOf(ara, 0, metin.Length - 1);
        //    //    if (sonuc == -1)
        //    //    {
        //    //        MessageBox.Show("Aradığınız Değer Bulunamadı");
        //    //    }
        //    //    else
        //    //    {
        //    //        label4.Text = sonuc.ToString()+". karakterden itibaren " + textBox2.Text + " harfi var.";
                    
        //    //    }

        //    //}
        //    //if (comboBox1.Text == "Son Karşılaşılan Metnin Yeri")
        //    //{
        //    //    metin = textBox1.Text;
               
        //    //    string ara = textBox2.Text;
        //    //    int sonuc;
        //    //    sonuc = metin.LastIndexOf(ara, metin.Length - 1, metin.Length);
        //    //    if (sonuc == -1)
        //    //    {
        //    //        MessageBox.Show("Aradığınız Değer Bulunamadı");
        //    //    }
        //    //    else
        //    //    {
        //    //        label4.Text = sonuc.ToString() + ". karakterden itibaren sondan " + textBox2.Text + " harfi var.";
        //    //    }

        //    //}
        //    //if (comboBox1.Text == "Değer Değiştir")
        //    //{
        //    //    metin = textBox1.Text;
        //    //    metin = metin.Replace(textBox2.Text, textBox3.Text);
        //    //    label4.Text = metin;

        //    //}
        //    //if (comboBox1.Text == "Metni Sil")
        //    //{
        //    //    metin = textBox1.Text;
                
                
        //    //    label4.Text = metin.Remove(Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text));

        //    //}
        //    //if (comboBox1.Text == "Metnin Parçasını Al")
        //    //{
        //    //    metin = textBox1.Text;
        //    //    if (textBox3.Text == "")
        //    //    {

        //    //        MessageBox.Show("Değer 2 boş geçilemez.");

        //    //        return;

        //    //    }
        //    //    else
        //    //    {
        //    //        label4.Text = metin.Substring(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        //    //    }



        //    }
        }
    }
}
