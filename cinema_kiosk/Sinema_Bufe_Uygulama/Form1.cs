using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt32(txtMisir.Text);
            bilet = Convert.ToInt32(txtBilet.Text);
            su = Convert.ToInt32(txtSu.Text);
            cay = Convert.ToInt32(txtCay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lblToplam.Text = toplam.ToString()+ " TL";
            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            txtMisir.Focus();
        }
    }
}
