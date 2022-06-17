using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 10)
            {
               this.label1.BackColor = Color.Red;
                label3.BackColor = Color.White;
            }
            if (sayac ==20)
            {
                this.label2.BackColor = Color.Yellow;

            }
            if(sayac ==30)
            {
                this.label3.BackColor = Color.Green;
                sayac = 0;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
