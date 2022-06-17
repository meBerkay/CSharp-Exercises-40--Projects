using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer_KlavyedenVeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi * sayi;
            label2.Text = sonuc.ToString();
            //int sayi;
            //sayi = Convert.ToInt32(textBox1.Text);
            //label2.Text = sayi.ToString();
        }
    }
}
