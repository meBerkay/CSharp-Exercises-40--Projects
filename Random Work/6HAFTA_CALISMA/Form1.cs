using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6HAFTA_CALISMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kactane = listBox1.Items.Count;
            int i = kactane;
            while (i > 0)
            {
                Random isim = new Random();
                int s1 = isim.Next(0, kactane);
                int s2 = isim.Next(0, kactane);
                int s3 = isim.Next(0, kactane);
                string yeni = listBox1.Items[s1].ToString();
                yeni += " " + listBox2.Items[s2].ToString();
                yeni += " " + listBox3.Items[s3].ToString();
                listBox4.Items.Add(yeni);
                listBox1.Items.RemoveAt(s1);
                listBox2.Items.RemoveAt(s2);
                listBox3.Items.RemoveAt(s2);
                kactane = listBox1.Items.Count;
                i--;

            }
        }
    }
}
