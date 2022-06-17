using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo_Yonetimi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 stok = new Form4(); //Form4'ü stok adında değişkene tanımlıyoruz.
            stok.Show(); //stok formu açılıyor.
            this.Hide(); //Açık olan form gizleniyor.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamadan tamamen çıkış yaptırıyoruz.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAZIRLAYAN:\n BERKAY CAN ÖZKARADAYI");
        }
    }
}
