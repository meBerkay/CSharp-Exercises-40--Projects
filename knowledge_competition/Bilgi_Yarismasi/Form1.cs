using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label2.Text = btnD.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label2.Text = btnB.Text;
            if(label1.Text == label2.Text )
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label2.Text = btnC.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label2.Text = btnA.Text;
            if(label1.Text == label2.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label1.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = " Hangi şehir Ege bölgemizde bulunmaz? ";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Adana";
                btnD.Text = "Manisa";
                label1.Text = "Balıkesir";
            }
            if (soruno==3)
            {
                richTextBox1.Text = " Son Kuşlar hangi yazara aittir? ";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = " Atilla İlhan";
                btnD.Text = " Reşat Nuri ";
                label1.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar";
            }
            if(soruno==4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru "+ dogru + "\n " + "Yanlış "+ yanlis);
                
            }
                
        }
    }
}
