using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] sehirler = { "Ankara", "eSKİŞEHİR", "Antalya", "Adana", "İstanbul", "Bursa", "BALIKESİR" };
            //int i;
            //for (i=0;i<sehirler.Length;i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10,11,12};
           for (int i=0;i<sayilar.Length;i++)
            {
                if(sayilar[i]%2==0 && sayilar[i]>=10)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
