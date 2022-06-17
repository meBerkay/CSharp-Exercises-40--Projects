using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2;
            string islem;

            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            //toplam = Convert.ToDouble(textBox3.Text);
            islem = textBox3.Text;
            

            switch (islem)
            {
                case "+":
                    textBox4.Text = (s1 + s2).ToString("0.00");


                    break;
                case "-":
                    textBox4.Text = (s1 - s2).ToString("0.00");
                    break;
                case "*":
                    textBox4.Text = (s1 * s2).ToString("0.00");
                    break;
                case "/":
                    textBox4.Text = (s1 /s2).ToString("0.00");


                    break;
                default:
                    MessageBox.Show("Geçersiz bir parametre girildİ. Girilen parametreyi düzeltip tekrar deneyin.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox1.Focus();
                    break;


            }
        }
    }
}
