using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Mehmet", "Aslı", "Ayşe", "Berkay" };
            //label1.Text = kisiler[4];

            //int[] sayilar = { 4, 5, 6, 7, 8, 9, 8, 2, 3 };
            //label1.Text = sayilar[5].ToString();

            //double[] ondalik = { 1.10, 1.20, .150, 1.70, 1.90, 2.10 };
            //label1.Text = ondalik[1].ToString();

            char[] harfler = { 'a', 'b', 'c', 'd', 'c', 'c', 'c', 'c' };
            label1.Text = harfler[2].ToString();
        }
    }
}
