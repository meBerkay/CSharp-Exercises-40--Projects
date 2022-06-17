using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ay;
            ay = textBox1.Text.ToLower();

            switch (ay)
            {
                case "aralık":
                    label2.Text = "kış";
                    break;
                case "ocak":
                    label2.Text = "kış";
                    break;
                case "şubat":
                    label2.Text = "kış";
                    break;
                case "mart":
                    label2.Text = "ilkbahar";
                    break;
                case "nisan":
                    label2.Text = "ilkbahar";
                    break;
                case "mayıs":
                    label2.Text = "ilkbahar";
                    break;
                case "haziran":
                    label2.Text = "yaz";
                    break;
                case "temmuz":
                    label2.Text = "yaz";
                    break;
                case "ağustos":
                    label2.Text = "yaz";
                    break;
                case "eylül":
                    label2.Text = "sonbahar";
                    break;
                case "ekim":
                    label2.Text = "sonbahar";
                    break;
                case "kasım":
                    label2.Text = "sonbahar";
                    break;
                default:
                    label2.Text = " Geçersiz değer girişi";
                    MessageBox.Show("Lütfen küçük harflerde harf girişi sağlayın");
                    break;

            }
            //    int ay;
            //    ay = Convert.ToInt32(textBox1.Text);

            //switch(ay)
            //    {
            //        case 1:
            //            label2.Text = "Ocak";
            //            break;
            //        case 2:
            //            label2.Text = "Şubat";
            //            break;
            //        case 3:
            //            label2.Text = "Mart";
            //            break;
            //        case 4:
            //            label2.Text = "Nisan";
            //            break;
            //        case 5:
            //            label2.Text = "Mayıs";
            //            break;
            //        case 6:
            //            label2.Text = "Haziran";
            //            break;
            //        case 7:
            //            label2.Text = "Temmuz";
            //            break;
            //        case 8:
            //            label2.Text = "Ağustos";
            //            break;
            //        case 9:
            //            label2.Text = "Eylüş";
            //            break;
            //        case 10:
            //            label2.Text = "Ekim";
            //            break;
            //        case 11:
            //            label2.Text = "Kasım";
            //            break;
            //        case 12:
            //            label2.Text = "Aralık";
            //            break;
            //        default:
            //            label2.Text = " Geçersiz Değer";
            //            break;
            //    }
        }
    }
}
