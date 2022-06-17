using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilarıile_DonguKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            double faktoriyel=1;

            for(int i=1;i<=sayi;i++)
            {
                faktoriyel = faktoriyel * i;
            }
            listBox1.Items.Add(faktoriyel);
            //int sayi = Convert.ToInt32(textBox1.Text);
            
            //for (int i=1; i<=sayi; i++)
            //{
            //    if(sayi%i==0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            //for (int i=1; i<=100; i++)
            //{
            //    if (i % 7 == 0 && i%5==0)
            //        listBox1.Items.Add(i);
            //}
        }
    }
}
